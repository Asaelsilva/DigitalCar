namespace DigitalCar.Veiculo
{
    partial class ConsultarVeiculo
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
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtCodigoPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBoxListaFuncionarios = new System.Windows.Forms.GroupBox();
            this.dgListaFuncionario = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxListaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(1102, 183);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(156, 37);
            this.btnConsultarFuncionario.TabIndex = 49;
            this.btnConsultarFuncionario.Text = "Consultar";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(681, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 32);
            this.label11.TabIndex = 63;
            this.label11.Text = "Consultar Veículo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.lblPlaca.Location = new System.Drawing.Point(647, 146);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(202, 21);
            this.lblPlaca.TabIndex = 61;
            this.lblPlaca.Text = "Insira o Código ou placa";
            // 
            // txtCodigoPlaca
            // 
            this.txtCodigoPlaca.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtCodigoPlaca.Location = new System.Drawing.Point(651, 190);
            this.txtCodigoPlaca.Name = "txtCodigoPlaca";
            this.txtCodigoPlaca.Size = new System.Drawing.Size(413, 27);
            this.txtCodigoPlaca.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(337, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 85;
            this.label3.Text = "Pesquisa por: ";
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Codigo",
            "Placa"});
            this.cboFiltro.Location = new System.Drawing.Point(464, 192);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(125, 24);
            this.cboFiltro.TabIndex = 47;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1102, 722);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(156, 37);
            this.btnVoltar.TabIndex = 51;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // groupBoxListaFuncionarios
            // 
            this.groupBoxListaFuncionarios.Controls.Add(this.dgListaFuncionario);
            this.groupBoxListaFuncionarios.Controls.Add(this.btnAlterar);
            this.groupBoxListaFuncionarios.Location = new System.Drawing.Point(33, 368);
            this.groupBoxListaFuncionarios.Name = "groupBoxListaFuncionarios";
            this.groupBoxListaFuncionarios.Size = new System.Drawing.Size(1263, 327);
            this.groupBoxListaFuncionarios.TabIndex = 92;
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
            this.dgListaFuncionario.Size = new System.Drawing.Size(1211, 186);
            this.dgListaFuncionario.TabIndex = 52;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(1069, 266);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(156, 37);
            this.btnAlterar.TabIndex = 50;
            this.btnAlterar.Text = "Veiculos";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::DigitalCar.Properties.Resources.WhatsApp_Image_2019_12_07_at_14_00_54;
            this.pictureBox1.Location = new System.Drawing.Point(33, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1421, 793);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBoxListaFuncionarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtCodigoPlaca);
            this.Name = "ConsultarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarVeiculo";
            this.groupBoxListaFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtCodigoPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBoxListaFuncionarios;
        private System.Windows.Forms.DataGridView dgListaFuncionario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}