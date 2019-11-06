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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1080, 685);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 90;
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
            this.btnAprovarManutencao.Location = new System.Drawing.Point(1263, 685);
            this.btnAprovarManutencao.Name = "btnAprovarManutencao";
            this.btnAprovarManutencao.Size = new System.Drawing.Size(114, 37);
            this.btnAprovarManutencao.TabIndex = 89;
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
            this.pictureBox1.Location = new System.Drawing.Point(37, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // ManutencaAprovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 765);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAprovarManutencao);
            this.Controls.Add(this.lblonsultar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManutencaAprovar";
            this.Text = "ManutencaAprovar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAprovarManutencao;
        private System.Windows.Forms.Label lblonsultar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}