using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForm
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent(); // pode copiar mas não faz igualzinho
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cConexao ocConexao = new cConexao();

            oDataTable = ocConexao.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab1 ocTab1 = new cTab1();

            oDataTable = ocTab1.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab3 ocTab3 = new cTab3();

            oDataTable = ocTab3.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab4 ocTab4 = new cTab4();

            oDataTable = ocTab4.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab5 ocTab5 = new cTab5();

            oDataTable = ocTab5.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab6 ocTab6 = new cTab6();
            
            oDataTable = ocTab6.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab7 ocTab7 = new cTab7();

            oDataTable = ocTab7.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab8 ocTab8 = new cTab8();

            oDataTable = ocTab8.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            DataTable oDataTable = new DataTable();

            cTab9 ocTab9 = new cTab9();

            oDataTable = ocTab9.RetornoTabelaDTs();

            dataGridView1.DataSource = oDataTable;
            dataGridView1.Refresh();
        }
    }
}
