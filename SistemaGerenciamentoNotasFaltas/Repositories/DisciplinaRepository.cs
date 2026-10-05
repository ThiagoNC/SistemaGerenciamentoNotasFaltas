using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;

namespace SistemaGerenciamentoNotasFaltas.Repositories
{
    internal class DisciplinaRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public DisciplinaRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Disciplina disciplina)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Disciplina (nome, cargaHoraria) VALUES (@nome, @cargaHoraria)";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", disciplina.Nome);
                comando.Parameters.AddWithValue("@cargaHoraria", disciplina.CargaHoraria);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(Disciplina disciplina)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Disciplina SET nome = @nome, cargaHoraria = @cargaHoraria WHERE id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", disciplina.Nome);
                comando.Parameters.AddWithValue("@cargaHoraria", disciplina.CargaHoraria);
                comando.Parameters.AddWithValue("@id", disciplina.Id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Disciplina WHERE id = @id";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Disciplina> ListarTodos()
        {
            var lista = new List<Disciplina>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT id, nome, cargaHoraria FROM Disciplina";
                var comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Disciplina
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            CargaHoraria = Convert.ToInt32(reader["cargaHoraria"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Disciplina> ListarPorNome(string nome)
        {
            var lista = new List<Disciplina>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT id, nome, cargaHoraria FROM Disciplina WHERE nome LIKE @nome";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Disciplina
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = reader["nome"].ToString(),
                            CargaHoraria = Convert.ToInt32(reader["cargaHoraria"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}
