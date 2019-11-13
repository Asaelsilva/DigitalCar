using bdDllEspecifica;
using DigitalCar.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCar
{
    public partial class ConsultarFuncionario : Form
    {
        public ConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = txtConsultarFuncionario.Text;
                        
            string strConxao = @"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=true; Initial Catalog=dbCrud";
            string Query = "SELECT * FROM Funcionario WHERE nome = '" + funcionario.Nome + "'";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgListaFuncionario.DataSource = dt;



        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgListaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strConxao = @"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=true; Initial Catalog=dbCrud";
            string Query = "SELECT * FROM Funcionario ";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgListaFuncionario.DataSource = dt;
        }
    }
}
