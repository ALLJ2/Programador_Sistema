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
            //Um quadrado � uma figura geom�trica onde todos os lados t�m o mesmo comprimento.


            //Per�metro de um quadrado
            //O per�metro � a soma do comprimento de todos os lados. Como todos os lados de um quadrado s�o iguais, o per�metro � dado por: 4*lado
        }

        private void cmbEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Erro caso n�o haja sele��o na ComboBox
            if (cmbEscolha.SelectedItem == null)
            {
                lblErro.Text = "Selecione uma op��o";
                return;

                //L�gica de combobox
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

            if (cmbEscolha.SelectedItem.ToString() == "Ret�ngulo")
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

            if (cmbEscolha.SelectedItem.ToString() == "Esf�ra")
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
            //valida��es
            //Limpar lbl erro altomaticamente
            lblErro.Text = "";

            //Caso lblErro esteja em branco || Verificar se os caracteres s�o n�meros
            if (rbPerimetroRet.Checked)
            {
                string varRetAltura = (txtAltura.Text);
                string varRetLargura = (txtLargura.Text);

                if (string.IsNullOrWhiteSpace(varRetAltura) || varRetAltura.All(char.IsNumber))
                {
                    lblErro.Text = "Insira um valor v�lido";
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
