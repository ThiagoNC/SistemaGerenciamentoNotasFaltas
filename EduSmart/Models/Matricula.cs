using System;
using System.Collections.Generic;
using System.Text;

namespace EduSmart.Models
{
    internal class Matricula
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdDisciplina { get; set; }
        public int IdProfessor { get; set; }
        public string Semestre { get; set; }

        public string NomeAluno { get; set; }
        public string NomeDisciplina { get; set; }
        public string NomeProfessor { get; set; }
    }
}
