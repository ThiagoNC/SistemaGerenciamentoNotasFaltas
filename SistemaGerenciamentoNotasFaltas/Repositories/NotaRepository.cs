using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;

namespace SistemaGerenciamentoNotasFaltas.Repositories
{
    internal class NotaRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public NotaRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Nota nota)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Nota (id_matricula, tipo, valor, data_lancamento) VALUES (@idMatricula, @tipo, @valor, @dataLancamento)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", nota.IdMatricula);
                    comando.Parameters.AddWithValue("@tipo", nota.Tipo);
                    comando.Parameters.AddWithValue("@valor", nota.Valor);
                    comando.Parameters.AddWithValue("@dataLancamento", nota.DataLancamento == DateTime.MinValue ? DateTime.Now : nota.DataLancamento);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Nota nota)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "UPDATE Nota SET id_matricula = @idMatricula, tipo = @tipo, valor = @valor, data_lancamento = @dataLancamento WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", nota.IdMatricula);
                    comando.Parameters.AddWithValue("@tipo", nota.Tipo);
                    comando.Parameters.AddWithValue("@valor", nota.Valor);
                    comando.Parameters.AddWithValue("@dataLancamento", nota.DataLancamento);
                    comando.Parameters.AddWithValue("@id", nota.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM Nota WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Nota ListarPorId(int id)
        {
            Nota nota = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Id_Matricula, Tipo, Valor, Data_Lancamento FROM Nota WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nota = new Nota
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                IdMatricula = Convert.ToInt32(reader["Id_Matricula"]),
                                Tipo = reader["Tipo"].ToString(),
                                Valor = Convert.ToDecimal(reader["Valor"]),
                                DataLancamento = Convert.ToDateTime(reader["Data_Lancamento"])
                            };
                        }
                    }
                }
            }

            return nota;
        }

        public List<Nota> ListarPorMatricula(int idMatricula)
        {
            var notas = new List<Nota>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Id_Matricula, Tipo, Valor, Data_Lancamento FROM Nota WHERE id_matricula = @idMatricula";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idMatricula", idMatricula);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notas.Add(new Nota
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                IdMatricula = Convert.ToInt32(reader["Id_Matricula"]),
                                Tipo = reader["Tipo"].ToString(),
                                Valor = Convert.ToDecimal(reader["Valor"]),
                                DataLancamento = Convert.ToDateTime(reader["Data_Lancamento"])
                            });
                        }
                    }
                }
            }
            return notas;
        }
    }
}
