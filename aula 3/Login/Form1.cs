namespace Login
{
    public partial class FormLogin : Form
    {
        //Criação de listas
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" }; //Usuarios
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" }; //Senhas

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text; //Armazenar texto na vairiável usuarioBuscado
            string senha = textBoxSenha.Text; //Armazenar texto na vairiável senha

            if (string.IsNullOrWhiteSpace(usuarioBuscado)) // Se usuarioBuscado estiver nulo ou em branco
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!"; //A label destacada exibe uma mensagem
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "") //Se o valor de senha for nulo ou vázio
            {
                labelResultado.Text = "Senha eh obrigatoria!!!"; //Uma outra mensagem é exibida
                labelResultado.ForeColor = Color.Red;
                return;
            }

            //Percorrendo posições de dados
            int posicaoUsuarioEncontrado = -1; //Váriavel auxiliar recebe um valor
            for (int i = 0; i < listaUsuarios.Count; i++) //Loop de repetição onde i inicia como 0, recebendo +1 enquanto seu valor for menor que a quantidade de dados armazenados na listaUsuarios
            {
                if (usuarioBuscado == listaUsuarios[i]) // Se o valor de usuarioBuscado for igual á posição da listaUsuarios
                {
                    posicaoUsuarioEncontrado = i;
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuario ou Senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            

            string Novousuario = textBoxNovoUsuario.Text;
            string Novasenha = textBoxNovaSenha.Text;

            bool UsuarioEncontrado = false;

            if (string.IsNullOrWhiteSpace(Novousuario))
                {
                labelResultado2.Text = "O usuario é obrigatório";
                labelResultado2.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(Novasenha))
            {
                labelResultado2.Text = "A senha é obrigatória";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            for (int i = 0; i < listaSenhas.Count; i++) {
                if (Novousuario == listaUsuarios[i]) 
                {
                    UsuarioEncontrado|= true;
                }
            }
            if (!UsuarioEncontrado)
            {
                listaUsuarios.Add(Novousuario);
                listaSenhas.Add(Novasenha);
                labelResultado2.Text = "Usuario cadastrado com sucesso";
                labelResultado2.ForeColor = Color.Green;
            }
            else 
            {
                labelResultado2.Text = "Já existe um usuario cadastrado"
                    ;
            }

        }
    }
}
