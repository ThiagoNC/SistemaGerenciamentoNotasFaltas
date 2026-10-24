using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using EduSmart.Models;

namespace EduSmart.Repositories
{
    internal class NotaRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public NotaRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Nota nota)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Nota (idMatricula, tipo, valor, dataLancamento) VALUES (@idMatricula, @tipo, @valor, @dataLancamento)";

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
                string query = "UPDATE Nota SET idMatricula=@idMatricula, tipo=@tipo, valor=@valor, dataLancamento=@dataLancamento WHERE id=@id";

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
                string query = "DELETE FROM Nota WHERE id=@id";

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
                string query = "SELECT id, idMatricula, tipo, valor, dataLancamento FROM Nota WHERE id=@id";

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
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["idMatricula"]),
                                Tipo = reader["tipo"].ToString(),
                                Valor = Convert.ToDecimal(reader["valor"]),
                                DataLancamento = Convert.ToDateTime(reader["dataLancamento"])
                            };
                        }
                    }
                }
            }

            return nota;
        }

        public List<Nota> ListarPorNomeAluno(string nomeAluno)
        {
            var notas = new List<Nota>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"
                SELECT 
                    n.id, 
                    n.idMatricula, 
                    n.tipo,
                    n.valor,
                    n.dataLancamento,
                    a.nome AS NomeAluno, 
                    d.nome AS NomeDisciplina,
                    p.nome AS NomeProfessor
                FROM Nota n
                INNER JOIN Matricula m ON n.idMatricula = m.id
                INNER JOIN Aluno a ON m.idAluno = a.id
                INNER JOIN Disciplina d ON m.idDisciplina = d.id
                INNER JOIN Professor p ON m.idProfessor = p.id
                WHERE a.Nome LIKE @nome";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", $"%{nomeAluno}%");

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notas.Add(new Nota
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["idMatricula"]),
                                Tipo = reader["tipo"].ToString(),
                                Valor = Convert.ToDecimal(reader["valor"]),
                                DataLancamento = Convert.ToDateTime(reader["dataLancamento"]),
                                NomeAluno = reader["NomeAluno"].ToString(),
                                NomeDisciplina = reader["NomeDisciplina"].ToString(),
                                NomeProfessor = reader["NomeProfessor"].ToString()
                            });
                        }
                    }
                }
            }
            return notas;
        }

        public List<Nota> ListarPorMatricula(int idMatricula)
        {
            var notas = new List<Nota>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "SELECT id, idMatricula, tipo, valor, dataLancamento FROM Nota WHERE idMatricula=@idMatricula";

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
                                Id = Convert.ToInt32(reader["id"]),
                                IdMatricula = Convert.ToInt32(reader["idMatricula"]),
                                Tipo = reader["tipo"].ToString(),
                                Valor = Convert.ToDecimal(reader["valor"]),
                                DataLancamento = Convert.ToDateTime(reader["dataLancamento"])
                            });
                        }
                    }
                }
            }
            return notas;
        }
    }
}
