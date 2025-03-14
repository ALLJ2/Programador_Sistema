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
            if (cmbEscolha.SelectedItem == null)
            {
                lblErro.Text = "Selecione uma op��o";
                return;
            }
            if (cmbEscolha.SelectedItem.ToString() == "Quadrado")
            {
                grbQuadrado.Visible = true;
                grbRetangulo.Visible = false;
                grbQuadrado.BringToFront();
                grbRetangulo.SendToBack();
                return;

            }

            if(cmbEscolha.SelectedItem.ToString() == "Retangulo")
            {
                grbRetangulo.Visible= true;
                grbQuadrado.Visible = false;
                grbRetangulo.BringToFront();
                grbQuadrado.SendToBack();
                return;

            }

        }
    }
}
