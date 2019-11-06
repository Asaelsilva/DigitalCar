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

            DBBaseEspecifica db = new DBBaseEspecifica();

            db.Inserir(funcionario.Nome);

            MessageBox.Show("Funcionario Incluido com Sucesso!");
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
