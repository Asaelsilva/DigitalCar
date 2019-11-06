namespace DigitalCar.Viagem
{
    partial class RegistrarViagem
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
            this.btnRegistrarViagem = new System.Windows.Forms.Button();
            this.lblRegistrarViagem = new System.Windows.Forms.Label();
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
            this.btnVoltar.Location = new System.Drawing.Point(1072, 682);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 94;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRegistrarViagem
            // 
            this.btnRegistrarViagem.BackColor = System.Drawing.Color.Navy;
            this.btnRegistrarViagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarViagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarViagem.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarViagem.Location = new System.Drawing.Point(1255, 682);
            this.btnRegistrarViagem.Name = "btnRegistrarViagem";
            this.btnRegistrarViagem.Size = new System.Drawing.Size(114, 37);
            this.btnRegistrarViagem.TabIndex = 93;
            this.btnRegistrarViagem.Text = "Registrar";
            this.btnRegistrarViagem.UseVisualStyleBackColor = false;
            // 
            // lblRegistrarViagem
            // 
            this.lblRegistrarViagem.AutoSize = true;
            this.lblRegistrarViagem.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarViagem.Location = new System.Drawing.Point(593, 40);
            this.lblRegistrarViagem.Name = "lblRegistrarViagem";
            this.lblRegistrarViagem.Size = new System.Drawing.Size(214, 32);
            this.lblRegistrarViagem.TabIndex = 92;
            this.lblRegistrarViagem.Text = "Registrar Viagem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(29, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 326);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 770);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRegistrarViagem);
            this.Controls.Add(this.lblRegistrarViagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrarViagem";
            this.Text = "ViagemRegistrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRegistrarViagem;
        private System.Windows.Forms.Label lblRegistrarViagem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}