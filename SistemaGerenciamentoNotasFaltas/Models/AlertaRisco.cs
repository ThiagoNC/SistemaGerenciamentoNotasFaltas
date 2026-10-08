using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Models
{
    internal class AlertaRisco
    {
        public int Id { get; set; }
        public int IdMatricula { get; set; }
        public NivelRisco NivelRisco { get; set; }
        public string JustificativaIa { get; set; }
        public DateTime DataAnalise { get; set; }
    }

    internal enum NivelRisco
    {
        Baixo,
        Medio,
        Alto
    }
}
