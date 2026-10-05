using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class FaltaService
    {
        private readonly FaltaRepository _repository;

        public FaltaService()
        {
            _repository = new FaltaRepository();
        }

        public void Inserir(Falta falta)
        {
            if (falta.AlunoId <= 0) throw new Exception("O aluno é obrigatório.");
            if (falta.DisciplinaId <= 0) throw new Exception("A disciplina é obrigatória.");

            _repository.Inserir(falta);
        }

        public void Atualizar(Falta falta)
        {
            _repository.Atualizar(falta);
        }

        public void Deletar(int alunoId, int disciplinaId)
        {
            if (alunoId <= 0) throw new Exception("Selecione um aluno válido para excluir uma falta.");
            if (disciplinaId <= 0) throw new Exception("Selecione uma disciplina válida para excluir uma falta.");
            _repository.Deletar(alunoId, disciplinaId);
        }

        public List<Falta> ListarTodos() => _repository.ListarTodos();

        public List<Falta> ListarPorNome(string nome) => _repository.ListarPorNome(nome);
    }
}
