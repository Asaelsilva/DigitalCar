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
            this.rbnAtivo = new System.Windows.Forms.RadioButton();
            this.rbnInativo = new System.Windows.Forms.RadioButton();
            this.groupBoxStatusFunc = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAISalvarFunc = new System.Windows.Forms.Button();
            this.groupBoxResultadoPesquisa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxStatusFunc.SuspendLayout();
            this.groupBoxResultadoPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResultado
            // 
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Location = new System.Drawing.Point(22, 55);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersWidth = 51;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.Size = new System.Drawing.Size(677, 98);
            this.dgResultado.TabIndex = 65;
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
            this.label2.Location = new System.Drawing.Point(325, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Insira o Código do Funcionário, Nome ou CPF";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(329, 203);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(627, 27);
            this.txtBuscar.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
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
            // groupBoxStatusFunc
            // 
            this.groupBoxStatusFunc.Controls.Add(this.rbnAtivo);
            this.groupBoxStatusFunc.Controls.Add(this.rbnInativo);
            this.groupBoxStatusFunc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatusFunc.Location = new System.Drawing.Point(22, 192);
            this.groupBoxStatusFunc.Name = "groupBoxStatusFunc";
            this.groupBoxStatusFunc.Size = new System.Drawing.Size(387, 100);
            this.groupBoxStatusFunc.TabIndex = 70;
            this.groupBoxStatusFunc.TabStop = false;
            this.groupBoxStatusFunc.Text = "Status ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(949, 685);
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
            // 
            // groupBoxResultadoPesquisa
            // 
            this.groupBoxResultadoPesquisa.Controls.Add(this.dgResultado);
            this.groupBoxResultadoPesquisa.Controls.Add(this.groupBoxStatusFunc);
            this.groupBoxResultadoPesquisa.Location = new System.Drawing.Point(329, 295);
            this.groupBoxResultadoPesquisa.Name = "groupBoxResultadoPesquisa";
            this.groupBoxResultadoPesquisa.Size = new System.Drawing.Size(734, 328);
            this.groupBoxResultadoPesquisa.TabIndex = 73;
            this.groupBoxResultadoPesquisa.TabStop = false;
            this.groupBoxResultadoPesquisa.Text = "Resultado da Pesquisa";
            // 
            // InativarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 758);
            this.Controls.Add(this.groupBoxResultadoPesquisa);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAISalvarFunc);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Name = "InativarFuncionario";
            this.Text = "Inativar Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxStatusFunc.ResumeLayout(false);
            this.groupBoxStatusFunc.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbnAtivo;
        private System.Windows.Forms.RadioButton rbnInativo;
        private System.Windows.Forms.GroupBox groupBoxStatusFunc;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAISalvarFunc;
        private System.Windows.Forms.GroupBox groupBoxResultadoPesquisa;
    }
}