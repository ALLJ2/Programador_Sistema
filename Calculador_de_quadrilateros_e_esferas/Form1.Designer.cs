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
            txtLadosQUAD = new TextBox();
            txtResultadoQuad = new TextBox();
            btnCalcularQuad = new Button();
            grbRetangulo = new GroupBox();
            btnCalcularRet = new Button();
            lblRetTitulo = new Label();
            rbVolumeRet = new RadioButton();
            rbAreaRet = new RadioButton();
            rbPerimetroRet = new RadioButton();
            txtLargura = new TextBox();
            txtResultadoRet = new TextBox();
            txtComprimento = new TextBox();
            txtAltura = new TextBox();
            lblResultadoQuad = new Label();
            lblLargura = new Label();
            lblComprimento = new Label();
            lblAltura = new Label();
            grbQuadrado = new GroupBox();
            rdVolumeQuad = new RadioButton();
            rdAreaQuad = new RadioButton();
            rdPerimetroQuad = new RadioButton();
            linkParaFormsEsfera = new LinkLabel();
            lblErro = new Label();
            grbRetangulo.SuspendLayout();
            grbQuadrado.SuspendLayout();
            SuspendLayout();
            // 
            // lblLadosQuad
            // 
            lblLadosQuad.AutoSize = true;
            lblLadosQuad.Location = new Point(4, 66);
            lblLadosQuad.Name = "lblLadosQuad";
            lblLadosQuad.Size = new Size(38, 15);
            lblLadosQuad.TabIndex = 0;
            lblLadosQuad.Text = "Lados";
            // 
            // lblResultadoRet
            // 
            lblResultadoRet.AutoSize = true;
            lblResultadoRet.Location = new Point(4, 94);
            lblResultadoRet.Name = "lblResultadoRet";
            lblResultadoRet.Size = new Size(59, 15);
            lblResultadoRet.TabIndex = 0;
            lblResultadoRet.Text = "Resultado";
            // 
            // cmbEscolha
            // 
            cmbEscolha.FormattingEnabled = true;
            cmbEscolha.Items.AddRange(new object[] { "Retangulo", "Quadrado" });
            cmbEscolha.Location = new Point(12, 12);
            cmbEscolha.Name = "cmbEscolha";
            cmbEscolha.Size = new Size(121, 23);
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
            // txtLadosQUAD
            // 
            txtLadosQUAD.Location = new Point(99, 61);
            txtLadosQUAD.Name = "txtLadosQUAD";
            txtLadosQUAD.Size = new Size(100, 23);
            txtLadosQUAD.TabIndex = 1;
            // 
            // txtResultadoQuad
            // 
            txtResultadoQuad.Location = new Point(99, 89);
            txtResultadoQuad.Name = "txtResultadoQuad";
            txtResultadoQuad.Size = new Size(100, 23);
            txtResultadoQuad.TabIndex = 1;
            // 
            // btnCalcularQuad
            // 
            btnCalcularQuad.Location = new Point(99, 20);
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
            grbRetangulo.Controls.Add(rbAreaRet);
            grbRetangulo.Controls.Add(rbPerimetroRet);
            grbRetangulo.Controls.Add(txtLargura);
            grbRetangulo.Controls.Add(txtResultadoRet);
            grbRetangulo.Controls.Add(txtComprimento);
            grbRetangulo.Controls.Add(txtAltura);
            grbRetangulo.Controls.Add(lblResultadoQuad);
            grbRetangulo.Controls.Add(lblLargura);
            grbRetangulo.Controls.Add(lblComprimento);
            grbRetangulo.Controls.Add(lblAltura);
            grbRetangulo.Location = new Point(12, 41);
            grbRetangulo.Name = "grbRetangulo";
            grbRetangulo.Size = new Size(301, 181);
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
            rbVolumeRet.Location = new Point(207, 118);
            rbVolumeRet.Name = "rbVolumeRet";
            rbVolumeRet.Size = new Size(65, 19);
            rbVolumeRet.TabIndex = 14;
            rbVolumeRet.TabStop = true;
            rbVolumeRet.Text = "Volume";
            rbVolumeRet.UseVisualStyleBackColor = true;
            // 
            // rbAreaRet
            // 
            rbAreaRet.AutoSize = true;
            rbAreaRet.Location = new Point(207, 89);
            rbAreaRet.Name = "rbAreaRet";
            rbAreaRet.Size = new Size(49, 19);
            rbAreaRet.TabIndex = 15;
            rbAreaRet.TabStop = true;
            rbAreaRet.Text = "Área";
            rbAreaRet.UseVisualStyleBackColor = true;
            // 
            // rbPerimetroRet
            // 
            rbPerimetroRet.AutoSize = true;
            rbPerimetroRet.Location = new Point(207, 58);
            rbPerimetroRet.Name = "rbPerimetroRet";
            rbPerimetroRet.Size = new Size(77, 19);
            rbPerimetroRet.TabIndex = 16;
            rbPerimetroRet.TabStop = true;
            rbPerimetroRet.Text = "Perímetro";
            rbPerimetroRet.UseVisualStyleBackColor = true;
            // 
            // txtLargura
            // 
            txtLargura.Location = new Point(101, 87);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(100, 23);
            txtLargura.TabIndex = 10;
            // 
            // txtResultadoRet
            // 
            txtResultadoRet.Location = new Point(101, 145);
            txtResultadoRet.Name = "txtResultadoRet";
            txtResultadoRet.Size = new Size(100, 23);
            txtResultadoRet.TabIndex = 11;
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(101, 116);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(100, 23);
            txtComprimento.TabIndex = 12;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(101, 58);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 13;
            // 
            // lblResultadoQuad
            // 
            lblResultadoQuad.AutoSize = true;
            lblResultadoQuad.Location = new Point(3, 153);
            lblResultadoQuad.Name = "lblResultadoQuad";
            lblResultadoQuad.Size = new Size(59, 15);
            lblResultadoQuad.TabIndex = 6;
            lblResultadoQuad.Text = "Resultado";
            // 
            // lblLargura
            // 
            lblLargura.AutoSize = true;
            lblLargura.Location = new Point(3, 95);
            lblLargura.Name = "lblLargura";
            lblLargura.Size = new Size(47, 15);
            lblLargura.TabIndex = 7;
            lblLargura.Text = "Largura";
            // 
            // lblComprimento
            // 
            lblComprimento.AutoSize = true;
            lblComprimento.Location = new Point(3, 124);
            lblComprimento.Name = "lblComprimento";
            lblComprimento.Size = new Size(82, 15);
            lblComprimento.TabIndex = 8;
            lblComprimento.Text = "Comprimento";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(3, 66);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 9;
            lblAltura.Text = "Altura";
            // 
            // grbQuadrado
            // 
            grbQuadrado.Controls.Add(lblQuadTitulo);
            grbQuadrado.Controls.Add(lblLadosQuad);
            grbQuadrado.Controls.Add(rdVolumeQuad);
            grbQuadrado.Controls.Add(btnCalcularQuad);
            grbQuadrado.Controls.Add(rdAreaQuad);
            grbQuadrado.Controls.Add(lblResultadoRet);
            grbQuadrado.Controls.Add(txtLadosQUAD);
            grbQuadrado.Controls.Add(rdPerimetroQuad);
            grbQuadrado.Controls.Add(txtResultadoQuad);
            grbQuadrado.Location = new Point(356, 41);
            grbQuadrado.Name = "grbQuadrado";
            grbQuadrado.Size = new Size(292, 181);
            grbQuadrado.TabIndex = 7;
            grbQuadrado.TabStop = false;
            grbQuadrado.Text = "Quadrado";
            // 
            // rdVolumeQuad
            // 
            rdVolumeQuad.AutoSize = true;
            rdVolumeQuad.Location = new Point(205, 117);
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
            rdAreaQuad.Location = new Point(205, 89);
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
            rdPerimetroQuad.Location = new Point(205, 58);
            rdPerimetroQuad.Name = "rdPerimetroQuad";
            rdPerimetroQuad.Size = new Size(77, 19);
            rdPerimetroQuad.TabIndex = 16;
            rdPerimetroQuad.TabStop = true;
            rdPerimetroQuad.Text = "Perímetro";
            rdPerimetroQuad.UseVisualStyleBackColor = true;
            // 
            // linkParaFormsEsfera
            // 
            linkParaFormsEsfera.AutoSize = true;
            linkParaFormsEsfera.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkParaFormsEsfera.Location = new Point(15, 248);
            linkParaFormsEsfera.Name = "linkParaFormsEsfera";
            linkParaFormsEsfera.Size = new Size(131, 25);
            linkParaFormsEsfera.TabIndex = 8;
            linkParaFormsEsfera.TabStop = true;
            linkParaFormsEsfera.Text = "Ir para esfera";
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(15, 301);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(49, 15);
            lblErro.TabIndex = 9;
            lblErro.Text = "              ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErro);
            Controls.Add(linkParaFormsEsfera);
            Controls.Add(grbQuadrado);
            Controls.Add(grbRetangulo);
            Controls.Add(cmbEscolha);
            Name = "Form1";
            Text = "Form1";
            grbRetangulo.ResumeLayout(false);
            grbRetangulo.PerformLayout();
            grbQuadrado.ResumeLayout(false);
            grbQuadrado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLadosQuad;
        private Label lblResultadoRet;
        private ComboBox cmbEscolha;
        private Label lblQuadTitulo;
        private TextBox txtLadosQUAD;
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
        private RadioButton rdPerimetroQuad;
        private RadioButton rdAreaQuad;
        private RadioButton rdVolumeQuad;
        private LinkLabel linkParaFormsEsfera;
        private Label lblErro;
    }
}
