namespace Calculadora
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
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMulti = new Button();
            txtVar1 = new TextBox();
            txtVar2 = new TextBox();
            Result = new TextBox();
            lblAutent = new Label();
            btnDiv = new Button();
            lblLink = new Label();
            SuspendLayout();
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(59, 104);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(31, 27);
            btnAdicao.TabIndex = 0;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(96, 104);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(31, 27);
            btnSubtracao.TabIndex = 0;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(133, 104);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(31, 27);
            btnMulti.TabIndex = 0;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // txtVar1
            // 
            txtVar1.Location = new Point(60, 75);
            txtVar1.Name = "txtVar1";
            txtVar1.Size = new Size(39, 23);
            txtVar1.TabIndex = 1;
            // 
            // txtVar2
            // 
            txtVar2.Location = new Point(105, 75);
            txtVar2.Name = "txtVar2";
            txtVar2.Size = new Size(39, 23);
            txtVar2.TabIndex = 1;
            // 
            // Result
            // 
            Result.BackColor = Color.AntiqueWhite;
            Result.Location = new Point(162, 75);
            Result.Name = "Result";
            Result.Size = new Size(39, 23);
            Result.TabIndex = 1;
            // 
            // lblAutent
            // 
            lblAutent.AutoSize = true;
            lblAutent.Location = new Point(60, 149);
            lblAutent.Name = "lblAutent";
            lblAutent.Size = new Size(19, 15);
            lblAutent.TabIndex = 2;
            lblAutent.Text = "    ";
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(170, 104);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(31, 27);
            btnDiv.TabIndex = 3;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.ForeColor = Color.CornflowerBlue;
            lblLink.Location = new Point(59, 149);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(29, 15);
            lblLink.TabIndex = 4;
            lblLink.Text = "Link";
            lblLink.Click += lblLink_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLink);
            Controls.Add(btnDiv);
            Controls.Add(lblAutent);
            Controls.Add(Result);
            Controls.Add(txtVar2);
            Controls.Add(txtVar1);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMulti;
        private TextBox txtVar1;
        private TextBox txtVar2;
        private TextBox Result;
        private Label lblAutent;
        private Button btnDiv;
        private Label lblLink;
    }
}
