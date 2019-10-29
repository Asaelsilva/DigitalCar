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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InserirFuncionario().Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarFuncionario().Show();
        }

        private void inativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InativarFuncionario().Show();
        }
    }
}
