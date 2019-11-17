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
            string strConxao = @"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=true; Initial Catalog=DigitalCar";
            string Query;
            Boolean falso = false;

            if (this.txtConsultarFuncionario.Text == String.Empty && cboFiltro.Text == String.Empty)
            {
                MessageBox.Show("Insira algum dado no campo");
                this.txtConsultarFuncionario.Focus();
                return;
            }

            if( cboFiltro.Text == "Codigo")
            {
                falso = true;
            }
            else if (cboFiltro.Text == "Nome")
            {
                falso = true;
            }

            if (cboFiltro.Text == "CPF")
            {
                falso = true;
            }


            if (cboFiltro.Text == "Codigo" && falso == true)
            {
                funcionario.Id = Convert.ToInt32(txtConsultarFuncionario.Text);
                Query = "SELECT * FROM Funcionario WHERE codigo_Funcionario = '" + funcionario.Id + "'";
            }
            else if (cboFiltro.Text == "Nome" && falso == true)
            {
                funcionario.Nome = txtConsultarFuncionario.Text;
                Query = "SELECT * FROM Funcionario WHERE nome = '" + funcionario.Nome + "'";
            }
            else
            {
                funcionario.Cpf = txtConsultarFuncionario.Text;
                Query = "SELECT * FROM Funcionario WHERE nome = '" + funcionario.Cpf + "'";
            }
                       
            
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if(falso == true)
            {
                dgListaFuncionario.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar a consulta!!! Verificar e inserir os dados novamente!");
            }

            
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
