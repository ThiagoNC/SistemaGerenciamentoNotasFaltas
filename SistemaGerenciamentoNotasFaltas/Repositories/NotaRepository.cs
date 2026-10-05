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

        public NotaRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Nota nota)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Nota (alunoId, disciplinaId, valorNota) VALUES (@alunoId, @disciplinaId, @valorNota)";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@alunoId", nota.AlunoId);
                comando.Parameters.AddWithValue("@disciplinaId", nota.DisciplinaId);
                comando.Parameters.AddWithValue("@valorNota", nota.ValorNota);


                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(Nota nota)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Nota SET valorNota = @valorNota WHERE alunoId = @alunoId and disciplinaId = @disciplinaId";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@alunoId", nota.AlunoId);
                comando.Parameters.AddWithValue("@disciplinaId", nota.DisciplinaId);
                comando.Parameters.AddWithValue("@valorNota", nota.ValorNota);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Deletar(int alunoId, int disciplinaId)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Nota WHERE alunoId = @alunoId AND disciplinaId = @disciplinaId";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@alunoId", alunoId);
                comando.Parameters.AddWithValue("@disciplinaId", disciplinaId);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Nota> ListarTodos()
        {
            var lista = new List<Nota>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT alunoId, disciplinaId, valorNota FROM Nota";
                var comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Nota
                        {
                            AlunoId = Convert.ToInt32(reader["alunoId"]),
                            DisciplinaId = Convert.ToInt32(reader["disciplinaId"]),
                            ValorNota = Convert.ToDouble(reader["valorNota"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Nota> ListarPorNome(string nome)
        {
            var lista = new List<Nota>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT alunoId, disciplinaId, valorNota FROM Nota WHERE nome LIKE @nome";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Nota
                        {
                            AlunoId = Convert.ToInt32(reader["alunoId"]),
                            DisciplinaId = Convert.ToInt32(reader["disciplinaId"]),
                            ValorNota = Convert.ToDouble(reader["valorNota"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}
