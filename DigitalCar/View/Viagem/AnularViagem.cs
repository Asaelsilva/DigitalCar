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
    public partial class AnularViagem : Form
    {
        public AnularViagem()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnularViagem_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //void CompletaEndereco()
        //{ 
            
        //}


        //private void textBox1_Leave(object sender, EventArgs e)
        //{
        //    CompletaEndereco();
        //}
    }
}
