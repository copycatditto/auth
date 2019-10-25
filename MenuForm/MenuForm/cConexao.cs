using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuForm
{
    public class cConexao // na verdade deveria chamar "cTab1" mas ok
    {
        private MySqlConnection oMySqlConnection;
        private MySqlDataAdapter oMySqlDataAdapter;

        private string chave_conexao()
        {
            // parametros para conexao para o banco MYSQL
            string oRetorno =
                " Persist Security Info=False;" +
                "server =10.39.46.41; " +  //
                "database =events; uid = events; pwd = events@2019";
            return oRetorno;
        }

        public DataTable RetornoTabelaDTs()
        {
            DataTable oListRetorno = new DataTable();
            try
            {
                oMySqlConnection = new MySqlConnection(chave_conexao());
                oMySqlConnection.Open();
                oMySqlDataAdapter = new MySqlDataAdapter("select * from tbl_eventos", oMySqlConnection);
                oMySqlDataAdapter.Fill(oListRetorno);
                oMySqlConnection.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
            return oListRetorno;
        }

    }
}
