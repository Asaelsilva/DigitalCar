namespace DigitalCar.Veiculo
{
    partial class ManutencaoConsultar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblonsultar = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsultarManutencao = new System.Windows.Forms.Button();
            this.groupBoxManutencaoSolicitada = new System.Windows.Forms.GroupBox();
            this.dgListaFuncionario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultarFuncionario = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxManutencaoSolicitada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::DigitalCar.Properties.Resources.WhatsApp_Image_2019_12_07_at_14_00_54;
            this.pictureBox1.Location = new System.Drawing.Point(31, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // lblonsultar
            // 
            this.lblonsultar.AutoSize = true;
            this.lblonsultar.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblonsultar.Location = new System.Drawing.Point(601, 33);
            this.lblonsultar.Name = "lblonsultar";
            this.lblonsultar.Size = new System.Drawing.Size(281, 32);
            this.lblonsultar.TabIndex = 65;
            this.lblonsultar.Text = "Consultar Manutenção";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(871, 709);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 37);
            this.btnVoltar.TabIndex = 63;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConsultarManutencao
            // 
            this.btnConsultarManutencao.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarManutencao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarManutencao.ForeColor = System.Drawing.Color.White;
            this.btnConsultarManutencao.Location = new System.Drawing.Point(1071, 163);
            this.btnConsultarManutencao.Name = "btnConsultarManutencao";
            this.btnConsultarManutencao.Size = new System.Drawing.Size(135, 37);
            this.btnConsultarManutencao.TabIndex = 59;
            this.btnConsultarManutencao.Text = "Consutar";
            this.btnConsultarManutencao.UseVisualStyleBackColor = false;
            this.btnConsultarManutencao.Click += new System.EventHandler(this.btnConsultarManutencao_Click);
            // 
            // groupBoxManutencaoSolicitada
            // 
            this.groupBoxManutencaoSolicitada.Controls.Add(this.dgListaFuncionario);
            this.groupBoxManutencaoSolicitada.Controls.Add(this.btnAlterar);
            this.groupBoxManutencaoSolicitada.Location = new System.Drawing.Point(309, 240);
            this.groupBoxManutencaoSolicitada.Name = "groupBoxManutencaoSolicitada";
            this.groupBoxManutencaoSolicitada.Size = new System.Drawing.Size(928, 363);
            this.groupBoxManutencaoSolicitada.TabIndex = 96;
            this.groupBoxManutencaoSolicitada.TabStop = false;
            this.groupBoxManutencaoSolicitada.Text = "Manutenções Solicitadas";
            // 
            // dgListaFuncionario
            // 
            this.dgListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFuncionario.Location = new System.Drawing.Point(14, 46);
            this.dgListaFuncionario.Name = "dgListaFuncionario";
            this.dgListaFuncionario.RowHeadersWidth = 51;
            this.dgListaFuncionario.RowTemplate.Height = 24;
            this.dgListaFuncionario.Size = new System.Drawing.Size(883, 226);
            this.dgListaFuncionario.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(557, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "Insira o Código da manutenção ou Placa do veiculo";
            // 
            // txtConsultarFuncionario
            // 
            this.txtConsultarFuncionario.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtConsultarFuncionario.Location = new System.Drawing.Point(561, 167);
            this.txtConsultarFuncionario.Name = "txtConsultarFuncionario";
            this.txtConsultarFuncionario.Size = new System.Drawing.Size(461, 27);
            this.txtConsultarFuncionario.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(187, 712);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 61;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Preventiva",
            "Corretiva"});
            this.cboCategoria.Location = new System.Drawing.Point(491, 718);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(208, 24);
            this.cboCategoria.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(319, 718);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Tipo manutenção:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(100, 718);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "Codigo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1071, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 64;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(341, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 101;
            this.label4.Text = "Consultar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Codigo",
            "Placa"});
            this.comboBox1.Location = new System.Drawing.Point(336, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 57;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(762, 302);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(135, 37);
            this.btnAlterar.TabIndex = 60;
            this.btnAlterar.Text = "Manutenção";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // ManutencaoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 810);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxManutencaoSolicitada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsultarFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConsultarManutencao);
            this.Controls.Add(this.lblonsultar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManutencaoConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManutencaoConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxManutencaoSolicitada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblonsultar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConsultarManutencao;
        private System.Windows.Forms.GroupBox groupBoxManutencaoSolicitada;
        private System.Windows.Forms.DataGridView dgListaFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultarFuncionario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAlterar;
    }
}