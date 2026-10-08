using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Models
{
    internal class Nota
    {
        public int Id { get; set; }
        public int IdMatricula { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
