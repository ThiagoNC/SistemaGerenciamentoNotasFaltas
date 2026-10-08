using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class AlunoService
    {
        private readonly AlunoRepository _alunoRepository;

        public AlunoService() => _alunoRepository = new AlunoRepository();

        public void Inserir(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome)) throw new Exception("O nome do aluno é obrigatório.");

            if (string.IsNullOrWhiteSpace(aluno.Ra)) throw new Exception("O RA do aluno é obrigatório.");

            if (aluno.Ra.Length < 5) throw new Exception("O RA fornecido é inválido. Digite um RA completo.");

            _alunoRepository.Inserir(aluno);
        }

        public void Atualizar(Aluno aluno)
        {
            if (aluno.Id <= 0) throw new Exception("Aluno inválido para atualização.");

            if (string.IsNullOrWhiteSpace(aluno.Nome)) throw new Exception("O nome do aluno não pode ficar em branco.");

            _alunoRepository.Atualizar(aluno);
        }

        public void Excluir(int id)
        {
            if (id <= 0) throw new Exception("Selecione um aluno válido para excluir.");

            _alunoRepository.Excluir(id);
        }

        public Aluno ListarPorId(int id) => _alunoRepository.ListarPorId(id);

        public List<Aluno> ListarTodos() => _alunoRepository.ListarTodos();
    }
}
