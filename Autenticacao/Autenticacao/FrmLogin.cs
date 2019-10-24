using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autenticacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet oDataSet = new DataSet();
            DataTable oDataTable = new DataTable();

            cConexao ocConexao = new cConexao();

            List<cListTableLogin> oList = new List<cListTableLogin>();

            oDataSet = ocConexao.RetornoLoginDTs(textLogin.Text, textSenha.Text);

            oDataTable = ocConexao.DataTableRetornoLogin(textLogin.Text, textSenha.Text);

            oDataTable = ocConexao.RetornoLoginDTs(textLogin.Text, textSenha.Text).Tables[0];

            oList = ocConexao.ListRetornoLogin(textLogin.Text, textSenha.Text);



        }
    }
}
