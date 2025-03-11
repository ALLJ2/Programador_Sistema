namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt32(txtVar1.Text);
            int var2 = Convert.ToInt32(txtVar2.Text);
            int result = var1 + var2;
            Result.Text = result.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt32(txtVar1.Text);
            int var2 = Convert.ToInt32(txtVar2.Text);
            int result = var1 - var2;
            Result.Text = result.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt32(txtVar1.Text);
            int var2 = Convert.ToInt32(txtVar2.Text);
            int result = var1 * var2;
            Result.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt32(txtVar1.Text);
            int var2 = Convert.ToInt32(txtVar2.Text);
            int result = var1 / var2;
            Result.Text = result.ToString();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
