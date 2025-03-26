namespace CadastroUsuario
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            mtxtNascimento = new MaskedTextBox();
            mtxtTelefone = new MaskedTextBox();
            lblNomeSocial = new Label();
            txtNomeSocial = new TextBox();
            cmbGenero = new ComboBox();
            cmbEtnia = new ComboBox();
            cbExtrangeiro = new CheckBox();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            cmbEstado = new ComboBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            mtxtCEP = new MaskedTextBox();
            btnCadastrar = new Button();
            label8 = new Label();
            lblTelefone = new Label();
            lblCEP = new Label();
            rbTipoPF = new RadioButton();
            rbTipoPJ = new RadioButton();
            lblMunicipio = new Label();
            txtMunicipio = new TextBox();
            mtxtPF = new MaskedTextBox();
            mtxtPJ = new MaskedTextBox();
            lblGenero = new Label();
            lblEtnia = new Label();
            lblEstado = new Label();
            btnLimpar = new Button();
            lblErro = new Label();
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(43, 354);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(174, 346);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(43, 383);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 375);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // mtxtNascimento
            // 
            mtxtNascimento.Location = new Point(449, 346);
            mtxtNascimento.Mask = "00/00/0000";
            mtxtNascimento.Name = "mtxtNascimento";
            mtxtNascimento.Size = new Size(100, 23);
            mtxtNascimento.TabIndex = 2;
            mtxtNascimento.ValidatingType = typeof(DateTime);
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Location = new Point(449, 375);
            mtxtTelefone.Mask = "(999) 000-0000";
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(100, 23);
            mtxtTelefone.TabIndex = 2;
            // 
            // lblNomeSocial
            // 
            lblNomeSocial.AutoSize = true;
            lblNomeSocial.Location = new Point(318, 499);
            lblNomeSocial.Name = "lblNomeSocial";
            lblNomeSocial.Size = new Size(73, 15);
            lblNomeSocial.TabIndex = 0;
            lblNomeSocial.Text = "Nome social";
            // 
            // txtNomeSocial
            // 
            txtNomeSocial.Location = new Point(449, 496);
            txtNomeSocial.Name = "txtNomeSocial";
            txtNomeSocial.Size = new Size(100, 23);
            txtNomeSocial.TabIndex = 1;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            cmbGenero.Location = new Point(745, 346);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(100, 23);
            cmbGenero.TabIndex = 3;
            cmbGenero.Text = "Genero";
            // 
            // cmbEtnia
            // 
            cmbEtnia.FormattingEnabled = true;
            cmbEtnia.Items.AddRange(new object[] { "Amarelo", "Branco", "Pardo", "Indigena", "Negro" });
            cmbEtnia.Location = new Point(745, 375);
            cmbEtnia.Name = "cmbEtnia";
            cmbEtnia.Size = new Size(100, 23);
            cmbEtnia.TabIndex = 3;
            cmbEtnia.Text = "Etnia";
            // 
            // cbExtrangeiro
            // 
            cbExtrangeiro.AutoSize = true;
            cbExtrangeiro.Location = new Point(318, 524);
            cbExtrangeiro.Name = "cbExtrangeiro";
            cbExtrangeiro.Size = new Size(109, 19);
            cbExtrangeiro.TabIndex = 4;
            cbExtrangeiro.Text = "Sou extrangeiro";
            cbExtrangeiro.UseVisualStyleBackColor = true;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(43, 412);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 0;
            lblLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(174, 404);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(100, 23);
            txtLogradouro.TabIndex = 1;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(43, 441);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(174, 433);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(43, 470);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 0;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(174, 462);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 1;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            cmbEstado.Location = new Point(745, 404);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(100, 23);
            cmbEstado.TabIndex = 3;
            cmbEstado.Text = "Estado";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(43, 499);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 0;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(174, 491);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 1;
            // 
            // mtxtCEP
            // 
            mtxtCEP.Location = new Point(449, 404);
            mtxtCEP.Mask = "000-00-0000";
            mtxtCEP.Name = "mtxtCEP";
            mtxtCEP.Size = new Size(100, 23);
            mtxtCEP.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(330, 263);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 37);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(318, 354);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 0;
            label8.Text = "Data de nascimento";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(318, 383);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 0;
            lblTelefone.Text = "Telefone";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(318, 412);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(28, 15);
            lblCEP.TabIndex = 0;
            lblCEP.Text = "CEP";
            // 
            // rbTipoPF
            // 
            rbTipoPF.AutoSize = true;
            rbTipoPF.Location = new Point(318, 437);
            rbTipoPF.Name = "rbTipoPF";
            rbTipoPF.Size = new Size(91, 19);
            rbTipoPF.TabIndex = 6;
            rbTipoPF.TabStop = true;
            rbTipoPF.Text = "Pessoa física";
            rbTipoPF.UseVisualStyleBackColor = true;
            // 
            // rbTipoPJ
            // 
            rbTipoPJ.AutoSize = true;
            rbTipoPJ.Location = new Point(318, 466);
            rbTipoPJ.Name = "rbTipoPJ";
            rbTipoPJ.Size = new Size(103, 19);
            rbTipoPJ.TabIndex = 6;
            rbTipoPJ.TabStop = true;
            rbTipoPJ.Text = "Pessoa jurídica";
            rbTipoPJ.UseVisualStyleBackColor = true;
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Location = new Point(43, 528);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(61, 15);
            lblMunicipio.TabIndex = 0;
            lblMunicipio.Text = "Município";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(174, 520);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(100, 23);
            txtMunicipio.TabIndex = 1;
            // 
            // mtxtPF
            // 
            mtxtPF.Location = new Point(449, 433);
            mtxtPF.Mask = "00000-9999";
            mtxtPF.Name = "mtxtPF";
            mtxtPF.Size = new Size(100, 23);
            mtxtPF.TabIndex = 2;
            // 
            // mtxtPJ
            // 
            mtxtPJ.Location = new Point(449, 462);
            mtxtPJ.Mask = "00000-9999";
            mtxtPJ.Name = "mtxtPJ";
            mtxtPJ.Size = new Size(100, 23);
            mtxtPJ.TabIndex = 2;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(614, 354);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 0;
            lblGenero.Text = "Genero";
            // 
            // lblEtnia
            // 
            lblEtnia.AutoSize = true;
            lblEtnia.Location = new Point(614, 383);
            lblEtnia.Name = "lblEtnia";
            lblEtnia.Size = new Size(33, 15);
            lblEtnia.TabIndex = 0;
            lblEtnia.Text = "Etnia";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(614, 412);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(43, 263);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 37);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(149, 274);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(22, 15);
            lblErro.TabIndex = 0;
            lblErro.Text = "     ";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(43, 37);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.Size = new Size(385, 220);
            dataGridViewClientes.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 646);
            Controls.Add(dataGridViewClientes);
            Controls.Add(rbTipoPJ);
            Controls.Add(rbTipoPF);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbExtrangeiro);
            Controls.Add(cmbEstado);
            Controls.Add(cmbEtnia);
            Controls.Add(cmbGenero);
            Controls.Add(mtxtCEP);
            Controls.Add(mtxtPJ);
            Controls.Add(mtxtPF);
            Controls.Add(mtxtTelefone);
            Controls.Add(mtxtNascimento);
            Controls.Add(txtMunicipio);
            Controls.Add(txtBairro);
            Controls.Add(lblEstado);
            Controls.Add(lblMunicipio);
            Controls.Add(txtComplemento);
            Controls.Add(lblBairro);
            Controls.Add(txtLogradouro);
            Controls.Add(lblComplemento);
            Controls.Add(lblLogradouro);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtNomeSocial);
            Controls.Add(lblCEP);
            Controls.Add(lblNomeSocial);
            Controls.Add(lblEtnia);
            Controls.Add(lblTelefone);
            Controls.Add(lblGenero);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(label8);
            Controls.Add(txtNome);
            Controls.Add(lblErro);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private MaskedTextBox mtxtNascimento;
        private MaskedTextBox mtxtTelefone;
        private Label lblNomeSocial;
        private TextBox txtNomeSocial;
        private ComboBox cmbGenero;
        private ComboBox cmbEtnia;
        private CheckBox cbExtrangeiro;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private ComboBox cmbEstado;
        private Label lblBairro;
        private TextBox txtBairro;
        private MaskedTextBox mtxtCEP;
        private Button btnCadastrar;
        private Label label8;
        private Label lblTelefone;
        private Label lblCEP;
        private RadioButton rbTipoPF;
        private RadioButton rbTipoPJ;
        private Label lblMunicipio;
        private TextBox txtMunicipio;
        private MaskedTextBox mtxtPF;
        private MaskedTextBox mtxtPJ;
        private Label lblGenero;
        private Label lblEtnia;
        private Label lblEstado;
        private Button btnLimpar;
        private Label lblErro;
        private DataGridView dataGridViewClientes;
    }
}
