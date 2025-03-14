namespace calculoTriangulo
{
    partial class Form3
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
            txtLado4Retangulo = new TextBox();
            txtLado3Retangulo = new TextBox();
            txtLado2Retangulo = new TextBox();
            txtLado1Retangulo = new TextBox();
            lblPerimetroRetangulo = new Label();
            btnCalcularPerimetro = new Button();
            lblResultadoPerimetroRet = new Label();
            linkVoltar = new LinkLabel();
            lblRetangulo = new Label();
            SuspendLayout();
            // 
            // txtLado4Retangulo
            // 
            txtLado4Retangulo.Location = new Point(287, 96);
            txtLado4Retangulo.Name = "txtLado4Retangulo";
            txtLado4Retangulo.Size = new Size(45, 23);
            txtLado4Retangulo.TabIndex = 12;
            // 
            // txtLado3Retangulo
            // 
            txtLado3Retangulo.Location = new Point(236, 97);
            txtLado3Retangulo.Name = "txtLado3Retangulo";
            txtLado3Retangulo.Size = new Size(45, 23);
            txtLado3Retangulo.TabIndex = 13;
            // 
            // txtLado2Retangulo
            // 
            txtLado2Retangulo.Location = new Point(185, 95);
            txtLado2Retangulo.Name = "txtLado2Retangulo";
            txtLado2Retangulo.Size = new Size(45, 23);
            txtLado2Retangulo.TabIndex = 14;
            // 
            // txtLado1Retangulo
            // 
            txtLado1Retangulo.Location = new Point(134, 95);
            txtLado1Retangulo.Name = "txtLado1Retangulo";
            txtLado1Retangulo.Size = new Size(45, 23);
            txtLado1Retangulo.TabIndex = 15;
            // 
            // lblPerimetroRetangulo
            // 
            lblPerimetroRetangulo.AutoSize = true;
            lblPerimetroRetangulo.ForeColor = Color.Crimson;
            lblPerimetroRetangulo.Location = new Point(16, 99);
            lblPerimetroRetangulo.Name = "lblPerimetroRetangulo";
            lblPerimetroRetangulo.Size = new Size(116, 15);
            lblPerimetroRetangulo.TabIndex = 11;
            lblPerimetroRetangulo.Text = "perímetro Retãngulo";
            // 
            // btnCalcularPerimetro
            // 
            btnCalcularPerimetro.ForeColor = Color.Crimson;
            btnCalcularPerimetro.Location = new Point(338, 96);
            btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            btnCalcularPerimetro.Size = new Size(141, 23);
            btnCalcularPerimetro.TabIndex = 10;
            btnCalcularPerimetro.Text = "Calcular perímetro";
            btnCalcularPerimetro.UseVisualStyleBackColor = true;
            btnCalcularPerimetro.Click += btnCalcularPerimetro_Click;
            // 
            // lblResultadoPerimetroRet
            // 
            lblResultadoPerimetroRet.AutoSize = true;
            lblResultadoPerimetroRet.Location = new Point(22, 121);
            lblResultadoPerimetroRet.Name = "lblResultadoPerimetroRet";
            lblResultadoPerimetroRet.Size = new Size(13, 15);
            lblResultadoPerimetroRet.TabIndex = 9;
            lblResultadoPerimetroRet.Text = "  ";
            // 
            // linkVoltar
            // 
            linkVoltar.AutoSize = true;
            linkVoltar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkVoltar.Location = new Point(31, 164);
            linkVoltar.Name = "linkVoltar";
            linkVoltar.Size = new Size(227, 30);
            linkVoltar.TabIndex = 16;
            linkVoltar.TabStop = true;
            linkVoltar.Text = "Voltar para o quadrado";
            linkVoltar.LinkClicked += linkVoltar_LinkClicked;
            // 
            // lblRetangulo
            // 
            lblRetangulo.AutoSize = true;
            lblRetangulo.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRetangulo.Location = new Point(338, 9);
            lblRetangulo.Name = "lblRetangulo";
            lblRetangulo.Size = new Size(151, 30);
            lblRetangulo.TabIndex = 17;
            lblRetangulo.Text = "Retangulo";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRetangulo);
            Controls.Add(linkVoltar);
            Controls.Add(txtLado4Retangulo);
            Controls.Add(txtLado3Retangulo);
            Controls.Add(txtLado2Retangulo);
            Controls.Add(txtLado1Retangulo);
            Controls.Add(lblPerimetroRetangulo);
            Controls.Add(btnCalcularPerimetro);
            Controls.Add(lblResultadoPerimetroRet);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLado4Retangulo;
        private TextBox txtLado3Retangulo;
        private TextBox txtLado2Retangulo;
        private TextBox txtLado1Retangulo;
        private Label lblPerimetroRetangulo;
        private Button btnCalcularPerimetro;
        private Label lblResultadoPerimetroRet;
        private LinkLabel linkVoltar;
        private Label lblRetangulo;
    }
}