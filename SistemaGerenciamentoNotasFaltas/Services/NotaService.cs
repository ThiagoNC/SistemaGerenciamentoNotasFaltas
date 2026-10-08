using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class NotaService
    {
        private readonly NotaRepository _notaRepository;

        public NotaService() => _notaRepository = new NotaRepository();

        public void Inserir(Nota nota)
        {
            if (nota.IdMatricula <= 0) throw new Exception("Matrícula inválida.");

            if (string.IsNullOrWhiteSpace(nota.Tipo)) throw new Exception("O tipo de avaliação (ex: P1, Trabalho) é obrigatório.");

            if (nota.Valor < 0 || nota.Valor > 10) throw new Exception("A nota deve estar entre 0 e 10.");

            _notaRepository.Inserir(nota);
        }

        public void Atualizar(Nota nota)
        {
            if (nota.Id <= 0) throw new Exception("Nota inválida para atualização.");

            if (nota.IdMatricula <= 0) throw new Exception("Matrícula inválida.");

            if (string.IsNullOrWhiteSpace(nota.Tipo)) throw new Exception("O tipo de avaliação não pode ficar em branco.");

            if (nota.Valor < 0 || nota.Valor > 10) throw new Exception("A nota deve estar entre 0 e 10.");

            _notaRepository.Atualizar(nota);
        }

        public void Excluir(int id)
        {
            if (id <= 0) throw new Exception("Selecione uma nota válida para excluir.");

            _notaRepository.Excluir(id);
        }

        public Nota ListarPorId(int id) => _notaRepository.ListarPorId(id);

        public List<Nota> ListarPorMatricula(int idMatricula) => _notaRepository.ListarPorMatricula(idMatricula);
    }
}
