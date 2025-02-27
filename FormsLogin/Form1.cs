namespace FormsLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "label clicada";
        }


        private void buttonAutentificar_Click(object sender, EventArgs e)
        {
            string usuario = CaixaTextUsuario.Text;
            string senha = textBoxSenha.Text;

            if (String.IsNullOrWhiteSpace(usuario))
            {
                labelResultado.Text = "Usuário é obrigatório";
                labelResultado.ForeColor = Color.Red;
                return;

            }
            else if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha obrigatória";
                labelResultado.ForeColor = Color.Red;
            }
            else if (usuario == "alexsandro" && senha == "1234")
            {
                labelResultado.Text = "Autentificado com sucesso";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuario ou senha incorretos";
                labelResultado.ForeColor = Color.Red;
            }
        }

        private void labelSenha_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "label clicada";
        }
    }
}
