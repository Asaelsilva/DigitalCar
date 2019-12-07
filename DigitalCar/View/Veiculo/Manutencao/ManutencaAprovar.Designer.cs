namespace DigitalCar.Veiculo.Manutencao
{
    partial class ManutencaAprovar
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
            this.btnAprovarManutencao = new System.Windows.Forms.Button();
            this.lblonsultar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxResultadoPesquisa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResultadoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(911, 700);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 56;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAprovarManutencao
            // 
            this.btnAprovarManutencao.BackColor = System.Drawing.Color.Navy;
            this.btnAprovarManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAprovarManutencao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovarManutencao.ForeColor = System.Drawing.Color.White;
            this.btnAprovarManutencao.Location = new System.Drawing.Point(1085, 700);
            this.btnAprovarManutencao.Name = "btnAprovarManutencao";
            this.btnAprovarManutencao.Size = new System.Drawing.Size(114, 37);
            this.btnAprovarManutencao.TabIndex = 55;
            this.btnAprovarManutencao.Text = "Salvar";
            this.btnAprovarManutencao.UseVisualStyleBackColor = false;
            // 
            // lblonsultar
            // 
            this.lblonsultar.AutoSize = true;
            this.lblonsultar.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblonsultar.Location = new System.Drawing.Point(601, 43);
            this.lblonsultar.Name = "lblonsultar";
            this.lblonsultar.Size = new System.Drawing.Size(375, 32);
            this.lblonsultar.TabIndex = 88;
            this.lblonsultar.Text = "Aprovar / Rejeitar Manutenção";
            this.lblonsultar.Click += new System.EventHandler(this.lblonsultar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::DigitalCar.Properties.Resources.WhatsApp_Image_2019_12_07_at_14_00_54;
            this.pictureBox1.Location = new System.Drawing.Point(37, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxResultadoPesquisa
            // 
            this.groupBoxResultadoPesquisa.Controls.Add(this.label1);
            this.groupBoxResultadoPesquisa.Controls.Add(this.comboBox1);
            this.groupBoxResultadoPesquisa.Controls.Add(this.dgResultado);
            this.groupBoxResultadoPesquisa.Location = new System.Drawing.Point(345, 287);
            this.groupBoxResultadoPesquisa.Name = "groupBoxResultadoPesquisa";
            this.groupBoxResultadoPesquisa.Size = new System.Drawing.Size(854, 363);
            this.groupBoxResultadoPesquisa.TabIndex = 93;
            this.groupBoxResultadoPesquisa.TabStop = false;
            this.groupBoxResultadoPesquisa.Text = "Manutenção Solicitada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(30, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "Manutenção:  ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Preventiva",
            "Corretiva"});
            this.comboBox1.Location = new System.Drawing.Point(184, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.TabIndex = 54;
            // 
            // dgResultado
            // 
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Location = new System.Drawing.Point(22, 73);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.RowHeadersWidth = 51;
            this.dgResultado.RowTemplate.Height = 24;
            this.dgResultado.Size = new System.Drawing.Size(757, 150);
            this.dgResultado.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(341, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 92;
            this.label2.Text = "Insira o Código do Funcionário, Nome ou CPF";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(345, 206);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(566, 27);
            this.txtBuscar.TabIndex = 53;
            // 
            // ManutencaAprovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 776);
            this.Controls.Add(this.groupBoxResultadoPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAprovarManutencao);
            this.Controls.Add(this.lblonsultar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManutencaAprovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManutencaAprovar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResultadoPesquisa.ResumeLayout(false);
            this.groupBoxResultadoPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAprovarManutencao;
        private System.Windows.Forms.Label lblonsultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxResultadoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}