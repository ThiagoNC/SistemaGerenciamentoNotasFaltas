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

        public AlunoRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Aluno aluno)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Aluno (nome, matricula) VALUES (@nome, @matricula)";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", aluno.Nome);
                comando.Parameters.AddWithValue("@matricula", aluno.Matricula);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(Aluno aluno)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Aluno SET nome = @nome, matricula = @matricula WHERE id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", aluno.Nome);
                comando.Parameters.AddWithValue("@matricula", aluno.Matricula);
                comando.Parameters.AddWithValue("@id", aluno.Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Aluno WHERE id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Aluno> ListarTodos()
        {
            var lista = new List<Aluno>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT id, nome, matricula FROM Aluno";
                var comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Aluno
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Matricula = Convert.ToInt32(reader["matricula"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Aluno> ListarPorNome(string nome)
        {
            var lista = new List<Aluno>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT id, nome, matricula FROM Aluno WHERE nome LIKE @nome";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Aluno
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            Matricula = Convert.ToInt32(reader["matricula"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}
