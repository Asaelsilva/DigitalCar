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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // AnularViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 776);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAnularViagem);
            this.Controls.Add(this.lblAnularViagem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnularViagem";
            this.Text = "AnularViagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAnularViagem;
        private System.Windows.Forms.Label lblAnularViagem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}