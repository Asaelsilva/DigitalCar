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
    public partial class InativarFuncionario : Form
    {
        public InativarFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            string strConxao = @"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=true; Initial Catalog=DigitalCar";
            string Query;
            bool falso = false;

            //string total = "SELECT MAX(codigo_Funcionario) FROM Funcionario"


            if (this.txtBuscar.Text == String.Empty && cboFiltro.Text == String.Empty)
            {
                MessageBox.Show("Escolha o filtro desejado e insira uma informação no campo ao lado!");
                this.txtBuscar.Focus();
                return;
            }

            if (cboFiltro.Text == "Codigo" && this.txtBuscar.Text.Length >= 2)
            {
                MessageBox.Show("Funcionario nao enconrado");
                falso = false;
            }


            if (cboFiltro.Text == "Codigo" && txtBuscar.Text.Length < 2)
            {
                funcionario.Id = Convert.ToInt32(txtBuscar.Text);
                Query = "SELECT codigo_Funcionario, nome , status FROM Funcionario WHERE codigo_Funcionario = '" + funcionario.Id + "'";
                falso = true;
            }
            else if (cboFiltro.Text == "CPF" && txtBuscar.Text.Length == 11)
            {
                funcionario.Cpf = txtBuscar.Text;
                Query = "SELECT codigo_Funcionario, nome , status FROM Funcionario WHERE cpf = '" + funcionario.Cpf + "'";
                falso = true;
            }
            else if (cboFiltro.Text == "Nome")
            {
                funcionario.Nome = txtBuscar.Text;
                Query = "SELECT codigo_Funcionario, nome, status FROM Funcionario WHERE nome = '" + funcionario.Nome + "'";
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

                    dgResultado.DataSource = dt;
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

        private void dgResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBoxStatusFunc_Enter(object sender, EventArgs e)
        {

        }

        private void rbnAtivo_CheckedChanged(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = Convert.ToInt32(txtBuscar.Text);

            string Query = "SELECT status FROM Funcionatio WHERE codigo_Funcionario = '" + funcionario.Id + "'";

            if (Query == "1")
            {
                rbnAtivo.Checked = true;
            }
        }

        private void rbnInativo_CheckedChanged(object sender, EventArgs e)
        {
            //if (status == 2)
            //{
            //    rbnAtivo.Checked = false;
            //}
        }
    }
}
