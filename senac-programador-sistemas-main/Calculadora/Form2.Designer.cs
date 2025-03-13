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
            SelectAdd = new RadioButton();
            SelectSub = new RadioButton();
            SelectMulti = new RadioButton();
            SelectDiv = new RadioButton();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            textBox3 = new TextBox();
            lblResulta = new Label();
            lblCalculo = new Label();
            SuspendLayout();
            // 
            // lblVoltar
            // 
            lblVoltar.AutoSize = true;
            lblVoltar.ForeColor = Color.Crimson;
            lblVoltar.Location = new Point(56, 68);
            lblVoltar.Name = "lblVoltar";
            lblVoltar.Size = new Size(37, 15);
            lblVoltar.TabIndex = 0;
            lblVoltar.Text = "Voltar";
            lblVoltar.Click += lblVoltar_Click;
            // 
            // SelectAdd
            // 
            SelectAdd.AutoSize = true;
            SelectAdd.Location = new Point(56, 109);
            SelectAdd.Name = "SelectAdd";
            SelectAdd.Size = new Size(62, 19);
            SelectAdd.TabIndex = 1;
            SelectAdd.TabStop = true;
            SelectAdd.Text = "Adição";
            SelectAdd.UseVisualStyleBackColor = true;
            SelectAdd.CheckedChanged += SelectAdd_CheckedChanged;
            // 
            // SelectSub
            // 
            SelectSub.AutoSize = true;
            SelectSub.Location = new Point(124, 109);
            SelectSub.Name = "SelectSub";
            SelectSub.Size = new Size(78, 19);
            SelectSub.TabIndex = 1;
            SelectSub.TabStop = true;
            SelectSub.Text = "Subtração";
            SelectSub.UseVisualStyleBackColor = true;
            SelectSub.CheckedChanged += SelectSub_CheckedChanged;
            // 
            // SelectMulti
            // 
            SelectMulti.AutoSize = true;
            SelectMulti.Location = new Point(208, 109);
            SelectMulti.Name = "SelectMulti";
            SelectMulti.Size = new Size(97, 19);
            SelectMulti.TabIndex = 1;
            SelectMulti.TabStop = true;
            SelectMulti.Text = "Multiplicação";
            SelectMulti.UseVisualStyleBackColor = true;
            SelectMulti.CheckedChanged += SelectMulti_CheckedChanged;
            // 
            // SelectDiv
            // 
            SelectDiv.AutoSize = true;
            SelectDiv.Location = new Point(311, 109);
            SelectDiv.Name = "SelectDiv";
            SelectDiv.Size = new Size(63, 19);
            SelectDiv.TabIndex = 1;
            SelectDiv.TabStop = true;
            SelectDiv.Text = "Divisão";
            SelectDiv.UseVisualStyleBackColor = true;
            SelectDiv.CheckedChanged += SelectDiv_CheckedChanged;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(128, 60);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(43, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(194, 60);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(43, 23);
            txtNum2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Cornsilk;
            textBox3.Enabled = false;
            textBox3.Location = new Point(262, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 23);
            textBox3.TabIndex = 2;
            // 
            // lblResulta
            // 
            lblResulta.AutoSize = true;
            lblResulta.Location = new Point(241, 68);
            lblResulta.Name = "lblResulta";
            lblResulta.Size = new Size(15, 15);
            lblResulta.TabIndex = 3;
            lblResulta.Text = "=";
            // 
            // lblCalculo
            // 
            lblCalculo.AutoSize = true;
            lblCalculo.Location = new Point(173, 68);
            lblCalculo.Name = "lblCalculo";
            lblCalculo.Size = new Size(15, 15);
            lblCalculo.TabIndex = 3;
            lblCalculo.Text = "+";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCalculo);
            Controls.Add(lblResulta);
            Controls.Add(textBox3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(SelectDiv);
            Controls.Add(SelectMulti);
            Controls.Add(SelectSub);
            Controls.Add(SelectAdd);
            Controls.Add(lblVoltar);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVoltar;
        private RadioButton SelectAdd;
        private RadioButton SelectSub;
        private RadioButton SelectMulti;
        private RadioButton SelectDiv;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox textBox3;
        private Label lblResulta;
        private Label lblCalculo;
    }
}