using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using EduSmart.Models;

namespace EduSmart.Repositories
{
    public class AlertaRiscoRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public AlertaRiscoRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(AlertaRisco alerta)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"INSERT INTO AlertaRisco (IdMatricula, NivelRisco, JustificativaIa, DataAnalise) 
                                 VALUES (@idMatricula, @nivelRisco, @justificativa, @dataAnalise)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", alerta.IdMatricula);
                    comando.Parameters.AddWithValue("@nivelRisco", alerta.NivelRisco.ToString());
                    comando.Parameters.AddWithValue("@justificativa", alerta.JustificativaIa);
                    comando.Parameters.AddWithValue("@dataAnalise", alerta.DataAnalise);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<AlertaRisco> ListarTodos()
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
                    ORDER BY ar.DataAnalise DESC";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Enum.TryParse(reader["NivelRisco"].ToString(), out NivelRisco nivelRiscoEnum);

                            alertas.Add(new AlertaRisco
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["idMatricula"]),
                                NivelRisco = nivelRiscoEnum,
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

        public void LimparAnalisesAntigas()
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM AlertaRisco";
                using (var comando = new MySqlCommand(query, conexao))
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}