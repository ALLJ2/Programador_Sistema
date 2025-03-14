namespace calculoTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int lado1 = Convert.ToInt32(txtLado1.Text);
            int lado2 = Convert.ToInt32(txtLado2.Text);

            //Operação área
            int resultado = lado1 * lado2;
            lblResultado.Text = resultado.ToString();


            // retângulo = quatro lados com 2 pares com medidas iguais 
        }

        private void linkForms2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }



    }

}
    
