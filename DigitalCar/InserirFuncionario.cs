using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show("Funcionario Incluido com Sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
