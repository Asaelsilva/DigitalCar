using DigitalCar.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCar.Viagem
{
    public partial class RegistrarViagem : Form
    {
        public RegistrarViagem()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarViagem_Click(object sender, EventArgs e)
        {
            Viagens viagem = new Viagens();
        }
    }
}
