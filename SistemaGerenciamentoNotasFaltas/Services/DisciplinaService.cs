using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class DisciplinaService
    {
        private readonly DisciplinaRepository _repository;

        public DisciplinaService()
        {
            _repository = new DisciplinaRepository();
        }

        public void Inserir(Disciplina disciplina)
        {
            if (string.IsNullOrWhiteSpace(disciplina.Nome)) throw new Exception("O nome é obrigatório.");
            if (disciplina.CargaHoraria <= 0) throw new Exception("A carga horária é obrigatória.");

            _repository.Inserir(disciplina);
        }

        public void Atualizar(Disciplina disciplina)
        {
            _repository.Atualizar(disciplina);
        }

        public void Deletar(int id)
        {
            if (id <= 0) throw new Exception("Selecione uma disciplina válida para excluir.");
            _repository.Deletar(id);
        }

        public List<Disciplina> ListarTodos() => _repository.ListarTodos();

        public List<Disciplina> ListarPorNome(string nome) => _repository.ListarPorNome(nome);
    }
}
