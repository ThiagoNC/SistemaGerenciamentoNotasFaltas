using MySql.Data.MySqlClient;
using EduSmart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduSmart.Repositories
{
    internal class MatriculaRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public MatriculaRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Matricula matricula)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Matricula (idAluno, idDisciplina, idProfessor, semestre) VALUES (@idAluno, @idDisciplina, @idProfessor, @semestre)";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idAluno", matricula.IdAluno);
                    comando.Parameters.AddWithValue("@idDisciplina", matricula.IdDisciplina);
                    comando.Parameters.AddWithValue("@idProfessor", matricula.IdProfessor);
                    comando.Parameters.AddWithValue("@semestre", matricula.Semestre);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Matricula matricula)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "UPDATE Matricula SET idAluno=@idAluno, idDisciplina=@idDisciplina, idProfessor=@idProfessor, semestre=@semestre WHERE id=@id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idAluno", matricula.IdAluno);
                    comando.Parameters.AddWithValue("@idDisciplina", matricula.IdDisciplina);
                    comando.Parameters.AddWithValue("@idProfessor", matricula.IdProfessor);
                    comando.Parameters.AddWithValue("@semestre", matricula.Semestre);
                    comando.Parameters.AddWithValue("@id", matricula.Id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "DELETE FROM Matricula WHERE id=@id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Matricula ListarPorId(int id)
        {
            Matricula matricula = null;

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"
                SELECT 
                    m.id, 
                    m.idAluno, 
                    m.idDisciplina, 
                    m.idProfessor,
                    m.semestre,
                    a.Nome AS NomeAluno, 
                    d.Nome AS NomeDisciplina,
                    p.Nome AS NomeProfessor
                FROM Matricula m
                INNER JOIN Aluno a ON m.idAluno = a.Id
                INNER JOIN Disciplina d ON m.idDisciplina = d.Id
                INNER JOIN Professor p ON m.idProfessor = p.Id
                WHERE m.id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            matricula = new Matricula
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdAluno = Convert.ToInt32(reader["idAluno"]),
                                IdDisciplina = Convert.ToInt32(reader["idDisciplina"]),
                                IdProfessor = Convert.ToInt32(reader["idProfessor"]),
                                Semestre = reader["semestre"].ToString(),
                                NomeAluno = reader["NomeAluno"].ToString(),
                                NomeDisciplina = reader["NomeDisciplina"].ToString(),
                                NomeProfessor = reader["NomeProfessor"].ToString()
                            };
                        }
                    }
                }
            }
            return matricula;
        }

        public List<Matricula> ListarPorNomeAluno(string nomeAluno)
        {
            var matriculas = new List<Matricula>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"
                SELECT 
                    m.Id, 
                    m.IdAluno, 
                    m.IdDisciplina, 
                    m.IdProfessor,
                    m.Semestre,
                    a.Nome AS NomeAluno, 
                    d.Nome AS NomeDisciplina,
                    p.Nome AS NomeProfessor
                FROM Matricula m
                INNER JOIN Aluno a ON m.IdAluno = a.Id
                INNER JOIN Disciplina d ON m.IdDisciplina = d.Id
                INNER JOIN Professor p ON m.IdProfessor = p.Id
                WHERE a.Nome LIKE @nome";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", $"%{nomeAluno}%");

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            matriculas.Add(new Matricula
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdAluno = Convert.ToInt32(reader["idAluno"]),
                                IdDisciplina = Convert.ToInt32(reader["idDisciplina"]),
                                IdProfessor = Convert.ToInt32(reader["idProfessor"]),
                                Semestre = reader["semestre"].ToString(),
                                NomeAluno = reader["NomeAluno"].ToString(),
                                NomeDisciplina = reader["NomeDisciplina"].ToString(),
                                NomeProfessor = reader["NomeProfessor"].ToString()
                            });
                        }
                    }
                }
            }
            return matriculas;
        }

        public List<Matricula> ListarPorProfessor(int idProfessor)
        {
            var matriculas = new List<Matricula>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"
                SELECT m.id, m.idAluno, m.idDisciplina, m.idProfessor, m.semestre, 
                       a.nome AS NomeAluno, a.ra AS RaAluno, 
                       d.nome AS NomeDisciplina, 
                       p.nome AS NomeProfessor
                FROM Matricula m
                INNER JOIN Aluno a ON m.idAluno = a.id
                INNER JOIN Disciplina d ON m.idDisciplina = d.id
                INNER JOIN Professor p ON m.idProfessor = p.id
                WHERE m.idProfessor = @idProfessor";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idProfessor", idProfessor);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            matriculas.Add(new Matricula
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdAluno = Convert.ToInt32(reader["idAluno"]),
                                IdDisciplina = Convert.ToInt32(reader["idDisciplina"]),
                                IdProfessor = Convert.ToInt32(reader["idProfessor"]),
                                Semestre = reader["semestre"].ToString(),
                                NomeAluno = reader["NomeAluno"].ToString(),
                                NomeDisciplina = reader["NomeDisciplina"].ToString(),
                                NomeProfessor = reader["NomeProfessor"].ToString()
                            });
                        }
                    }
                }
            }
            return matriculas;
        }
    }
}
