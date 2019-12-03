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

namespace DigitalCar.Veiculo
{
    public partial class InserirVeiculo : Form
    {
        public InserirVeiculo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirVeiculo_Click(object sender, EventArgs e)
        {
            VeiculoInserir veiculo = new VeiculoInserir();

            veiculo.Categoria = cboCategoria.Text;
            veiculo.Marca = cboMarca.Text;
            veiculo.Modelo = cboModelo.Text;
            veiculo.Placa = txtPlaca.Text;
            veiculo.AnoModelo = int.Parse(cboAnoModelo.Text);
            veiculo.AnoFabricacao = int.Parse(cboAnoFabricacao.Text);
            veiculo.Renavam = txtRenavam.Text;
            veiculo.Cor = cboCor.Text;
            veiculo.Km = int.Parse(txtKM.Text);
            veiculo.Propriedade = cboPropriedade.Text;
            veiculo.Status = cboStatus.Text;

            DBBaseEspecifica bd = new DBBaseEspecifica();

            bd.InserirVeiculos(veiculo.Categoria, veiculo.Marca, veiculo.Modelo, veiculo.Placa, veiculo.AnoModelo
                             , veiculo.AnoFabricacao, veiculo.Propriedade, veiculo.Status, veiculo.Cor, veiculo.Renavam,  veiculo.Km);

            MessageBox.Show("Veiculo Incluido com Sucesso!");
            this.Close();

        }
   
    }

}
