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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultarFuncionario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxManutencaoSolicitada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(37, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
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
            this.btnVoltar.Location = new System.Drawing.Point(1121, 690);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 86;
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
            this.btnConsultarManutencao.Location = new System.Drawing.Point(1304, 690);
            this.btnConsultarManutencao.Name = "btnConsultarManutencao";
            this.btnConsultarManutencao.Size = new System.Drawing.Size(114, 37);
            this.btnConsultarManutencao.TabIndex = 85;
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
            this.groupBoxManutencaoSolicitada.Size = new System.Drawing.Size(761, 552);
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
            this.dgListaFuncionario.Size = new System.Drawing.Size(663, 426);
            this.dgListaFuncionario.TabIndex = 59;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(521, 491);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(156, 37);
            this.btnAlterar.TabIndex = 60;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(305, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "Insira o Código da manutenção ou Placa do veiculo";
            // 
            // txtConsultarFuncionario
            // 
            this.txtConsultarFuncionario.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtConsultarFuncionario.Location = new System.Drawing.Point(309, 163);
            this.txtConsultarFuncionario.Name = "txtConsultarFuncionario";
            this.txtConsultarFuncionario.Size = new System.Drawing.Size(677, 27);
            this.txtConsultarFuncionario.TabIndex = 94;
            // 
            // ManutencaoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 810);
            this.Controls.Add(this.groupBoxManutencaoSolicitada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsultarFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConsultarManutencao);
            this.Controls.Add(this.lblonsultar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManutencaoConsultar";
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
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultarFuncionario;
    }
}