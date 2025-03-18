namespace Calculador_de_quadrilateros_e_esferas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Um quadrado é uma figura geométrica onde todos os lados têm o mesmo comprimento.


            //Perímetro de um quadrado
            //O perímetro é a soma do comprimento de todos os lados. Como todos os lados de um quadrado são iguais, o perímetro é dado por: 4*lado
        }

        private void cmbEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Erro caso não haja seleção na ComboBox
            if (cmbEscolha.SelectedItem == null)
            {
                lblErro.Text = "Selecione uma opção";
                return;

                //Lógica de combobox
            }
            if (cmbEscolha.SelectedItem.ToString() == "Quadrado")
            {
                //Tirando a visibulidade do retangulo
                grbQuadrado.Visible = true;
                grbRetangulo.Visible = false;
                grbEsfera.Visible = false;
                //Trazendo o visivel para a frente do oculto
                grbQuadrado.BringToFront();
                grbRetangulo.SendToBack();
                grbEsfera.SendToBack();
                return;

            }

            if (cmbEscolha.SelectedItem.ToString() == "Retângulo")
            {
                //Tirando a visibilidade do quadrado
                grbRetangulo.Visible = true;
                grbQuadrado.Visible = false;
                grbEsfera.Visible = false;
                //Trazendo o visivel para a frente do oculto
                grbRetangulo.BringToFront();
                grbQuadrado.SendToBack();
                grbEsfera.SendToBack();
                return;
            }

            if (cmbEscolha.SelectedItem.ToString() == "Esféra")
            {
                //Tirando a visibulidade da esfero
                grbEsfera.Visible = true;
                grbRetangulo.Visible = false;
                grbQuadrado.Visible = false;
                //Trazendo o visivel para a frente do oculto
                grbEsfera.BringToFront();
                grbRetangulo.SendToBack();
                grbQuadrado.SendToBack();
                return;

            }

        }

        private void rbPerimetroRet_CheckedChanged(object sender, EventArgs e)
        {
            txtComprimento.Enabled = false;
        }

        private void rbAreaRet_CheckedChanged(object sender, EventArgs e)
        {
            txtComprimento.Enabled = false;
        }

        private void rbVolumeRet_CheckedChanged(object sender, EventArgs e)
        {
            txtComprimento.Enabled = true;
        }

        private void btnCalcularRet_Click(object sender, EventArgs e)
        {
            //validações
            //Limpar lbl erro altomaticamente
            lblErro.Text = "";

            //Caso lblErro esteja em branco || Verificar se os caracteres são números
            if (rbPerimetroRet.Checked)
            {
                string varRetAltura = (txtAltura.Text);
                string varRetLargura = (txtLargura.Text);

                if (string.IsNullOrWhiteSpace(varRetAltura) || varRetAltura.All(char.IsNumber))
                {
                    lblErro.Text = "Insira um valor válido";
                }

                {
                    lblErro.Text = "Insira os devidos valores";
                }

            }
        }

        private void lblErro_Click(object sender, EventArgs e)
        {

        }
    }
}
