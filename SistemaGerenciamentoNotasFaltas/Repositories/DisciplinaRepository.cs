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

        public DisciplinaRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Disciplina disciplina)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Disciplina (nome, carga_horaria) VALUES (@nome, @cargaHoraria)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", disciplina.Nome);
                    comando.Parameters.AddWithValue("@cargaHoraria", disciplina.CargaHoraria);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Disciplina disciplina)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "UPDATE Disciplina SET nome = @nome, carga_horaria = @cargaHoraria WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", disciplina.Nome);
                    comando.Parameters.AddWithValue("@cargaHoraria", disciplina.CargaHoraria);
                    comando.Parameters.AddWithValue("@id", disciplina.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM Disciplina WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Disciplina ListarPorId(int id)
        {
            Disciplina disciplina = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Nome, Carga_Horaria FROM Disciplina WHERE id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            disciplina = new Disciplina
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nome = reader["Nome"].ToString(),
                                CargaHoraria = Convert.ToInt32(reader["Carga_Horaria"])
                            };
                        }
                    }
                }
            }

            return disciplina;
        }

        public List<Disciplina> ListarTodos()
        {
            var disciplinas = new List<Disciplina>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT Id, Nome, Carga_Horaria FROM Disciplina";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            disciplinas.Add(new Disciplina
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nome = reader["Nome"].ToString(),
                                CargaHoraria = Convert.ToInt32(reader["Carga_Horaria"])
                            });
                        }
                    }
                }
            }
            return disciplinas;
        }
    }
}
