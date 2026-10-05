using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGerenciamentoNotasFaltas.Repositories
{
    internal class ConexaoBanco
    {
        private readonly string stringConexao = "Server=localhost;Database=SistemaBarbearia;Uid=root;Pwd=1234;";

        public MySqlConnection GetConexao()
        {
            return new MySqlConnection(stringConexao);
        }
    }
}
