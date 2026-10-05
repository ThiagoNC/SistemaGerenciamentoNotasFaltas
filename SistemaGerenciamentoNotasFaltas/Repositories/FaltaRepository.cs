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

        public FaltaRepository()
        {
            _conexaoBanco = new ConexaoBanco();
        }

        public void Inserir(Falta falta)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "INSERT INTO Falta (alunoId, disciplinaId, dataFalta) VALUES (@alunoId, @disciplinaId, @dataFalta)";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@alunoId", falta.AlunoId);
                comando.Parameters.AddWithValue("@disciplinaId", falta.DisciplinaId);
                comando.Parameters.AddWithValue("@dataFalta", falta.DataFalta);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Atualizar(Falta falta)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "UPDATE Falta SET dataFalta = @dataFalta WHERE alunoId = @alunoId and disciplinaId = @disciplinaId";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@alunoId", falta.AlunoId);
                comando.Parameters.AddWithValue("@disciplinaId", falta.DisciplinaId);
                comando.Parameters.AddWithValue("@dataFalta", falta.DataFalta);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Deletar(int alunoId, int disciplinaId)
        {
            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "DELETE FROM Falta WHERE alunoId = @alunoId AND disciplinaId = @disciplinaId ";

                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@alunoId", alunoId);
                comando.Parameters.AddWithValue("@disciplinaId", disciplinaId);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public List<Falta> ListarTodos()
        {
            var lista = new List<Falta>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT alunoId, disciplinaId, dataFalta FROM Falta";
                var comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Falta
                        {
                            AlunoId = Convert.ToInt32(reader["alunoId"]),
                            DisciplinaId = Convert.ToInt32(reader["disciplinaId"]),
                            DataFalta = Convert.ToDateTime(reader["dataFalta"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Falta> ListarPorNome(string nome)
        {
            var lista = new List<Falta>();

            using (MySqlConnection conexao = _conexaoBanco.GetConexao())
            {
                string sql = "SELECT alunoId, disciplinaId, dataFalta FROM Falta WHERE nome LIKE @nome";
                var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Falta
                        {
                            AlunoId = Convert.ToInt32(reader["alunoId"]),
                            DisciplinaId = Convert.ToInt32(reader["disciplinaId"]),
                            DataFalta = Convert.ToDateTime(reader["dataFalta"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}
