using MySql.Data.MySqlClient;
using EduSmart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduSmart.Repositories
{
    internal class AlertaRiscoRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public AlertaRiscoRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(AlertaRisco alerta)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Alerta_Risco (id_matricula, nivel_risco, justificativa_ia, data_analise) VALUES (@idMatricula, @nivelRisco, @justificativaIa, @dataAnalise)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", alerta.IdMatricula);
                    comando.Parameters.AddWithValue("@nivelRisco", alerta.NivelRisco.ToString()); // Converte o Enum para texto
                    comando.Parameters.AddWithValue("@justificativaIa", alerta.JustificativaIa);
                    comando.Parameters.AddWithValue("@dataAnalise", alerta.DataAnalise == DateTime.MinValue ? DateTime.Now : alerta.DataAnalise);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(AlertaRisco alerta)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "UPDATE Alerta_Risco SET id_matricula = @idMatricula, nivel_risco = @nivelRisco, justificativa_ia = @justificativaIa, data_analise = @dataAnalise WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", alerta.IdMatricula);
                    comando.Parameters.AddWithValue("@nivelRisco", alerta.NivelRisco.ToString());
                    comando.Parameters.AddWithValue("@justificativaIa", alerta.JustificativaIa);
                    comando.Parameters.AddWithValue("@dataAnalise", alerta.DataAnalise);
                    comando.Parameters.AddWithValue("@id", alerta.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM Alerta_Risco WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public AlertaRisco ListarPorId(int id)
        {
            AlertaRisco alerta = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT id, id_matricula, nivel_risco, justificativa_ia, data_analise FROM Alerta_Risco WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            alerta = new AlertaRisco
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["id_matricula"]),
                                NivelRisco = (NivelRisco)Enum.Parse(typeof(NivelRisco), reader["nivel_risco"].ToString()), // Converte o texto do banco de volta para o Enum
                                JustificativaIa = reader["justificativa_ia"].ToString(),
                                DataAnalise = Convert.ToDateTime(reader["data_analise"])
                            };
                        }
                    }
                }
            }

            return alerta;
        }

        public List<AlertaRisco> ListarPorNomeAluno(string nomeAluno)
        {
            var alertas = new List<AlertaRisco>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"
                SELECT 
                    ar.Id, 
                    ar.IdMatricula, 
                    ar.NivelRisco,
                    ar.JustificativaIa,
                    ar.DataAnalise,
                    a.Nome AS NomeAluno, 
                    d.Nome AS NomeDisciplina
                FROM AlertaRisco ar
                INNER JOIN Matricula m ON ar.IdMatricula = m.Id
                INNER JOIN Aluno a ON m.IdAluno = a.Id
                INNER JOIN Disciplina d ON m.IdDisciplina = d.Id
                WHERE a.Nome LIKE @nome";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", $"%{nomeAluno}%");

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alertas.Add(new AlertaRisco
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["idMatricula"]),
                                NivelRisco = (NivelRisco)Enum.Parse(typeof(NivelRisco), reader["nivelRisco"].ToString()),
                                JustificativaIa = reader["justificativaIa"].ToString(),
                                DataAnalise = Convert.ToDateTime(reader["dataAnalise"]),
                                NomeAluno = reader["NomeAluno"].ToString(),
                                NomeDisciplina = reader["NomeDisciplina"].ToString()
                            });
                        }
                    }
                }
            }
            return alertas;
        }

        public List<AlertaRisco> ListarPorMatricula(int idMatricula)
        {
            var alertas = new List<AlertaRisco>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT id, id_matricula, nivel_risco, justificativa_ia, data_analise FROM Alerta_Risco WHERE id_matricula = @idMatricula ORDER BY data_analise DESC";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", idMatricula);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alertas.Add(new AlertaRisco
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["id_matricula"]),
                                NivelRisco = (NivelRisco)Enum.Parse(typeof(NivelRisco), reader["nivel_risco"].ToString()),
                                JustificativaIa = reader["justificativa_ia"].ToString(),
                                DataAnalise = Convert.ToDateTime(reader["data_analise"])
                            });
                        }
                    }
                }
            }
            return alertas;
        }
    }
}
