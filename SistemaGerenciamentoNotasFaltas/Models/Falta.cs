using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Models
{
    internal class Falta
    {
        public int Id { get; set; }
        public int IdMatricula { get; set; }
        public DateTime DataFalta { get; set; }
        public int Quantidade { get; set; }
    }
}
