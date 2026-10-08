using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class DisciplinaService
    {
        private readonly DisciplinaRepository _disciplinaRepository;

        public DisciplinaService() => _disciplinaRepository = new DisciplinaRepository();

        public void Inserir(Disciplina disciplina)
        {
            if (string.IsNullOrWhiteSpace(disciplina.Nome)) throw new Exception("O nome da disciplina é obrigatório.");

            if (disciplina.CargaHoraria <= 0) throw new Exception("A carga horária deve ser maior que zero.");

            _disciplinaRepository.Inserir(disciplina);
        }

        public void Atualizar(Disciplina disciplina)
        {
            if (disciplina.Id <= 0) throw new Exception("Disciplina inválida para atualização.");

            if (string.IsNullOrWhiteSpace(disciplina.Nome)) throw new Exception("O nome da disciplina não pode ficar em branco.");

            if (disciplina.CargaHoraria <= 0) throw new Exception("A carga horária deve ser maior que zero.");

            _disciplinaRepository.Atualizar(disciplina);
        }

        public void Excluir(int id)
        {
            if (id <= 0) throw new Exception("Selecione uma disciplina válida para excluir.");

            _disciplinaRepository.Excluir(id);
        }

        public Disciplina ListarPorId(int id) => _disciplinaRepository.ListarPorId(id);

        public List<Disciplina> ListarTodos() => _disciplinaRepository.ListarTodos();
    }
}
