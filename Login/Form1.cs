namespace Login
{
    public partial class FormLogin : Form //FORMS princípal
    {
        public FormLogin() //FORMS LOGIN
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {



            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                labelResultado.Text = "Usuario obrigatorio.";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            
            if (senha == null || (string.IsNullOrWhiteSpace(senha)))
            {
                labelResultado.Text = "Senha obrigatoria.";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            
            if (usuario == "rafael.sousa" && senha == "12345")
            {
                labelResultado.Text = "Usúario autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuario ou Senha incorretos.";
                labelResultado.ForeColor = Color.Red;
            }

            //Loop de login
           int var =

            //loop de percorrer usuarios
           int varDependente = 

        }
    }
}
