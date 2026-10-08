using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Models
{
    internal class Matricula
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdDisciplina { get; set; }
        public int IdProfessor { get; set; }
        public string Semestre { get; set; }

        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor Professor { get; set; }
    }
}
