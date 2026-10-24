using System;
using System.Collections.Generic;
using System.Text;

namespace EduSmart.Models
{
    public class AlertaRisco
    {
        public int Id { get; set; }
        public int IdMatricula { get; set; }
        public NivelRisco NivelRisco { get; set; }
        public string JustificativaIa { get; set; }
        public DateTime DataAnalise { get; set; }

        public string NomeAluno { get; set; }
        public string NomeDisciplina { get; set; }
    }

    public enum NivelRisco
    {
        Baixo,
        Medio,
        Alto
    }
}
