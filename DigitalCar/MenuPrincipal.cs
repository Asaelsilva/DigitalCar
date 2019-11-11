using DigitalCar.Veiculo;
using DigitalCar.Veiculo.Manutencao;
using DigitalCar.Viagem;
using DigitalCar.View.Aviso;
using DigitalCar.View.Sistema;
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
        //====================== Metodos do Menu Funcionario ========================

        private void MenuInserirFuncionario_Click(object sender, EventArgs e)
        {
            InserirFuncionario inserirFuncionario = new InserirFuncionario();
            //inserirFuncionario.MdiParent = this;
            inserirFuncionario.Show();
        }

        private void MenuConsultarFuncionario_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario consultarFuncionario = new ConsultarFuncionario();
            consultarFuncionario.Show();
        }

        private void MenuAtivarInativarFuncionario_Click(object sender, EventArgs e)
        {
            InativarFuncionario inativarFuncionario = new InativarFuncionario();
            inativarFuncionario.Show();
        }


        //====================== Metodos do Menu Veiculo ========================

        private void MenuInserirVeiculo_Click(object sender, EventArgs e)
        {
            InserirVeiculo inserirVeiculo = new InserirVeiculo();
            inserirVeiculo.Show();
        }

        private void MenuConsultarVeiculo_Click(object sender, EventArgs e)
        {
            ConsultarVeiculo consultarVeiculo = new ConsultarVeiculo();
            consultarVeiculo.Show();
        }

        private void MenuSolicitarManutencaoVeiculo_Click(object sender, EventArgs e)
        {
            ManutencaoSolicitar manutencaoSolicitar = new ManutencaoSolicitar();
            manutencaoSolicitar.Show();
        }

        private void MenuConsultarManutencaoVeiculo_Click(object sender, EventArgs e)
        {
            ManutencaoConsultar manutencaoConsultar = new ManutencaoConsultar();
            manutencaoConsultar.Show();
        }

        private void MenuAprovarRejeitarManutencaoVeiculo_Click(object sender, EventArgs e)
        {
            ManutencaAprovar manutencaAprovar = new ManutencaAprovar();
            manutencaAprovar.Show();
        }


        //======================Metodos do Menu Viagem========================

        private void MenuRegistrarViagem_Click(object sender, EventArgs e)
        {
            RegistrarViagem registrarViagem = new RegistrarViagem();
            registrarViagem.Show();
        }
                
        private void MenuConsultarAlterarViagem_Click(object sender, EventArgs e)
        {
            ConsultarAlterarViagem consultarAlterarViagem = new ConsultarAlterarViagem();
            consultarAlterarViagem.Show();
        }

        private void MenuAnularViagem_Click(object sender, EventArgs e)
        {
            AnularViagem anularViagem = new AnularViagem();
            anularViagem.Show();
        }


        //====================== Metodos do Menu Aviso ========================
        private void MenuEnviarAviso_Click(object sender, EventArgs e)
        {
            EnviarAviso enviarAviso = new EnviarAviso();
            enviarAviso.Show();
        }

        private void MenuProgramarAviso_Click(object sender, EventArgs e)
        {
            ProgramarAviso programarAviso = new ProgramarAviso();
            programarAviso.Show();
        }

        private void MenuConsultarAviso_Click(object sender, EventArgs e)
        {
            ConsultarAviso consultarAviso = new ConsultarAviso();
            consultarAviso.Show();
        }


        //====================== Metodos do Menu Aviso ========================

        private void menuIserirNovaCategoria_Click(object sender, EventArgs e)
        {
            InserirNovaCategoria inserirNovaCategoria = new InserirNovaCategoria();
            inserirNovaCategoria.Show();
        }

        private void menuInserirNovaMarca_Click(object sender, EventArgs e)
        {
            InserirNovaMarca inserirNovaMarca = new InserirNovaMarca();
            inserirNovaMarca.Show();
        }

        private void menuInserirNovoModelo_Click(object sender, EventArgs e)
        {
            InserirNovoModelo inserirNovoModelo = new InserirNovoModelo();
            inserirNovoModelo.Show();
        }
    }
}
