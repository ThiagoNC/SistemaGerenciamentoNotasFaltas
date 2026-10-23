using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using EduSmart.Models;

namespace EduSmart.Repositories
{
    internal class FaltaRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public FaltaRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Falta falta)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Falta (id_matricula, data_falta, quantidade) VALUES (@idMatricula, @dataFalta, @quantidade)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", falta.IdMatricula);
                    comando.Parameters.AddWithValue("@dataFalta", falta.DataFalta);
                    comando.Parameters.AddWithValue("@quantidade", falta.Quantidade);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Falta falta)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "UPDATE Falta SET id_matricula = @idMatricula, data_falta = @dataFalta, quantidade = @quantidade WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", falta.IdMatricula);
                    comando.Parameters.AddWithValue("@dataFalta", falta.DataFalta);
                    comando.Parameters.AddWithValue("@quantidade", falta.Quantidade);
                    comando.Parameters.AddWithValue("@id", falta.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM Falta WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Falta ListarPorId(int id)
        {
            Falta falta = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Id_Matricula, Data_Falta, Quantidade FROM Falta WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            falta = new Falta
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                IdMatricula = Convert.ToInt32(reader["Id_Matricula"]),
                                DataFalta = Convert.ToDateTime(reader["Data_Falta"]),
                                Quantidade = Convert.ToInt32(reader["Quantidade"])
                            };
                        }
                    }
                }
            }

            return falta;
        }

        public List<Falta> ListarPorNomeAluno(string nomeAluno)
        {
            var faltas = new List<Falta>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"
                SELECT 
                    f.Id, 
                    f.IdMatricula, 
                    f.DataFalta, 
                    f.Quantidade,
                    a.Nome AS NomeAluno, 
                    d.Nome AS NomeDisciplina
                FROM Falta f
                INNER JOIN Matricula m ON f.IdMatricula = m.Id
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
                            faltas.Add(new Falta
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["idMatricula"]),
                                DataFalta = Convert.ToDateTime(reader["dataFalta"]),
                                Quantidade = Convert.ToInt32(reader["quantidade"]),
                                NomeAluno = reader["NomeAluno"].ToString(),
                                NomeDisciplina = reader["NomeDisciplina"].ToString()
                            });
                        }
                    }
                }
            }
            return faltas;
        }

        public List<Falta> ListarPorMatricula(int idMatricula)
        {
            var faltas = new List<Falta>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Id_Matricula, Data_Falta, Quantidade FROM Falta WHERE id_matricula = @idMatricula";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", idMatricula);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            faltas.Add(new Falta
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                IdMatricula = Convert.ToInt32(reader["Id_Matricula"]),
                                DataFalta = Convert.ToDateTime(reader["Data_Falta"]),
                                Quantidade = Convert.ToInt32(reader["Quantidade"])
                            });
                        }
                    }
                }
            }
            return faltas;
        }
    }
}
