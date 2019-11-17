﻿using System;
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
            funcionario.Cpf = txtCpf.Text;
            funcionario.Rg = txtRg.Text;
            funcionario.DataNascimento = Convert.ToDateTime(dtNascimento.Text);
            funcionario.Email = txtEmail.Text;

            if (cboTurno.Text == "Manhã")
            {
                funcionario.Turno = 1;
            }
            else if (cboTurno.Text == "Tarde")
            {
                funcionario.Turno = 2;
            }
            else
            {
                funcionario.Turno = 3;
            }



            if (cboFuncao.Text == "Admin")
            {
                funcionario.Funcao = 1;
            }
            else if (cboFuncao.Text == "Motorista")
            {
                funcionario.Funcao = 2;
            }
            if (cboFuncao.Text == "Estoquista")
            {
                funcionario.Funcao = 3;
            }



            if (cboStatus.Text == "Ativo")
            {
                funcionario.Status = 1;
            }
            else
            {
                funcionario.Status = 2;
            }


            funcionario.Telefone = txtTelefone.Text;
            funcionario.Celular = txtCelular.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.UF = cboUF.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Rua = txtRua.Text;
            funcionario.Numero = Convert.ToInt32(txtNumero.Text);
            funcionario.Bairro = txtBairro.Text;

            DBBaseEspecifica db = new DBBaseEspecifica();

            db.Inserir(funcionario.Nome, funcionario.Cpf, funcionario.Rg, funcionario.DataNascimento, funcionario.Email, funcionario.Turno,
                        funcionario.Funcao, funcionario.Status, funcionario.Telefone, funcionario.Celular, funcionario.Cep, funcionario.UF,
                        funcionario.Cidade, funcionario.Rua, funcionario.Numero, funcionario.Bairro);

            MessageBox.Show("Funcionario Incluido com Sucesso!");
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
