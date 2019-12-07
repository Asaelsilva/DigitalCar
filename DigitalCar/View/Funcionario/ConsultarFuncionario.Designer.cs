namespace DigitalCar
{
    partial class ConsultarFuncionario
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
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultarFuncionario = new System.Windows.Forms.TextBox();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBoxListaFuncionarios = new System.Windows.Forms.GroupBox();
            this.dgListaFuncionario = new System.Windows.Forms.DataGridView();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxListaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(678, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 32);
            this.label11.TabIndex = 56;
            this.label11.Text = "Consultar Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(680, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Insira o Código do Funcionário, Nome ou CPF";
            // 
            // txtConsultarFuncionario
            // 
            this.txtConsultarFuncionario.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.txtConsultarFuncionario.Location = new System.Drawing.Point(680, 208);
            this.txtConsultarFuncionario.Name = "txtConsultarFuncionario";
            this.txtConsultarFuncionario.Size = new System.Drawing.Size(485, 27);
            this.txtConsultarFuncionario.TabIndex = 21;
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.BackColor = System.Drawing.Color.Navy;
            this.btnConsultarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(1197, 201);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(156, 37);
            this.btnConsultarFuncionario.TabIndex = 22;
            this.btnConsultarFuncionario.Text = "Consultar";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = false;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1197, 732);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(156, 37);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(1159, 268);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(156, 37);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Funcionarios";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // groupBoxListaFuncionarios
            // 
            this.groupBoxListaFuncionarios.Controls.Add(this.dgListaFuncionario);
            this.groupBoxListaFuncionarios.Controls.Add(this.btnAlterar);
            this.groupBoxListaFuncionarios.Location = new System.Drawing.Point(38, 379);
            this.groupBoxListaFuncionarios.Name = "groupBoxListaFuncionarios";
            this.groupBoxListaFuncionarios.Size = new System.Drawing.Size(1355, 327);
            this.groupBoxListaFuncionarios.TabIndex = 61;
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
            this.dgListaFuncionario.Size = new System.Drawing.Size(1301, 186);
            this.dgListaFuncionario.TabIndex = 25;
            this.dgListaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaFuncionario_CellContentClick);
            // 
            // cboFiltro
            // 
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "CPF"});
            this.cboFiltro.Location = new System.Drawing.Point(454, 208);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(187, 24);
            this.cboFiltro.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(309, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Pesquisa por: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::DigitalCar.Properties.Resources.WhatsApp_Image_2019_12_07_at_14_00_54;
            this.pictureBox1.Location = new System.Drawing.Point(38, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1487, 895);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBoxListaFuncionarios);
            this.Controls.Add(this.btnConsultarFuncionario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsultarFuncionario);
            this.Name = "ConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarFuncionario";
            this.groupBoxListaFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultarFuncionario;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox groupBoxListaFuncionarios;
        private System.Windows.Forms.DataGridView dgListaFuncionario;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Label label3;
    }
}