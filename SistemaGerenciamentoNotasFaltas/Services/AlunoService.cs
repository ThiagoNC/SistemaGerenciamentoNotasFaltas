using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class AlunoService
    {
        private readonly AlunoRepository _repository;

        public AlunoService()
        {
            _repository = new AlunoRepository();
        }

        public void Inserir(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome)) throw new Exception("O nome é obrigatório.");
            if (aluno.Matricula <= 0) throw new Exception("A matrícula é obrigatório.");

            _repository.Inserir(aluno);
        }

        public void Atualizar(Aluno aluno)
        {
            _repository.Atualizar(aluno);
        }

        public void Deletar(int id)
        {
            if (id <= 0) throw new Exception("Selecione um aluno válido para excluir.");
            _repository.Deletar(id);
        }

        public List<Aluno> ListarTodos() => _repository.ListarTodos();

        public List<Aluno> ListarPorNome(string nome) => _repository.ListarPorNome(nome);
    }
}
