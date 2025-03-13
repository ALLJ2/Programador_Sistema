namespace calculoTriangulo
{
    partial class Form2
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
            SuspendLayout();
            // 
            // txtLado4Retangulo
            // 
            txtLado4Retangulo.Location = new Point(508, 205);
            txtLado4Retangulo.Name = "txtLado4Retangulo";
            txtLado4Retangulo.Size = new Size(100, 23);
            txtLado4Retangulo.TabIndex = 12;
            txtLado4Retangulo.TextChanged += this.txtLado4Retangulo_TextChanged;
            // 
            // txtLado3Retangulo
            // 
            txtLado3Retangulo.Location = new Point(402, 205);
            txtLado3Retangulo.Name = "txtLado3Retangulo";
            txtLado3Retangulo.Size = new Size(100, 23);
            txtLado3Retangulo.TabIndex = 13;
            txtLado3Retangulo.TextChanged += this.txtLado3Retangulo_TextChanged;
            // 
            // txtLado2Retangulo
            // 
            txtLado2Retangulo.Location = new Point(278, 205);
            txtLado2Retangulo.Name = "txtLado2Retangulo";
            txtLado2Retangulo.Size = new Size(100, 23);
            txtLado2Retangulo.TabIndex = 14;
            txtLado2Retangulo.TextChanged += this.txtLado2Retangulo_TextChanged;
            // 
            // txtLado1Retangulo
            // 
            txtLado1Retangulo.Location = new Point(172, 205);
            txtLado1Retangulo.Name = "txtLado1Retangulo";
            txtLado1Retangulo.Size = new Size(100, 23);
            txtLado1Retangulo.TabIndex = 15;
            txtLado1Retangulo.TextChanged += this.txtLado1Retangulo_TextChanged;
            // 
            // lblPerimetroRetangulo
            // 
            lblPerimetroRetangulo.AutoSize = true;
            lblPerimetroRetangulo.Location = new Point(45, 209);
            lblPerimetroRetangulo.Name = "lblPerimetroRetangulo";
            lblPerimetroRetangulo.Size = new Size(116, 15);
            lblPerimetroRetangulo.TabIndex = 11;
            lblPerimetroRetangulo.Text = "perímetro Retãngulo";
            lblPerimetroRetangulo.Click += this.lblPerimetroRetangulo_Click;
            // 
            // btnCalcularPerimetro
            // 
            btnCalcularPerimetro.Location = new Point(614, 204);
            btnCalcularPerimetro.Name = "btnCalcularPerimetro";
            btnCalcularPerimetro.Size = new Size(141, 23);
            btnCalcularPerimetro.TabIndex = 10;
            btnCalcularPerimetro.Text = "Calcular perímetro";
            btnCalcularPerimetro.UseVisualStyleBackColor = true;
            btnCalcularPerimetro.Click += this.btnCalcularPerimetro_Click;
            // 
            // lblResultadoPerimetroRet
            // 
            lblResultadoPerimetroRet.AutoSize = true;
            lblResultadoPerimetroRet.Location = new Point(51, 231);
            lblResultadoPerimetroRet.Name = "lblResultadoPerimetroRet";
            lblResultadoPerimetroRet.Size = new Size(13, 15);
            lblResultadoPerimetroRet.TabIndex = 9;
            lblResultadoPerimetroRet.Text = "  ";
            lblResultadoPerimetroRet.Click += lblResultadoPerimetroRet_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLado4Retangulo);
            Controls.Add(txtLado3Retangulo);
            Controls.Add(txtLado2Retangulo);
            Controls.Add(txtLado1Retangulo);
            Controls.Add(lblPerimetroRetangulo);
            Controls.Add(btnCalcularPerimetro);
            Controls.Add(lblResultadoPerimetroRet);
            Name = "Form2";
            Text = "Form2";
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
    }
}