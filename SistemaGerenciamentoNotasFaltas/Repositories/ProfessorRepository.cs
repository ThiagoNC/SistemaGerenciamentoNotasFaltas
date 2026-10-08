using MySql.Data.MySqlClient;
using SistemaGerenciamentoNotasFaltas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Repositories
{
    internal class ProfessorRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public ProfessorRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Professor professor)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Professor (nome, email, senha_hash) VALUES (@nome, @email, @senhaHash)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", professor.Nome);
                    comando.Parameters.AddWithValue("@email", professor.Email);
                    comando.Parameters.AddWithValue("@senhaHash", professor.SenhaHash);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Professor professor)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "UPDATE Professor SET nome = @nome, email = @email, senha_hash = @senhaHash WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", professor.Nome);
                    comando.Parameters.AddWithValue("@email", professor.Email);
                    comando.Parameters.AddWithValue("@senhaHash", professor.SenhaHash);
                    comando.Parameters.AddWithValue("@id", professor.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM Professor WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Professor ListarPorId(int id)
        {
            Professor professor = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Nome, Email, Senha_Hash FROM Professor WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            professor = new Professor
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString(),
                                SenhaHash = reader["Senha_Hash"].ToString()
                            };
                        }
                    }
                }
            }

            return professor;
        }

        public List<Professor> ListarTodos()
        {
            var professores = new List<Professor>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Nome, Email, Senha_Hash FROM Professor";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            professores.Add(new Professor
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString(),
                                SenhaHash = reader["Senha_Hash"].ToString()
                            });
                        }
                    }
                }
            }
            return professores;
        }

        public Professor ObterPorEmail(string email)
        {
            Professor professor = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Nome, Email, Senha_Hash FROM Professor WHERE email = @email";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@email", email);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            professor = new Professor
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString(),
                                SenhaHash = reader["Senha_Hash"].ToString()
                            };
                        }
                    }
                }
            }
            return professor;
        }
    }
}
