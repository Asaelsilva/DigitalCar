namespace DigitalCar.Viagem
{
    partial class ConsultarAlterarViagem
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
            this.btnAlterarViagem = new System.Windows.Forms.Button();
            this.lblonsultar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.groupBoxListaFuncionarios = new System.Windows.Forms.GroupBox();
            this.dgListaFuncionario = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultarFuncionario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxListaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1073, 787);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 98;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterarViagem
            // 
            this.btnAlterarViagem.BackColor = System.Drawing.Color.Navy;
            this.btnAlterarViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarViagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarViagem.ForeColor = System.Drawing.Color.White;
            this.btnAlterarViagem.Location = new System.Drawing.Point(1237, 787);
            this.btnAlterarViagem.Name = "btnAlterarViagem";
            this.btnAlterarViagem.Size = new System.Drawing.Size(114, 37);
            this.btnAlterarViagem.TabIndex = 97;
            this.btnAlterarViagem.Text = "Alterar";
            this.btnAlterarViagem.UseVisualStyleBackColor = false;
            // 
            // lblonsultar
            // 
            this.lblonsultar.AutoSize = true;
            this.lblonsultar.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblonsultar.Location = new System.Drawing.Point(612, 42);
            this.lblonsultar.Name = "lblonsultar";
            this.lblonsultar.Size = new System.Drawing.Size(312, 32);
            this.lblonsultar.TabIndex = 96;
            this.lblonsultar.Text = "Consultar/Alterar Viagem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::DigitalCar.Properties.Resources.WhatsApp_Image_2019_12_07_at_14_00_54;
            this.pictureBox1.Location = new System.Drawing.Point(36, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(318, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 105;
            this.label3.Text = "Pesquisa por: ";
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "CPF"});
            this.cboFiltro.Location = new System.Drawing.Point(463, 273);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(174, 24);
            this.cboFiltro.TabIndex = 99;
            // 
            // groupBoxListaFuncionarios
            // 
            this.groupBoxListaFuncionarios.Controls.Add(this.dgListaFuncionario);
            this.groupBoxListaFuncionarios.Controls.Add(this.btnAlterar);
            this.groupBoxListaFuncionarios.Location = new System.Drawing.Point(36, 405);
            this.groupBoxListaFuncionarios.Name = "groupBoxListaFuncionarios";
            this.groupBoxListaFuncionarios.Size = new System.Drawing.Size(1355, 327);
            this.groupBoxListaFuncionarios.TabIndex = 104;
            this.groupBoxListaFuncionarios.TabStop = false;
            this.groupBoxListaFuncionarios.Text = "Lista de Funcionarios";
            // 
            // dgListaFuncionario
            // 
            this.dgListaFuncionario.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFuncionario.Location = new System.Drawing.Point(14, 63);
            this.dgListaFuncionario.Name = "dgListaFuncionario";
            this.dgListaFuncionario.RowHeadersWidth = 51;
            this.dgListaFuncionario.RowTemplate.Height = 24;
            this.dgListaFuncionario.Size = new System.Drawing.Size(1301, 186);
            this.dgListaFuncionario.TabIndex = 25;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(1159, 268);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(156, 37);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Funcionarios";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(1195, 267);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(156, 37);
            this.btnConsultarFuncionario.TabIndex = 101;
            this.btnConsultarFuncionario.Text = "Consultar";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(689, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 103;
            this.label2.Text = "Insira o Código do Funcionário, Nome ou CPF";
            // 
            // txtConsultarFuncionario
            // 
            this.txtConsultarFuncionario.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtConsultarFuncionario.Location = new System.Drawing.Point(689, 273);
            this.txtConsultarFuncionario.Name = "txtConsultarFuncionario";
            this.txtConsultarFuncionario.Size = new System.Drawing.Size(449, 27);
            this.txtConsultarFuncionario.TabIndex = 100;
            // 
            // ConsultarAlterarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1542, 822);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.groupBoxListaFuncionarios);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsultarFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterarViagem);
            this.Controls.Add(this.lblonsultar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultarAlterarViagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarAlterarViagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxListaFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterarViagem;
        private System.Windows.Forms.Label lblonsultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.GroupBox groupBoxListaFuncionarios;
        private System.Windows.Forms.DataGridView dgListaFuncionario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultarFuncionario;
    }
}