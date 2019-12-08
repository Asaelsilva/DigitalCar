namespace DigitalCar.View
{
    partial class Motorista
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
            this.groupBoxListaFuncionarios = new System.Windows.Forms.GroupBox();
            this.dgListaFuncionario = new System.Windows.Forms.DataGridView();
            this.lblonsultar = new System.Windows.Forms.Label();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxListaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListaFuncionarios
            // 
            this.groupBoxListaFuncionarios.Controls.Add(this.dgListaFuncionario);
            this.groupBoxListaFuncionarios.Controls.Add(this.btnConsultarFuncionario);
            this.groupBoxListaFuncionarios.Location = new System.Drawing.Point(89, 392);
            this.groupBoxListaFuncionarios.Name = "groupBoxListaFuncionarios";
            this.groupBoxListaFuncionarios.Size = new System.Drawing.Size(1355, 236);
            this.groupBoxListaFuncionarios.TabIndex = 112;
            this.groupBoxListaFuncionarios.TabStop = false;
            this.groupBoxListaFuncionarios.Text = "Lista de Funcionarios";
            // 
            // dgListaFuncionario
            // 
            this.dgListaFuncionario.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFuncionario.Location = new System.Drawing.Point(14, 21);
            this.dgListaFuncionario.Name = "dgListaFuncionario";
            this.dgListaFuncionario.RowHeadersWidth = 51;
            this.dgListaFuncionario.RowTemplate.Height = 24;
            this.dgListaFuncionario.Size = new System.Drawing.Size(1301, 149);
            this.dgListaFuncionario.TabIndex = 25;
            // 
            // lblonsultar
            // 
            this.lblonsultar.AutoSize = true;
            this.lblonsultar.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblonsultar.Location = new System.Drawing.Point(681, 122);
            this.lblonsultar.Name = "lblonsultar";
            this.lblonsultar.Size = new System.Drawing.Size(188, 32);
            this.lblonsultar.TabIndex = 107;
            this.lblonsultar.Text = "Viagens do Dia";
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(1159, 193);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(156, 37);
            this.btnConsultarFuncionario.TabIndex = 110;
            this.btnConsultarFuncionario.Text = "Consultar";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1290, 723);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 37);
            this.btnVoltar.TabIndex = 113;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::DigitalCar.Properties.Resources.WhatsApp_Image_2019_12_07_at_14_00_54;
            this.pictureBox1.Location = new System.Drawing.Point(65, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // Motorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 795);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBoxListaFuncionarios);
            this.Controls.Add(this.lblonsultar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Motorista";
            this.Text = "Motorista";
            this.groupBoxListaFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxListaFuncionarios;
        private System.Windows.Forms.DataGridView dgListaFuncionario;
        private System.Windows.Forms.Label lblonsultar;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}