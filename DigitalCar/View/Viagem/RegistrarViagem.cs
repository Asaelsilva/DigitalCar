using bdDllEspecifica;
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

            viagem.RuaPartida = txtRuaPartida.Text;
            viagem.NunPartida = Convert.ToInt32(txtNumPartida.Text);
            viagem.BairroPartida = txtBairroPartida.Text;
            viagem.CidadePartida = txtCidadePartida.Text;
            viagem.UfPartida = cboUfPartida.Text;
            viagem.CepPartida = txtCepPartida.Text;


            viagem.RuaDestino = txtRuaDestino.Text;
            viagem.NunDestino = Convert.ToInt32(txtNumDestino.Text);
            viagem.BairroDestino = txtBairroDestino.Text;
            viagem.CidadeDestino = txtCidadeDestino.Text;
            viagem.UfDestino = cboUfDestino.Text;
            viagem.CepDestino = txtCepDestino.Text;

            viagem.Km = txtKM.Text;
            viagem.Combustivel = txtCombustivel.Text;
            viagem.Estacionamento = txtEstacionamento.Text;

            DBBaseEspecifica bd = new DBBaseEspecifica();

            bd.RegistrarViagem(viagem.RuaPartida, viagem.NunPartida, viagem.BairroPartida, viagem.CidadePartida, viagem.UfPartida, viagem.CepPartida,
                               viagem.RuaDestino, viagem.NunDestino, viagem.BairroDestino, viagem.CidadeDestino, viagem.UfDestino, viagem.CepDestino,
                               viagem.Km, viagem.Combustivel, viagem.Estacionamento);

            MessageBox.Show("Viagem inserida com sucesso!");
            this.Close();
        }
    }
}
