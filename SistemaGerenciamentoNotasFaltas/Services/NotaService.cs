using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class NotaService
    {
        private readonly NotaRepository _repository;

        public NotaService()
        {
            _repository = new NotaRepository();
        }

        public void Inserir(Nota nota)
        {
            if (nota.AlunoId <= 0) throw new Exception("O aluno é obrigatório.");
            if (nota.DisciplinaId <= 0) throw new Exception("A disciplina é obrigatória.");
            if (nota.ValorNota < 0) throw new Exception("A nota não é válida.");

            _repository.Inserir(nota);
        }

        public void Atualizar(Nota nota)
        {
            _repository.Atualizar(nota);
        }

        public void Deletar(int alunoId, int disciplinaId)
        {
            if (alunoId <= 0) throw new Exception("Selecione um aluno válido para excluir uma nota.");
            if (disciplinaId <= 0) throw new Exception("Selecione uma disciplina válida para excluir uma nota.");
            _repository.Deletar(alunoId, disciplinaId);
        }

        public List<Nota> ListarTodos() => _repository.ListarTodos();

        public List<Nota> ListarPorNome(string nome) => _repository.ListarPorNome(nome);
    }
}
