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
            Boolean falso = true;


            if (cboFiltro.Text == "Codigo")
            {
                funcionario.Id = Convert.ToInt32(txtConsultarFuncionario.Text);
                Query = "SELECT * FROM Funcionario WHERE codigo_Funcionario = '" + funcionario.Nome + "'";
            }
            else if (cboFiltro.Text == "Nome")
            {
                funcionario.Nome = txtConsultarFuncionario.Text;
                Query = "SELECT * FROM Funcionario WHERE nome = '" + funcionario.Nome + "'";
            }
            else
            {
                funcionario.Cpf = txtConsultarFuncionario.Text;
                Query = "SELECT * FROM Funcionario WHERE nome = '" + funcionario.Cpf + "'";
            }
                        
            
            Query = "SELECT * FROM Funcionario WHERE nome = '" + funcionario.Nome + "'";
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
