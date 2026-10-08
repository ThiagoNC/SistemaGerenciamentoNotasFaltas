using System;
using System.Collections.Generic;
using System.Text;
using SistemaGerenciamentoNotasFaltas.Models;
using SistemaGerenciamentoNotasFaltas.Repositories;

namespace SistemaGerenciamentoNotasFaltas.Services
{
    internal class FaltaService
    {
        private readonly FaltaRepository _faltaRepository;

        public FaltaService() => _faltaRepository = new FaltaRepository();

        public void Inserir(Falta falta)
        {
            if (falta.IdMatricula <= 0) throw new Exception("Matrícula inválida.");

            if (falta.Quantidade <= 0) throw new Exception("A quantidade de faltas deve ser maior que zero.");

            if (falta.DataFalta > DateTime.Now) throw new Exception("Não é possível lançar faltas para datas futuras.");

            _faltaRepository.Inserir(falta);
        }

        public void Atualizar(Falta falta)
        {
            if (falta.Id <= 0) throw new Exception("Falta inválida para atualização.");

            if (falta.IdMatricula <= 0) throw new Exception("Matrícula inválida.");

            if (falta.Quantidade <= 0) throw new Exception("A quantidade de faltas deve ser maior que zero.");

            if (falta.DataFalta > DateTime.Now) throw new Exception("Não é possível atualizar faltas para datas futuras.");

            _faltaRepository.Atualizar(falta);
        }

        public void Excluir(int id)
        {
            if (id <= 0) throw new Exception("Selecione um registro de falta válido para excluir.");

            _faltaRepository.Excluir(id);
        }

        public Falta ListarPorId(int id) => _faltaRepository.ListarPorId(id);

        public List<Falta> ListarPorMatricula(int idMatricula) => _faltaRepository.ListarPorMatricula(idMatricula);
    }
}
