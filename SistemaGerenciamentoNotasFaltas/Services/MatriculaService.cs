using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class MatriculaService
    {
        private readonly MatriculaRepository _matriculaRepository;
        private readonly NotaRepository _notaRepository;
        private readonly FaltaRepository _faltaRepository;

        public MatriculaService()
        {
            _matriculaRepository = new MatriculaRepository();
            _notaRepository = new NotaRepository();
            _faltaRepository = new FaltaRepository();
        }

        public void Inserir(Matricula matricula)
        {
            if (matricula.IdAluno <= 0) throw new Exception("Selecione um aluno válido.");

            if (matricula.IdDisciplina <= 0) throw new Exception("Selecione uma disciplina válida.");

            if (matricula.IdProfessor <= 0) throw new Exception("Professor responsável inválido.");

            if (string.IsNullOrWhiteSpace(matricula.Semestre)) throw new Exception("O semestre é obrigatório.");

            _matriculaRepository.Inserir(matricula);
        }

        public void Atualizar(Matricula matricula)
        {
            if (matricula.Id <= 0) throw new Exception("Matrícula inválida para atualização.");

            if (matricula.IdAluno <= 0) throw new Exception("Selecione um aluno válido.");

            if (matricula.IdDisciplina <= 0) throw new Exception("Selecione uma disciplina válida.");

            if (matricula.IdProfessor <= 0) throw new Exception("Professor responsável inválido.");

            if (string.IsNullOrWhiteSpace(matricula.Semestre)) throw new Exception("O semestre não pode ficar em branco.");

            _matriculaRepository.Atualizar(matricula);
        }

        public void Excluir(int id)
        {
            if (id <= 0) throw new Exception("Selecione uma matrícula válida para excluir.");

            _matriculaRepository.Excluir(id);
        }

        public Matricula ListarPorId(int id) => _matriculaRepository.ListarPorId(id);

        public List<Matricula> ListarPorProfessor(int idProfessor) => _matriculaRepository.ListarPorProfessor(idProfessor);

        public decimal CalcularMedia(int idMatricula)
        {
            var notas = _notaRepository.ListarPorMatricula(idMatricula);

            return notas.Count == 0 ? 0 : Math.Round(notas.Average(n => n.Valor), 2);
        }

        public decimal CalcularFrequencia(int idMatricula)
        {
            var matricula = _matriculaRepository.ListarPorId(idMatricula);

            if (matricula == null || matricula.Disciplina == null) return 0;

            int cargaHoraria = matricula.Disciplina.CargaHoraria;
            int totalFaltas = _faltaRepository.ListarPorMatricula(idMatricula).Sum(f => f.Quantidade);

            if (totalFaltas >= cargaHoraria) return 0;

            return Math.Round(((decimal)(cargaHoraria - totalFaltas) / cargaHoraria) * 100, 2);
        }
    }
}
