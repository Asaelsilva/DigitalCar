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
using bdDllEspecifica;
//using DbDllGenerico;
using DigitalCar.Entities;

namespace DigitalCar
{
    public partial class InserirFuncionario : Form
    {
        public InserirFuncionario()
        {
            InitializeComponent();
        }

        private void btnIncluirFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Rg = txtRg.Text;
            funcionario.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
            funcionario.Email = txtEmail.Text;
            funcionario.Turno = cboTurno.Text;
            funcionario.Funcao = cboFuncao.Text;
            funcionario.Status = cboStatus.Text;
            funcionario.Telefone = Convert.ToDecimal(txtTelefone.Text);
            funcionario.Celular = Convert.ToDecimal(txtCelular.Text);
            funcionario.Cep = Convert.ToInt32(txtCep.Text);
            funcionario.UF = cboUF.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Rua = txtRua.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Bairro = txtBairro.Text;

            DBBaseEspecifica db = new DBBaseEspecifica();

            db.Inserir(funcionario.Nome, funcionario.Cpf, funcionario.Rg, funcionario.DataNascimento, funcionario.Email, funcionario.Turno, 
                        funcionario.Funcao, funcionario.Status, funcionario.Telefone, funcionario.Celular, funcionario.Cep, funcionario.UF,
                        funcionario.Cidade, funcionario.Rua, funcionario.Numero, funcionario.Bairro);

            MessageBox.Show("Funcionario Incluido com Sucesso!");
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
