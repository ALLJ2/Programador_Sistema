namespace FormsLogin
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
            labelUsuario = new Label();
            CaixaTextUsuario = new TextBox();
            labelSenha = new Label();
            textBoxSenha = new TextBox();
            buttonAutentificar = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(23, 14);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(47, 15);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario";
            labelUsuario.Click += label1_Click;
            // 
            // CaixaTextUsuario
            // 
            CaixaTextUsuario.Location = new Point(76, 6);
            CaixaTextUsuario.Name = "CaixaTextUsuario";
            CaixaTextUsuario.Size = new Size(100, 23);
            CaixaTextUsuario.TabIndex = 1;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(23, 41);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha";
            labelSenha.Click += labelSenha_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(76, 33);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(100, 23);
            textBoxSenha.TabIndex = 3;
            // 
            // buttonAutentificar
            // 
            buttonAutentificar.Location = new Point(193, 4);
            buttonAutentificar.Name = "buttonAutentificar";
            buttonAutentificar.Size = new Size(75, 25);
            buttonAutentificar.TabIndex = 4;
            buttonAutentificar.Text = "Autentificar";
            buttonAutentificar.UseVisualStyleBackColor = true;
            buttonAutentificar.Click += buttonAutentificar_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(23, 67);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(10, 15);
            labelResultado.TabIndex = 5;
            labelResultado.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo_SENAC;
            ClientSize = new Size(1095, 786);
            Controls.Add(labelResultado);
            Controls.Add(buttonAutentificar);
            Controls.Add(textBoxSenha);
            Controls.Add(labelSenha);
            Controls.Add(CaixaTextUsuario);
            Controls.Add(labelUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private TextBox CaixaTextUsuario;
        private Label labelSenha;
        private TextBox textBoxSenha;
        private Button buttonAutentificar;
        private Label labelResultado;
    }
}
