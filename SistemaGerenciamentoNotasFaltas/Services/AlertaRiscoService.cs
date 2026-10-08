using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class AlertaRiscoService
    {
        private readonly AlertaRiscoRepository _alertaRiscoRepository;
        private readonly MatriculaService _matriculaService;

        public AlertaRiscoService()
        {
            _alertaRiscoRepository = new AlertaRiscoRepository();

            _matriculaService = new MatriculaService();
        }

        public void Inserir(AlertaRisco alerta)
        {
            if (alerta.IdMatricula <= 0) throw new Exception("Matrícula inválida.");

            if (string.IsNullOrWhiteSpace(alerta.JustificativaIa)) throw new Exception("A justificativa da IA é obrigatória.");

            _alertaRiscoRepository.Inserir(alerta);
        }

        public void Atualizar(AlertaRisco alerta)
        {
            if (alerta.Id <= 0) throw new Exception("Alerta inválido para atualização.");

            if (alerta.IdMatricula <= 0) throw new Exception("Matrícula inválida.");

            if (string.IsNullOrWhiteSpace(alerta.JustificativaIa)) throw new Exception("A justificativa da IA não pode ficar em branco.");

            _alertaRiscoRepository.Atualizar(alerta);
        }

        public void Excluir(int id)
        {
            if (id <= 0) throw new Exception("Selecione um alerta válido para excluir.");

            _alertaRiscoRepository.Excluir(id);
        }

        public AlertaRisco ListarPorId(int id) => _alertaRiscoRepository.ListarPorId(id);

        public List<AlertaRisco> ListarPorMatricula(int idMatricula) => _alertaRiscoRepository.ListarPorMatricula(idMatricula);

        public void GerarAlertaComIA(int idMatricula)
        {
            decimal media = _matriculaService.CalcularMedia(idMatricula);
            decimal frequencia = _matriculaService.CalcularFrequencia(idMatricula);

            string prompt = $@"
            Você é um assistente educacional de uma faculdade. Analise o seguinte aluno:
            - Média atual: {media} (notas variam de 0 a 10)
            - Frequência atual: {frequencia}%
            
            Retorne um nível de risco de reprovação (Baixo, Medio ou Alto) e uma justificativa curta (máximo de 3 linhas).";

            /*
            var novoAlerta = new AlertaRisco
            {
                IdMatricula = idMatricula,
                NivelRisco = NivelRisco.Alto, // Pegar da resposta da API
                JustificativaIa = "Aluno com média e frequência muito baixas.", // Pegar da resposta da API
                DataAnalise = DateTime.Now
            };

            Inserir(novoAlerta);
            */

            throw new NotImplementedException("A integração direta com a API da IA será implementada na próxima fase do projeto EduSmart.");
        }
    }
}
