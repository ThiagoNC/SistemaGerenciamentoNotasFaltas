using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduSmart.Models;
using EduSmart.Repositories;

namespace EduSmart.Services
{
    public class AlertaRiscoService
    {
        private readonly MatriculaService _matriculaService;
        private readonly NotaService _notaService;
        private readonly FaltaService _faltaService;
        private readonly AlertaRiscoRepository _alertaRepository;

        public AlertaRiscoService()
        {
            _matriculaService = new MatriculaService();
            _notaService = new NotaService();
            _faltaService = new FaltaService();
            _alertaRepository = new AlertaRiscoRepository();
        }

        public async Task<List<AlertaRisco>> ExecutarAnaliseGeralAsync()
        {
            _alertaRepository.LimparAnalisesAntigas();

            var alertasGerados = new List<AlertaRisco>();

            var matriculas = _matriculaService.ListarTodos();

            foreach (var matricula in matriculas)
            {
                var notas = _notaService.ListarPorNomeAluno("").Where(n => n.IdMatricula == matricula.Id).ToList();
                var faltas = _faltaService.ListarPorNomeAluno("").Where(f => f.IdMatricula == matricula.Id).ToList();

                decimal media = notas.Any() ? notas.Average(n => n.Valor) : 0;
                int totalFaltas = faltas.Sum(f => f.Quantidade);

                var alerta = await AnalisarRiscoComIA(matricula.Id, media, totalFaltas);

                if (alerta != null)
                {
                    alerta.NomeAluno = matricula.NomeAluno;
                    alerta.NomeDisciplina = matricula.NomeDisciplina;
                    alertasGerados.Add(alerta);

                    _alertaRepository.Inserir(alerta);
                }
            }

            return alertasGerados;
        }

        private Task<AlertaRisco> AnalisarRiscoComIA(int idMatricula, decimal media, int faltas)
        {
            NivelRisco risco = NivelRisco.Baixo;
            string justificativa = "Desempenho satisfatório e frequência regular.";

            if (media < 5m || faltas >= 5)
            {
                risco = NivelRisco.Alto;
                justificativa = "Alerta crítico: probabilidade alta de reprovação por " + (media < 5m ? "nota insuficiente." : "excesso de faltas.");
            }
            else if (media < 7m || faltas >= 3)
            {
                risco = NivelRisco.Medio;
                justificativa = "Atenção: oscilação no rendimento ou faltas recentes requerem acompanhamento.";
            }

            return Task.FromResult(new AlertaRisco
            {
                IdMatricula = idMatricula,
                NivelRisco = risco,
                JustificativaIa = justificativa,
                DataAnalise = DateTime.Now
            });
        }
    }
}