namespace DigitalCar
{
    partial class InserirFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnIncluirFuncionario = new System.Windows.Forms.Button();
            this.tabPageEndereco = new System.Windows.Forms.TabPage();
            this.lbUf = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageDadosPessoais = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lbTurno = new System.Windows.Forms.Label();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lbFuncao = new System.Windows.Forms.Label();
            this.cboFuncao = new System.Windows.Forms.ComboBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tcInserirFuncionario = new System.Windows.Forms.TabControl();
            this.tabPageEndereco.SuspendLayout();
            this.tabPageDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcInserirFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1061, 746);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnIncluirFuncionario
            // 
            this.btnIncluirFuncionario.BackColor = System.Drawing.Color.Navy;
            this.btnIncluirFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluirFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnIncluirFuncionario.Location = new System.Drawing.Point(1244, 746);
            this.btnIncluirFuncionario.Name = "btnIncluirFuncionario";
            this.btnIncluirFuncionario.Size = new System.Drawing.Size(114, 37);
            this.btnIncluirFuncionario.TabIndex = 18;
            this.btnIncluirFuncionario.TabStop = false;
            this.btnIncluirFuncionario.Text = "Incluir";
            this.btnIncluirFuncionario.UseVisualStyleBackColor = false;
            this.btnIncluirFuncionario.Click += new System.EventHandler(this.btnIncluirFuncionario_Click);
            // 
            // tabPageEndereco
            // 
            this.tabPageEndereco.Controls.Add(this.lbUf);
            this.tabPageEndereco.Controls.Add(this.cboUF);
            this.tabPageEndereco.Controls.Add(this.lbCep);
            this.tabPageEndereco.Controls.Add(this.txtCep);
            this.tabPageEndereco.Controls.Add(this.txtCidade);
            this.tabPageEndereco.Controls.Add(this.txtBairro);
            this.tabPageEndereco.Controls.Add(this.txtNumero);
            this.tabPageEndereco.Controls.Add(this.txtRua);
            this.tabPageEndereco.Controls.Add(this.lbCidade);
            this.tabPageEndereco.Controls.Add(this.lbBairro);
            this.tabPageEndereco.Controls.Add(this.lbNumero);
            this.tabPageEndereco.Controls.Add(this.lbRua);
            this.tabPageEndereco.Controls.Add(this.label12);
            this.tabPageEndereco.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEndereco.Location = new System.Drawing.Point(4, 25);
            this.tabPageEndereco.Name = "tabPageEndereco";
            this.tabPageEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndereco.Size = new System.Drawing.Size(1383, 606);
            this.tabPageEndereco.TabIndex = 1;
            this.tabPageEndereco.Text = "Endereço";
            this.tabPageEndereco.UseVisualStyleBackColor = true;
            // 
            // lbUf
            // 
            this.lbUf.AutoSize = true;
            this.lbUf.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbUf.Location = new System.Drawing.Point(298, 139);
            this.lbUf.Name = "lbUf";
            this.lbUf.Size = new System.Drawing.Size(36, 21);
            this.lbUf.TabIndex = 74;
            this.lbUf.Text = "UF";
            // 
            // cboUF
            // 
            this.cboUF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUF.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "Manhã",
            "Tarde ",
            "Noite"});
            this.cboUF.Location = new System.Drawing.Point(302, 193);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(76, 27);
            this.cboUF.TabIndex = 13;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbCep.Location = new System.Drawing.Point(34, 139);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(41, 21);
            this.lbCep.TabIndex = 72;
            this.lbCep.Text = "Cep";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCep.Location = new System.Drawing.Point(38, 193);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(179, 27);
            this.txtCep.TabIndex = 12;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCidade.Location = new System.Drawing.Point(452, 188);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(496, 27);
            this.txtCidade.TabIndex = 14;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtBairro.Location = new System.Drawing.Point(782, 322);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(535, 27);
            this.txtBairro.TabIndex = 17;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtNumero.Location = new System.Drawing.Point(628, 322);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(94, 27);
            this.txtNumero.TabIndex = 16;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtRua.Location = new System.Drawing.Point(37, 322);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(516, 27);
            this.txtRua.TabIndex = 15;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbCidade.Location = new System.Drawing.Point(449, 139);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(66, 21);
            this.lbCidade.TabIndex = 70;
            this.lbCidade.Text = "Cidade";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbBairro.Location = new System.Drawing.Point(778, 268);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(59, 21);
            this.lbBairro.TabIndex = 68;
            this.lbBairro.Text = "Bairro";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbNumero.Location = new System.Drawing.Point(624, 268);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(31, 21);
            this.lbNumero.TabIndex = 66;
            this.lbNumero.Text = "N°";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbRua.Location = new System.Drawing.Point(33, 268);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(42, 21);
            this.lbRua.TabIndex = 64;
            this.lbRua.Text = "Rua";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 23);
            this.label12.TabIndex = 62;
            this.label12.Text = "Endereço";
            // 
            // tabPageDadosPessoais
            // 
            this.tabPageDadosPessoais.Controls.Add(this.label11);
            this.tabPageDadosPessoais.Controls.Add(this.pictureBox1);
            this.tabPageDadosPessoais.Controls.Add(this.dtNascimento);
            this.tabPageDadosPessoais.Controls.Add(this.lbStatus);
            this.tabPageDadosPessoais.Controls.Add(this.cboStatus);
            this.tabPageDadosPessoais.Controls.Add(this.lbTurno);
            this.tabPageDadosPessoais.Controls.Add(this.cboTurno);
            this.tabPageDadosPessoais.Controls.Add(this.lbFuncao);
            this.tabPageDadosPessoais.Controls.Add(this.cboFuncao);
            this.tabPageDadosPessoais.Controls.Add(this.lbEmail);
            this.tabPageDadosPessoais.Controls.Add(this.txtEmail);
            this.tabPageDadosPessoais.Controls.Add(this.txtCelular);
            this.tabPageDadosPessoais.Controls.Add(this.txtTelefone);
            this.tabPageDadosPessoais.Controls.Add(this.txtRg);
            this.tabPageDadosPessoais.Controls.Add(this.txtCpf);
            this.tabPageDadosPessoais.Controls.Add(this.txtNome);
            this.tabPageDadosPessoais.Controls.Add(this.lbCelular);
            this.tabPageDadosPessoais.Controls.Add(this.lbTelefone);
            this.tabPageDadosPessoais.Controls.Add(this.lbNascimento);
            this.tabPageDadosPessoais.Controls.Add(this.lbRg);
            this.tabPageDadosPessoais.Controls.Add(this.lbCpf);
            this.tabPageDadosPessoais.Controls.Add(this.lbNome);
            this.tabPageDadosPessoais.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDadosPessoais.Location = new System.Drawing.Point(4, 25);
            this.tabPageDadosPessoais.Name = "tabPageDadosPessoais";
            this.tabPageDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosPessoais.Size = new System.Drawing.Size(1383, 606);
            this.tabPageDadosPessoais.TabIndex = 0;
            this.tabPageDadosPessoais.Text = "Dados Pessoais ";
            this.tabPageDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(659, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 32);
            this.label11.TabIndex = 70;
            this.label11.Text = "Inserir Funcionario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(19, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(297, 335);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(236, 27);
            this.dtNascimento.TabIndex = 4;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbStatus.Location = new System.Drawing.Point(678, 426);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 21);
            this.lbStatus.TabIndex = 67;
            this.lbStatus.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(681, 475);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(180, 27);
            this.cboStatus.TabIndex = 8;
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbTurno.Location = new System.Drawing.Point(49, 426);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(56, 21);
            this.lbTurno.TabIndex = 65;
            this.lbTurno.Text = "Turno";
            // 
            // cboTurno
            // 
            this.cboTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTurno.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde ",
            "Noite"});
            this.cboTurno.Location = new System.Drawing.Point(52, 475);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(180, 27);
            this.cboTurno.TabIndex = 6;
            // 
            // lbFuncao
            // 
            this.lbFuncao.AutoSize = true;
            this.lbFuncao.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbFuncao.Location = new System.Drawing.Point(368, 426);
            this.lbFuncao.Name = "lbFuncao";
            this.lbFuncao.Size = new System.Drawing.Size(69, 21);
            this.lbFuncao.TabIndex = 63;
            this.lbFuncao.Text = "Função";
            // 
            // cboFuncao
            // 
            this.cboFuncao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFuncao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncao.FormattingEnabled = true;
            this.cboFuncao.Items.AddRange(new object[] {
            "Admin",
            "Motorista",
            "Estoquista"});
            this.cboFuncao.Location = new System.Drawing.Point(371, 475);
            this.cboFuncao.Name = "cboFuncao";
            this.cboFuncao.Size = new System.Drawing.Size(180, 27);
            this.cboFuncao.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbEmail.Location = new System.Drawing.Point(661, 287);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(62, 21);
            this.lbEmail.TabIndex = 61;
            this.lbEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtEmail.Location = new System.Drawing.Point(664, 335);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(668, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCelular.Location = new System.Drawing.Point(1097, 477);
            this.txtCelular.MaxLength = 15;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(235, 27);
            this.txtCelular.TabIndex = 10;
            this.txtCelular.Text = "55 11 ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtTelefone.Location = new System.Drawing.Point(1097, 419);
            this.txtTelefone.MaxLength = 14;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(235, 27);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.Text = "55 11 ";
            // 
            // txtRg
            // 
            this.txtRg.AccessibleDescription = "";
            this.txtRg.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtRg.Location = new System.Drawing.Point(1119, 199);
            this.txtRg.MaxLength = 9;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(213, 27);
            this.txtRg.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCpf.Location = new System.Drawing.Point(830, 199);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(213, 27);
            this.txtCpf.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(297, 199);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(453, 27);
            this.txtNome.TabIndex = 1;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbCelular.Location = new System.Drawing.Point(979, 483);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(68, 21);
            this.lbCelular.TabIndex = 59;
            this.lbCelular.Text = "Celular";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbTelefone.Location = new System.Drawing.Point(979, 426);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(72, 21);
            this.lbTelefone.TabIndex = 57;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbNascimento.Location = new System.Drawing.Point(294, 287);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(99, 21);
            this.lbNascimento.TabIndex = 55;
            this.lbNascimento.Text = "Nascimento";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbRg.Location = new System.Drawing.Point(1116, 160);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(32, 21);
            this.lbRg.TabIndex = 54;
            this.lbRg.Text = "Rg";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lbCpf.Location = new System.Drawing.Point(827, 160);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(47, 21);
            this.lbCpf.TabIndex = 52;
            this.lbCpf.Text = "CPF";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(294, 160);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(54, 21);
            this.lbNome.TabIndex = 50;
            this.lbNome.Text = "Nome";
            // 
            // tcInserirFuncionario
            // 
            this.tcInserirFuncionario.Controls.Add(this.tabPageDadosPessoais);
            this.tcInserirFuncionario.Controls.Add(this.tabPageEndereco);
            this.tcInserirFuncionario.Location = new System.Drawing.Point(44, 49);
            this.tcInserirFuncionario.Name = "tcInserirFuncionario";
            this.tcInserirFuncionario.SelectedIndex = 0;
            this.tcInserirFuncionario.Size = new System.Drawing.Size(1391, 635);
            this.tcInserirFuncionario.TabIndex = 11;
            // 
            // InserirFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1487, 1002);
            this.Controls.Add(this.tcInserirFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnIncluirFuncionario);
            this.Name = "InserirFuncionario";
            this.Text = "InserirFuncionario";
            this.tabPageEndereco.ResumeLayout(false);
            this.tabPageEndereco.PerformLayout();
            this.tabPageDadosPessoais.ResumeLayout(false);
            this.tabPageDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcInserirFuncionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnIncluirFuncionario;
        private System.Windows.Forms.TabPage tabPageEndereco;
        private System.Windows.Forms.Label lbUf;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageDadosPessoais;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Label lbFuncao;
        private System.Windows.Forms.ComboBox cboFuncao;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TabControl tcInserirFuncionario;
    }
}