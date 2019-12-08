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

namespace DigitalCar.View
{
    public partial class FinalizaViagem : Form
    {
        public FinalizaViagem()
        {
            InitializeComponent();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            Viagens viagem = new Viagens();
        }
    }
}
