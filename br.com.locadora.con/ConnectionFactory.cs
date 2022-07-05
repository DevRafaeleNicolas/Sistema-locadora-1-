using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_locadora.br.com.locadora.con
{
    class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.
                                ConnectionStrings["bd_locadora"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }


   
}
