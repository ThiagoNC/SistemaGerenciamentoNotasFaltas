using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;

namespace SistemaGerenciamentoNotasFaltas.Repositories
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
