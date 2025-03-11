namespace Calculadora
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
            lblVoltar = new Label();
            SuspendLayout();
            // 
            // lblVoltar
            // 
            lblVoltar.AutoSize = true;
            lblVoltar.ForeColor = Color.Crimson;
            lblVoltar.Location = new Point(29, 40);
            lblVoltar.Name = "lblVoltar";
            lblVoltar.Size = new Size(37, 15);
            lblVoltar.TabIndex = 0;
            lblVoltar.Text = "Voltar";
            lblVoltar.Click += lblVoltar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVoltar);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVoltar;
    }
}