using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class ProfessorService
    {
        private readonly ProfessorRepository _professorRepository;

        public ProfessorService() => _professorRepository = new ProfessorRepository();

        public void Inserir(Professor professor)
        {
            if (string.IsNullOrWhiteSpace(professor.Nome)) throw new Exception("O nome do professor é obrigatório.");

            if (string.IsNullOrWhiteSpace(professor.Email)) throw new Exception("O e-mail do professor é obrigatório.");

            if (string.IsNullOrWhiteSpace(professor.SenhaHash)) throw new Exception("A senha é obrigatória.");

            _professorRepository.Inserir(professor);
        }

        public void Atualizar(Professor professor)
        {
            if (professor.Id <= 0) throw new Exception("Professor inválido para atualização.");

            if (string.IsNullOrWhiteSpace(professor.Nome)) throw new Exception("O nome do professor não pode ficar em branco.");

            if (string.IsNullOrWhiteSpace(professor.Email)) throw new Exception("O e-mail do professor não pode ficar em branco.");

            _professorRepository.Atualizar(professor);
        }

        public void Excluir(int id)
        {
            if (id <= 0) throw new Exception("Selecione um professor válido para excluir.");

            _professorRepository.Excluir(id);
        }

        public Professor ListarPorId(int id) => _professorRepository.ListarPorId(id);

        public List<Professor> ListarTodos() => _professorRepository.ListarTodos();

        public Professor Autenticar(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new Exception("O e-mail é obrigatório.");
            if (string.IsNullOrWhiteSpace(senha)) throw new Exception("A senha é obrigatória.");

            var professor = _professorRepository.ObterPorEmail(email);

            if (professor == null) throw new Exception("E-mail ou senha inválidos.");

            if (professor.SenhaHash != senha) throw new Exception("E-mail ou senha inválidos.");

            return professor;
        }
    }
}
