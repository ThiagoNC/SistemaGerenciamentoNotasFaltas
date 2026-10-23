using System;
using System.Collections.Generic;
using System.Text;

namespace EduSmart.Models
{
    internal class Nota
    {
        public int Id { get; set; }
        public int IdMatricula { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }

        public string NomeAluno { get; set; }
        public string NomeDisciplina { get; set; }
    }
}
