using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Autenticacao
{
    public class cConexao
    {
        private MySqlConnection oMySqlConnection;
        private MySqlDataAdapter oMySqlDataAdapter;
        private MySqlDataReader oMySqlDataReader;

        // public List<cListTableLogin> ListRetornoLogin;

        private string chave_conexao()
        {
			// parametros para conexao para o banco MYSQL
            string oRetorno =
                " Persist Security Info=False;" +
                "server =10.39.46.41; " +  //
                "database =events; uid = events; pwd = events@2019";
            return oRetorno;
        }

        public List<cListTableLogin> ListRetornoLogin(String p_login, String p_senha)
        {
            List<cListTableLogin> oListRetorno = new List<cListTableLogin>();
            try
            {
                oMySqlConnection = new MySqlConnection(chave_conexao());
                oMySqlConnection.Open();
                MySqlCommand oCommand = new MySqlCommand("select * from tbl_usuario where login = '" + p_login +
                    "' and senha = '" + p_login + "'", oMySqlConnection);

                oMySqlDataReader = oCommand.ExecuteReader();

                while (oMySqlDataReader.Read())
                {
                    oListRetorno.Add(new cListTableLogin()
                    {
                        f_id_usuario = 1 ,
                        f_nome = oMySqlDataReader[1].ToString(),
                        f_login = oMySqlDataReader[2].ToString(),
                        f_senha = oMySqlDataReader[3].ToString(),
                        f_status = 1 , //oMySqlDataReader[4].ToString(),
                        f_dt_troca_senha = DateTime.Now, // oMySqlDataReader[5].ToString(),
                        f_aviso_troca = DateTime.Now , // oMySqlDataReader[6].ToString(),
                        f_aviso_lock = 1 , //oMySqlDataReader[7].ToString(),
                        f_dt_cadastro = DateTime.Now, //oMySqlDataReader[8].ToString(),
                        f_dt_alteracao = DateTime.Now, //oMySqlDataReader[9].ToString(),
                        f_dt_ultimo_login = DateTime.Now, // oMySqlDataReader[10].ToString(),
                        f_email = oMySqlDataReader[11].ToString(),
                        f_telefone = oMySqlDataReader[12].ToString()
                    });
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return oListRetorno;
        }

        public DataTable DataTableRetornoLogin(String p_login, String p_senha)
        {
            DataTable oListRetorno = new DataTable();
            try
            {
                oMySqlConnection = new MySqlConnection(chave_conexao());
                oMySqlConnection.Open();
                oMySqlDataAdapter = new MySqlDataAdapter("select * from tbl_usuario where login = '" + p_login +
                    "' and senha = '" + p_senha + "'", oMySqlConnection);
                oMySqlDataAdapter.Fill(oListRetorno);
                oMySqlConnection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return oListRetorno;
        }
     
        public DataSet RetornoLoginDTs(String p_login, String p_senha)
        {
            DataSet oListRetorno = new DataSet();
            try
            {
                oMySqlConnection = new MySqlConnection(chave_conexao());
                oMySqlConnection.Open();
                oMySqlDataAdapter = new MySqlDataAdapter("select * from tbl_usuario where login = '" + p_login +
                    "' and senha = '" + p_senha + "'", oMySqlConnection);
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
