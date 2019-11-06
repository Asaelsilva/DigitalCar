using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCar.Veiculo
{
    public partial class ManutencaoSolicitar : Form
    {
        public ManutencaoSolicitar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManutencaoSolicitar_Load(object sender, EventArgs e)
        {

        }
    }
}
