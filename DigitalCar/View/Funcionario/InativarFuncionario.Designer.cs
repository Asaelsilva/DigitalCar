namespace DigitalCar
{
    partial class InativarFuncionario
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
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAISalvarFunc = new System.Windows.Forms.Button();
            this.groupBoxResultadoPesquisa = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResultadoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResultado
            // 
            this.dgResultado.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Location = new System.Drawing.Point(22, 55);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersWidth = 51;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.Size = new System.Drawing.Size(677, 164);
            this.dgResultado.TabIndex = 65;
            this.dgResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResultado_CellContentClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(1132, 193);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(156, 37);
            this.btnPesquisar.TabIndex = 64;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(596, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 32);
            this.label11.TabIndex = 63;
            this.label11.Text = "Ativar/Inativar Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(689, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Insira o Código do Funcionário, Nome ou CPF";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(708, 200);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(355, 27);
            this.txtBuscar.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::DigitalCar.Properties.Resources.WhatsApp_Image_2019_12_07_at_14_00_54;
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(999, 685);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 72;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAISalvarFunc
            // 
            this.btnAISalvarFunc.BackColor = System.Drawing.Color.Navy;
            this.btnAISalvarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAISalvarFunc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAISalvarFunc.ForeColor = System.Drawing.Color.White;
            this.btnAISalvarFunc.Location = new System.Drawing.Point(1174, 685);
            this.btnAISalvarFunc.Name = "btnAISalvarFunc";
            this.btnAISalvarFunc.Size = new System.Drawing.Size(114, 37);
            this.btnAISalvarFunc.TabIndex = 71;
            this.btnAISalvarFunc.Text = "Salvar";
            this.btnAISalvarFunc.UseVisualStyleBackColor = false;
            this.btnAISalvarFunc.Click += new System.EventHandler(this.btnAISalvarFunc_Click);
            // 
            // groupBoxResultadoPesquisa
            // 
            this.groupBoxResultadoPesquisa.Controls.Add(this.dgResultado);
            this.groupBoxResultadoPesquisa.Location = new System.Drawing.Point(329, 295);
            this.groupBoxResultadoPesquisa.Name = "groupBoxResultadoPesquisa";
            this.groupBoxResultadoPesquisa.Size = new System.Drawing.Size(734, 286);
            this.groupBoxResultadoPesquisa.TabIndex = 73;
            this.groupBoxResultadoPesquisa.TabStop = false;
            this.groupBoxResultadoPesquisa.Text = "Resultado da Pesquisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(335, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "Pesquisa por: ";
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "CPF"});
            this.cboFiltro.Location = new System.Drawing.Point(480, 200);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(187, 24);
            this.cboFiltro.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(335, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 77;
            this.label1.Text = "Codigo: ";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(658, 691);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(187, 24);
            this.cboStatus.TabIndex = 76;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCodigo.Location = new System.Drawing.Point(418, 691);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(105, 27);
            this.txtCodigo.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(589, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 79;
            this.label4.Text = "Status:";
            // 
            // InativarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 766);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.groupBoxResultadoPesquisa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAISalvarFunc);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Name = "InativarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inativar Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResultadoPesquisa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAISalvarFunc;
        private System.Windows.Forms.GroupBox groupBoxResultadoPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
    }
}