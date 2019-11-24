namespace DigitalCar.Viagem
{
    partial class AnularViagem
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
            this.btnAnularViagem = new System.Windows.Forms.Button();
            this.lblAnularViagem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxResultadoPesquisa = new System.Windows.Forms.GroupBox();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.groupBoxStatusFunc = new System.Windows.Forms.GroupBox();
            this.rbnAtivo = new System.Windows.Forms.RadioButton();
            this.rbnInativo = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResultadoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.groupBoxStatusFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1090, 693);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 102;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAnularViagem
            // 
            this.btnAnularViagem.BackColor = System.Drawing.Color.Navy;
            this.btnAnularViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularViagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularViagem.ForeColor = System.Drawing.Color.White;
            this.btnAnularViagem.Location = new System.Drawing.Point(1273, 693);
            this.btnAnularViagem.Name = "btnAnularViagem";
            this.btnAnularViagem.Size = new System.Drawing.Size(114, 37);
            this.btnAnularViagem.TabIndex = 101;
            this.btnAnularViagem.Text = "Anular";
            this.btnAnularViagem.UseVisualStyleBackColor = false;
            // 
            // lblAnularViagem
            // 
            this.lblAnularViagem.AutoSize = true;
            this.lblAnularViagem.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnularViagem.Location = new System.Drawing.Point(611, 51);
            this.lblAnularViagem.Name = "lblAnularViagem";
            this.lblAnularViagem.Size = new System.Drawing.Size(188, 32);
            this.lblAnularViagem.TabIndex = 100;
            this.lblAnularViagem.Text = "Anular Viagem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(47, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxResultadoPesquisa
            // 
            this.groupBoxResultadoPesquisa.Controls.Add(this.dgResultado);
            this.groupBoxResultadoPesquisa.Controls.Add(this.groupBoxStatusFunc);
            this.groupBoxResultadoPesquisa.Location = new System.Drawing.Point(358, 248);
            this.groupBoxResultadoPesquisa.Name = "groupBoxResultadoPesquisa";
            this.groupBoxResultadoPesquisa.Size = new System.Drawing.Size(734, 396);
            this.groupBoxResultadoPesquisa.TabIndex = 108;
            this.groupBoxResultadoPesquisa.TabStop = false;
            this.groupBoxResultadoPesquisa.Text = "Resultado da Pesquisa";
            // 
            // dgResultado
            // 
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Location = new System.Drawing.Point(22, 55);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersWidth = 51;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.Size = new System.Drawing.Size(677, 155);
            this.dgResultado.TabIndex = 65;
            // 
            // groupBoxStatusFunc
            // 
            this.groupBoxStatusFunc.Controls.Add(this.rbnAtivo);
            this.groupBoxStatusFunc.Controls.Add(this.rbnInativo);
            this.groupBoxStatusFunc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatusFunc.Location = new System.Drawing.Point(22, 271);
            this.groupBoxStatusFunc.Name = "groupBoxStatusFunc";
            this.groupBoxStatusFunc.Size = new System.Drawing.Size(387, 100);
            this.groupBoxStatusFunc.TabIndex = 70;
            this.groupBoxStatusFunc.TabStop = false;
            this.groupBoxStatusFunc.Text = "Status ";
            // 
            // rbnAtivo
            // 
            this.rbnAtivo.AutoSize = true;
            this.rbnAtivo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAtivo.Location = new System.Drawing.Point(18, 38);
            this.rbnAtivo.Name = "rbnAtivo";
            this.rbnAtivo.Size = new System.Drawing.Size(67, 25);
            this.rbnAtivo.TabIndex = 67;
            this.rbnAtivo.TabStop = true;
            this.rbnAtivo.Text = "Ativo";
            this.rbnAtivo.UseVisualStyleBackColor = true;
            // 
            // rbnInativo
            // 
            this.rbnInativo.AutoSize = true;
            this.rbnInativo.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.rbnInativo.Location = new System.Drawing.Point(193, 38);
            this.rbnInativo.Name = "rbnInativo";
            this.rbnInativo.Size = new System.Drawing.Size(83, 25);
            this.rbnInativo.TabIndex = 68;
            this.rbnInativo.TabStop = true;
            this.rbnInativo.Text = "Inativar";
            this.rbnInativo.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(1161, 146);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(156, 37);
            this.btnPesquisar.TabIndex = 105;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(354, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 104;
            this.label2.Text = "Insira o Código do Funcionário, Nome ou CPF";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(358, 156);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(627, 27);
            this.txtBuscar.TabIndex = 103;
            // 
            // AnularViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1671, 776);
            this.Controls.Add(this.groupBoxResultadoPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAnularViagem);
            this.Controls.Add(this.lblAnularViagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnularViagem";
            this.Text = "AnularViagem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnularViagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResultadoPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.groupBoxStatusFunc.ResumeLayout(false);
            this.groupBoxStatusFunc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAnularViagem;
        private System.Windows.Forms.Label lblAnularViagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxResultadoPesquisa;
        private System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.GroupBox groupBoxStatusFunc;
        private System.Windows.Forms.RadioButton rbnAtivo;
        private System.Windows.Forms.RadioButton rbnInativo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}