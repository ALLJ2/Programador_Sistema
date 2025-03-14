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
            if (cmbEscolha.SelectedItem == null)
            {
                lblErro.Text = "Selecione uma opção";
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
