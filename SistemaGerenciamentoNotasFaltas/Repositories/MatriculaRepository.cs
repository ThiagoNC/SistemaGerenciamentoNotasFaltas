using MySql.Data.MySqlClient;
using SistemaGerenciamentoNotasFaltas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Repositories
{
    internal class MatriculaRepository
    {
        private readonly ConexaoBanco _conexaoBanco;

        public MatriculaRepository() => _conexaoBanco = new ConexaoBanco();

        public void Inserir(Matricula matricula)
        {
            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = "INSERT INTO Matricula (id_aluno, id_disciplina, id_professor, semestre) VALUES (@idAluno, @idDisciplina, @idProfessor, @semestre)";

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
                string query = "UPDATE Matricula SET id_aluno = @idAluno, id_disciplina = @idDisciplina, id_professor = @idProfessor, semestre = @semestre WHERE id = @id";

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
                string query = "DELETE FROM Matricula WHERE id = @id";

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
                SELECT m.id, m.id_aluno, m.id_disciplina, m.id_professor, m.semestre, 
                       a.nome AS NomeAluno, a.ra AS RaAluno, 
                       d.nome AS NomeDisciplina, 
                       p.nome AS NomeProfessor
                FROM Matricula m
                INNER JOIN Aluno a ON m.id_aluno = a.id
                INNER JOIN Disciplina d ON m.id_disciplina = d.id
                INNER JOIN Professor p ON m.id_professor = p.id
                WHERE m.id = @id";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            matricula = MapearMatriculaComJoin(reader);
                        }
                    }
                }
            }

            return matricula;
        }

        public List<Matricula> ListarPorProfessor(int idProfessor)
        {
            var matriculas = new List<Matricula>();

            using (var conexao = _conexaoBanco.GetConexao())
            {
                string query = @"
                SELECT m.id, m.id_aluno, m.id_disciplina, m.id_professor, m.semestre, 
                       a.nome AS NomeAluno, a.ra AS RaAluno, 
                       d.nome AS NomeDisciplina, 
                       p.nome AS NomeProfessor
                FROM Matricula m
                INNER JOIN Aluno a ON m.id_aluno = a.id
                INNER JOIN Disciplina d ON m.id_disciplina = d.id
                INNER JOIN Professor p ON m.id_professor = p.id
                WHERE m.id_professor = @idProfessor";

                using (var comando = new MySqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@idProfessor", idProfessor);

                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            matriculas.Add(MapearMatriculaComJoin(reader));
                        }
                    }
                }
            }
            return matriculas;
        }

        private Matricula MapearMatriculaComJoin(MySqlDataReader reader)
        {
            return new Matricula
            {
                Id = Convert.ToInt32(reader["id"]),
                IdAluno = Convert.ToInt32(reader["id_aluno"]),
                IdDisciplina = Convert.ToInt32(reader["id_disciplina"]),
                IdProfessor = Convert.ToInt32(reader["id_professor"]),
                Semestre = reader["semestre"].ToString(),

                Aluno = new Aluno
                {
                    Id = Convert.ToInt32(reader["id_aluno"]),
                    Nome = reader["NomeAluno"].ToString(),
                    Ra = reader["RaAluno"].ToString()
                },
                Disciplina = new Disciplina
                {
                    Id = Convert.ToInt32(reader["id_disciplina"]),
                    Nome = reader["NomeDisciplina"].ToString()
                },
                Professor = new Professor
                {
                    Id = Convert.ToInt32(reader["id_professor"]),
                    Nome = reader["NomeProfessor"].ToString()
                }
            };
        }
    }
}
