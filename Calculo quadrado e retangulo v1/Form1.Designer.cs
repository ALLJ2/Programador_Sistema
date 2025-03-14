namespace calculoTriangulo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuadrado = new Label();
            txtLado1 = new TextBox();
            lblAreaQuadrado = new Label();
            txtLado2 = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            linkForms2 = new LinkLabel();
            SuspendLayout();
            // 
            // lblQuadrado
            // 
            lblQuadrado.AutoSize = true;
            lblQuadrado.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuadrado.ForeColor = SystemColors.Desktop;
            lblQuadrado.Location = new Point(355, 9);
            lblQuadrado.Name = "lblQuadrado";
            lblQuadrado.Size = new Size(144, 30);
            lblQuadrado.TabIndex = 0;
            lblQuadrado.Text = "quadrado";
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(163, 72);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(35, 23);
            txtLado1.TabIndex = 1;
            // 
            // lblAreaQuadrado
            // 
            lblAreaQuadrado.AutoSize = true;
            lblAreaQuadrado.Location = new Point(42, 75);
            lblAreaQuadrado.Name = "lblAreaQuadrado";
            lblAreaQuadrado.Size = new Size(102, 15);
            lblAreaQuadrado.TabIndex = 2;
            lblAreaQuadrado.Text = "Área do quadrado";
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(204, 72);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(35, 23);
            txtLado2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(245, 72);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(42, 104);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "  ";
            // 
            // linkForms2
            // 
            linkForms2.AutoSize = true;
            linkForms2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkForms2.Location = new Point(47, 195);
            linkForms2.Name = "linkForms2";
            linkForms2.Size = new Size(168, 30);
            linkForms2.TabIndex = 9;
            linkForms2.TabStop = true;
            linkForms2.Text = "Ir para retãngulo";
            linkForms2.LinkClicked += linkForms2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkForms2);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtLado2);
            Controls.Add(lblAreaQuadrado);
            Controls.Add(txtLado1);
            Controls.Add(lblQuadrado);
            ForeColor = Color.Crimson;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuadrado;
        private TextBox txtLado1;
        private Label lblAreaQuadrado;
        private TextBox txtLado2;
        private Button btnCalcular;
        private Label lblResultado;
        private LinkLabel linkForms2;
    }
}
