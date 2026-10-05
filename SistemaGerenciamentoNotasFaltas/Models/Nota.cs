using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Models
{
    internal class Nota
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
        public double ValorNota { get; set; }
    }
}
