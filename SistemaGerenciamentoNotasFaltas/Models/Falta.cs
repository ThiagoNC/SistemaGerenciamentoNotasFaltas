using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Models
{
    internal class Falta
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
        public DateTime DataFalta { get; set; }
    }
}
