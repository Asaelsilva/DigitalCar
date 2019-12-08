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
            bool falso = false;

            //string total = "SELECT MAX(codigo_Funcionario) FROM Funcionario"


            if (this.txtConsultarFuncionario.Text == String.Empty && cboFiltro.Text == String.Empty)
            {
                MessageBox.Show("Escolha o filtro desejado e insira uma informação no campo ao lado!");
                this.txtConsultarFuncionario.Focus();
                return;
            }

            if (cboFiltro.Text == "Codigo" && this.txtConsultarFuncionario.Text.Length > 2)
            {
                MessageBox.Show("Funcionario nao enconrado");
                falso = false;
            }


            if (cboFiltro.Text == "Codigo" && txtConsultarFuncionario.Text.Length <= 2)
            {
                funcionario.Id = Convert.ToInt32(txtConsultarFuncionario.Text);
                Query = "SELECT * FROM Funcionario WHERE Id = '" + funcionario.Id + "'";
                falso = true;
            }
            else if (cboFiltro.Text == "CPF" && txtConsultarFuncionario.Text.Length >= 11)
            {
                funcionario.Cpf = txtConsultarFuncionario.Text;
                Query = "SELECT * FROM Funcionario WHERE cpf = '" + funcionario.Cpf + "'";
                falso = true;
            }
            else if (cboFiltro.Text == "Nome")
            {
                funcionario.Nome = txtConsultarFuncionario.Text;
                Query = "SELECT * FROM Funcionario WHERE nome = '" + funcionario.Nome + "'";
                falso = true;
            }
            else
            {
                Query = null;
                falso = false;
            }


            try
            {
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (falso == true && Query != null)
                {

                    dgListaFuncionario.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                erro += MessageBox.Show("Não foi possivel realizar a consulta!!! Verificar e inserir os dados novamente!");
            }
            finally
            {

            }
            

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string strConxao = @"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=true; Initial Catalog=DigitalCar";
            SqlConnection con = new SqlConnection(strConxao);
            string Query = "SELECT * FROM Funcionario";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgListaFuncionario.DataSource = dt;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgListaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
