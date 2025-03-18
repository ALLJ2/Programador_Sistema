namespace Calculador_de_quadrilateros_e_esferas
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
            lblLadosQuad = new Label();
            lblResultadoRet = new Label();
            cmbEscolha = new ComboBox();
            lblQuadTitulo = new Label();
            txtLadosQuad = new TextBox();
            txtResultadoQuad = new TextBox();
            btnCalcularQuad = new Button();
            grbRetangulo = new GroupBox();
            btnCalcularRet = new Button();
            lblRetTitulo = new Label();
            rbVolumeRet = new RadioButton();
            lblResultadoQuad = new Label();
            lblLargura = new Label();
            rbAreaRet = new RadioButton();
            lblComprimento = new Label();
            lblAltura = new Label();
            rbPerimetroRet = new RadioButton();
            txtAltura = new TextBox();
            txtLargura = new TextBox();
            txtComprimento = new TextBox();
            txtResultadoRet = new TextBox();
            grbQuadrado = new GroupBox();
            lblErro = new Label();
            grbEsfera = new GroupBox();
            lblEsferaTitulo = new Label();
            btnCalcularEsf = new Button();
            rdVolumeEsf = new RadioButton();
            lblRaioEsf = new Label();
            rdAreaEsf = new RadioButton();
            txtRaioEsf = new TextBox();
            txtResultadoEsf = new TextBox();
            rdPerimetroEsf = new RadioButton();
            lblResultadoEsf = new Label();
            rdDiametroEsf = new RadioButton();
            rdVolumeQuad = new RadioButton();
            rdAreaQuad = new RadioButton();
            rdPerimetroQuad = new RadioButton();
            grbRetangulo.SuspendLayout();
            grbQuadrado.SuspendLayout();
            grbEsfera.SuspendLayout();
            SuspendLayout();
            // 
            // lblLadosQuad
            // 
            lblLadosQuad.AutoSize = true;
            lblLadosQuad.Location = new Point(4, 69);
            lblLadosQuad.Name = "lblLadosQuad";
            lblLadosQuad.Size = new Size(38, 15);
            lblLadosQuad.TabIndex = 0;
            lblLadosQuad.Text = "Lados";
            // 
            // lblResultadoRet
            // 
            lblResultadoRet.AutoSize = true;
            lblResultadoRet.Location = new Point(4, 97);
            lblResultadoRet.Name = "lblResultadoRet";
            lblResultadoRet.Size = new Size(59, 15);
            lblResultadoRet.TabIndex = 0;
            lblResultadoRet.Text = "Resultado";
            // 
            // cmbEscolha
            // 
            cmbEscolha.FormattingEnabled = true;
            cmbEscolha.Items.AddRange(new object[] { "Retângulo", "Quadrado", "Esféra" });
            cmbEscolha.Location = new Point(12, 12);
            cmbEscolha.Name = "cmbEscolha";
            cmbEscolha.Size = new Size(109, 23);
            cmbEscolha.TabIndex = 4;
            cmbEscolha.SelectedIndexChanged += cmbEscolha_SelectedIndexChanged;
            // 
            // lblQuadTitulo
            // 
            lblQuadTitulo.AutoSize = true;
            lblQuadTitulo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuadTitulo.Location = new Point(4, 19);
            lblQuadTitulo.Name = "lblQuadTitulo";
            lblQuadTitulo.Size = new Size(87, 21);
            lblQuadTitulo.TabIndex = 3;
            lblQuadTitulo.Text = "Quadrado";
            // 
            // txtLadosQuad
            // 
            txtLadosQuad.Location = new Point(99, 61);
            txtLadosQuad.Name = "txtLadosQuad";
            txtLadosQuad.Size = new Size(100, 23);
            txtLadosQuad.TabIndex = 1;
            // 
            // txtResultadoQuad
            // 
            txtResultadoQuad.Location = new Point(99, 90);
            txtResultadoQuad.Name = "txtResultadoQuad";
            txtResultadoQuad.Size = new Size(100, 23);
            txtResultadoQuad.TabIndex = 1;
            // 
            // btnCalcularQuad
            // 
            btnCalcularQuad.Location = new Point(99, 17);
            btnCalcularQuad.Name = "btnCalcularQuad";
            btnCalcularQuad.Size = new Size(75, 23);
            btnCalcularQuad.TabIndex = 5;
            btnCalcularQuad.Text = "Calcular";
            btnCalcularQuad.UseVisualStyleBackColor = true;
            // 
            // grbRetangulo
            // 
            grbRetangulo.Controls.Add(btnCalcularRet);
            grbRetangulo.Controls.Add(lblRetTitulo);
            grbRetangulo.Controls.Add(rbVolumeRet);
            grbRetangulo.Controls.Add(lblResultadoQuad);
            grbRetangulo.Controls.Add(lblLargura);
            grbRetangulo.Controls.Add(lblComprimento);
            grbRetangulo.Controls.Add(lblAltura);
            grbRetangulo.Controls.Add(txtAltura);
            grbRetangulo.Controls.Add(txtLargura);
            grbRetangulo.Controls.Add(rbPerimetroRet);
            grbRetangulo.Controls.Add(rbAreaRet);
            grbRetangulo.Controls.Add(txtComprimento);
            grbRetangulo.Controls.Add(txtResultadoRet);
            grbRetangulo.Location = new Point(12, 41);
            grbRetangulo.Name = "grbRetangulo";
            grbRetangulo.Size = new Size(289, 365);
            grbRetangulo.TabIndex = 6;
            grbRetangulo.TabStop = false;
            grbRetangulo.Text = "Retâgulo";
            // 
            // btnCalcularRet
            // 
            btnCalcularRet.Location = new Point(101, 17);
            btnCalcularRet.Name = "btnCalcularRet";
            btnCalcularRet.Size = new Size(75, 23);
            btnCalcularRet.TabIndex = 18;
            btnCalcularRet.Text = "Calcular";
            btnCalcularRet.UseVisualStyleBackColor = true;
            btnCalcularRet.Click += btnCalcularRet_Click;
            // 
            // lblRetTitulo
            // 
            lblRetTitulo.AutoSize = true;
            lblRetTitulo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetTitulo.Location = new Point(3, 19);
            lblRetTitulo.Name = "lblRetTitulo";
            lblRetTitulo.Size = new Size(91, 21);
            lblRetTitulo.TabIndex = 17;
            lblRetTitulo.Text = "Retângulo";
            // 
            // rbVolumeRet
            // 
            rbVolumeRet.AutoSize = true;
            rbVolumeRet.Location = new Point(207, 112);
            rbVolumeRet.Name = "rbVolumeRet";
            rbVolumeRet.Size = new Size(65, 19);
            rbVolumeRet.TabIndex = 14;
            rbVolumeRet.TabStop = true;
            rbVolumeRet.Text = "Volume";
            rbVolumeRet.UseVisualStyleBackColor = true;
            rbVolumeRet.CheckedChanged += rbVolumeRet_CheckedChanged;
            // 
            // lblResultadoQuad
            // 
            lblResultadoQuad.AutoSize = true;
            lblResultadoQuad.Location = new Point(6, 153);
            lblResultadoQuad.Name = "lblResultadoQuad";
            lblResultadoQuad.Size = new Size(59, 15);
            lblResultadoQuad.TabIndex = 6;
            lblResultadoQuad.Text = "Resultado";
            // 
            // lblLargura
            // 
            lblLargura.AutoSize = true;
            lblLargura.Location = new Point(6, 97);
            lblLargura.Name = "lblLargura";
            lblLargura.Size = new Size(47, 15);
            lblLargura.TabIndex = 7;
            lblLargura.Text = "Largura";
            // 
            // rbAreaRet
            // 
            rbAreaRet.AutoSize = true;
            rbAreaRet.Location = new Point(207, 87);
            rbAreaRet.Name = "rbAreaRet";
            rbAreaRet.Size = new Size(49, 19);
            rbAreaRet.TabIndex = 15;
            rbAreaRet.TabStop = true;
            rbAreaRet.Text = "Área";
            rbAreaRet.UseVisualStyleBackColor = true;
            rbAreaRet.CheckedChanged += rbAreaRet_CheckedChanged;
            // 
            // lblComprimento
            // 
            lblComprimento.AutoSize = true;
            lblComprimento.Location = new Point(6, 124);
            lblComprimento.Name = "lblComprimento";
            lblComprimento.Size = new Size(82, 15);
            lblComprimento.TabIndex = 8;
            lblComprimento.Text = "Comprimento";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(6, 69);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 9;
            lblAltura.Text = "Altura";
            // 
            // rbPerimetroRet
            // 
            rbPerimetroRet.AutoSize = true;
            rbPerimetroRet.Location = new Point(207, 64);
            rbPerimetroRet.Name = "rbPerimetroRet";
            rbPerimetroRet.Size = new Size(77, 19);
            rbPerimetroRet.TabIndex = 16;
            rbPerimetroRet.TabStop = true;
            rbPerimetroRet.Text = "Perímetro";
            rbPerimetroRet.UseVisualStyleBackColor = true;
            rbPerimetroRet.CheckedChanged += rbPerimetroRet_CheckedChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(101, 61);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 13;
            // 
            // txtLargura
            // 
            txtLargura.Location = new Point(101, 88);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(100, 23);
            txtLargura.TabIndex = 10;
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(101, 116);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(100, 23);
            txtComprimento.TabIndex = 12;
            // 
            // txtResultadoRet
            // 
            txtResultadoRet.Location = new Point(101, 145);
            txtResultadoRet.Name = "txtResultadoRet";
            txtResultadoRet.Size = new Size(100, 23);
            txtResultadoRet.TabIndex = 11;
            // 
            // grbQuadrado
            // 
            grbQuadrado.Controls.Add(lblQuadTitulo);
            grbQuadrado.Controls.Add(lblLadosQuad);
            grbQuadrado.Controls.Add(rdVolumeQuad);
            grbQuadrado.Controls.Add(btnCalcularQuad);
            grbQuadrado.Controls.Add(txtLadosQuad);
            grbQuadrado.Controls.Add(txtResultadoQuad);
            grbQuadrado.Controls.Add(lblResultadoRet);
            grbQuadrado.Controls.Add(rdPerimetroQuad);
            grbQuadrado.Controls.Add(rdAreaQuad);
            grbQuadrado.Location = new Point(307, 41);
            grbQuadrado.Name = "grbQuadrado";
            grbQuadrado.Size = new Size(289, 365);
            grbQuadrado.TabIndex = 7;
            grbQuadrado.TabStop = false;
            grbQuadrado.Text = "Quadrado";
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(139, 12);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(49, 15);
            lblErro.TabIndex = 9;
            lblErro.Text = "              ";
            lblErro.Click += lblErro_Click;
            // 
            // grbEsfera
            // 
            grbEsfera.Controls.Add(lblEsferaTitulo);
            grbEsfera.Controls.Add(btnCalcularEsf);
            grbEsfera.Controls.Add(rdVolumeEsf);
            grbEsfera.Controls.Add(lblRaioEsf);
            grbEsfera.Controls.Add(txtRaioEsf);
            grbEsfera.Controls.Add(rdAreaEsf);
            grbEsfera.Controls.Add(txtResultadoEsf);
            grbEsfera.Controls.Add(rdPerimetroEsf);
            grbEsfera.Controls.Add(lblResultadoEsf);
            grbEsfera.Controls.Add(rdDiametroEsf);
            grbEsfera.Location = new Point(602, 41);
            grbEsfera.Name = "grbEsfera";
            grbEsfera.Size = new Size(286, 365);
            grbEsfera.TabIndex = 10;
            grbEsfera.TabStop = false;
            grbEsfera.Text = "Esféra";
            // 
            // lblEsferaTitulo
            // 
            lblEsferaTitulo.AutoSize = true;
            lblEsferaTitulo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEsferaTitulo.Location = new Point(4, 19);
            lblEsferaTitulo.Name = "lblEsferaTitulo";
            lblEsferaTitulo.Size = new Size(59, 21);
            lblEsferaTitulo.TabIndex = 3;
            lblEsferaTitulo.Text = "Esféra";
            // 
            // btnCalcularEsf
            // 
            btnCalcularEsf.Location = new Point(99, 17);
            btnCalcularEsf.Name = "btnCalcularEsf";
            btnCalcularEsf.Size = new Size(75, 23);
            btnCalcularEsf.TabIndex = 5;
            btnCalcularEsf.Text = "Calcular";
            btnCalcularEsf.UseVisualStyleBackColor = true;
            // 
            // rdVolumeEsf
            // 
            rdVolumeEsf.AutoSize = true;
            rdVolumeEsf.Location = new Point(205, 137);
            rdVolumeEsf.Name = "rdVolumeEsf";
            rdVolumeEsf.Size = new Size(65, 19);
            rdVolumeEsf.TabIndex = 14;
            rdVolumeEsf.TabStop = true;
            rdVolumeEsf.Text = "Volume";
            rdVolumeEsf.UseVisualStyleBackColor = true;
            // 
            // lblRaioEsf
            // 
            lblRaioEsf.AutoSize = true;
            lblRaioEsf.Location = new Point(4, 66);
            lblRaioEsf.Name = "lblRaioEsf";
            lblRaioEsf.Size = new Size(30, 15);
            lblRaioEsf.TabIndex = 9;
            lblRaioEsf.Text = "Raio";
            // 
            // rdAreaEsf
            // 
            rdAreaEsf.AutoSize = true;
            rdAreaEsf.Location = new Point(205, 112);
            rdAreaEsf.Name = "rdAreaEsf";
            rdAreaEsf.Size = new Size(49, 19);
            rdAreaEsf.TabIndex = 14;
            rdAreaEsf.TabStop = true;
            rdAreaEsf.Text = "Área";
            rdAreaEsf.UseVisualStyleBackColor = true;
            // 
            // txtRaioEsf
            // 
            txtRaioEsf.Location = new Point(99, 60);
            txtRaioEsf.Name = "txtRaioEsf";
            txtRaioEsf.Size = new Size(100, 23);
            txtRaioEsf.TabIndex = 13;
            // 
            // txtResultadoEsf
            // 
            txtResultadoEsf.Location = new Point(99, 89);
            txtResultadoEsf.Name = "txtResultadoEsf";
            txtResultadoEsf.Size = new Size(100, 23);
            txtResultadoEsf.TabIndex = 1;
            // 
            // rdPerimetroEsf
            // 
            rdPerimetroEsf.AutoSize = true;
            rdPerimetroEsf.Location = new Point(205, 87);
            rdPerimetroEsf.Name = "rdPerimetroEsf";
            rdPerimetroEsf.Size = new Size(77, 19);
            rdPerimetroEsf.TabIndex = 14;
            rdPerimetroEsf.TabStop = true;
            rdPerimetroEsf.Text = "Perímetro";
            rdPerimetroEsf.UseVisualStyleBackColor = true;
            // 
            // lblResultadoEsf
            // 
            lblResultadoEsf.AutoSize = true;
            lblResultadoEsf.Location = new Point(4, 95);
            lblResultadoEsf.Name = "lblResultadoEsf";
            lblResultadoEsf.Size = new Size(59, 15);
            lblResultadoEsf.TabIndex = 0;
            lblResultadoEsf.Text = "Resultado";
            // 
            // rdDiametroEsf
            // 
            rdDiametroEsf.AutoSize = true;
            rdDiametroEsf.Location = new Point(205, 62);
            rdDiametroEsf.Name = "rdDiametroEsf";
            rdDiametroEsf.Size = new Size(74, 19);
            rdDiametroEsf.TabIndex = 14;
            rdDiametroEsf.TabStop = true;
            rdDiametroEsf.Text = "Diametro";
            rdDiametroEsf.UseVisualStyleBackColor = true;
            // 
            // rdVolumeQuad
            // 
            rdVolumeQuad.AutoSize = true;
            rdVolumeQuad.Location = new Point(205, 112);
            rdVolumeQuad.Name = "rdVolumeQuad";
            rdVolumeQuad.Size = new Size(65, 19);
            rdVolumeQuad.TabIndex = 14;
            rdVolumeQuad.TabStop = true;
            rdVolumeQuad.Text = "Volume";
            rdVolumeQuad.UseVisualStyleBackColor = true;
            // 
            // rdAreaQuad
            // 
            rdAreaQuad.AutoSize = true;
            rdAreaQuad.Location = new Point(205, 87);
            rdAreaQuad.Name = "rdAreaQuad";
            rdAreaQuad.Size = new Size(49, 19);
            rdAreaQuad.TabIndex = 15;
            rdAreaQuad.TabStop = true;
            rdAreaQuad.Text = "Área";
            rdAreaQuad.UseVisualStyleBackColor = true;
            // 
            // rdPerimetroQuad
            // 
            rdPerimetroQuad.AutoSize = true;
            rdPerimetroQuad.Location = new Point(205, 62);
            rdPerimetroQuad.Name = "rdPerimetroQuad";
            rdPerimetroQuad.Size = new Size(77, 19);
            rdPerimetroQuad.TabIndex = 16;
            rdPerimetroQuad.TabStop = true;
            rdPerimetroQuad.Text = "Perímetro";
            rdPerimetroQuad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 487);
            Controls.Add(grbEsfera);
            Controls.Add(lblErro);
            Controls.Add(grbQuadrado);
            Controls.Add(grbRetangulo);
            Controls.Add(cmbEscolha);
            Name = "Form1";
            Text = "Form1";
            grbRetangulo.ResumeLayout(false);
            grbRetangulo.PerformLayout();
            grbQuadrado.ResumeLayout(false);
            grbQuadrado.PerformLayout();
            grbEsfera.ResumeLayout(false);
            grbEsfera.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLadosQuad;
        private Label lblResultadoRet;
        private ComboBox cmbEscolha;
        private Label lblQuadTitulo;
        private TextBox txtLadosQuad;
        private TextBox txtResultadoQuad;
        private Button btnCalcularQuad;
        private GroupBox grbRetangulo;
        private Button btnCalcularRet;
        private Label lblRetTitulo;
        private RadioButton rbVolumeRet;
        private RadioButton rbAreaRet;
        private RadioButton rbPerimetroRet;
        private TextBox txtLargura;
        private TextBox txtResultadoRet;
        private TextBox txtComprimento;
        private TextBox txtAltura;
        private Label lblResultadoQuad;
        private Label lblLargura;
        private Label lblComprimento;
        private Label lblAltura;
        private GroupBox grbQuadrado;
        private Label lblErro;
        private GroupBox grbEsfera;
        private TextBox txtRaioEsf;
        private Label lblRaioEsf;
        private RadioButton rdDiametroEsf;
        private RadioButton rdPerimetroEsf;
        private RadioButton rdAreaEsf;
        private RadioButton rdVolumeEsf;
        private Label lblEsferaTitulo;
        private TextBox txtResultadoEsf;
        private Label lblResultadoEsf;
        private Button btnCalcularEsf;
        private RadioButton rdVolumeQuad;
        private RadioButton rdPerimetroQuad;
        private RadioButton rdAreaQuad;
    }
}
