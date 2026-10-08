using MySql.Data.MySqlClient;
using SistemaGerenciamentoNotasFaltas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Repositories
{
    internal class AlunoRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public AlunoRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Aluno aluno)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Aluno (ra, nome, email) VALUES (@ra, @nome, @email)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@ra", aluno.Ra);
                    comando.Parameters.AddWithValue("@nome", aluno.Nome);
                    comando.Parameters.AddWithValue("@email", aluno.Email);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Aluno aluno)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "UPDATE Aluno SET ra = @ra, nome = @nome, email = @email WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@ra", aluno.Ra);
                    comando.Parameters.AddWithValue("@nome", aluno.Nome);
                    comando.Parameters.AddWithValue("@email", aluno.Email);
                    comando.Parameters.AddWithValue("@id", aluno.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM Aluno WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Aluno ListarPorId(int id)
        {
            Aluno aluno = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Ra, Nome, Email FROM Aluno WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            aluno = new Aluno
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Ra = reader["Ra"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString()
                            };
                        }
                    }
                }
            }

            return aluno;
        }

        public List<Aluno> ListarTodos()
        {
            var alunos = new List<Aluno>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Ra, Nome, Email FROM Aluno";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alunos.Add(new Aluno
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Ra = reader["Ra"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString()
                            });
                        }
                    }
                }
            }
            return alunos;
        }
    }
}
