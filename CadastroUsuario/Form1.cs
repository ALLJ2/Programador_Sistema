namespace CadastroUsuario
{
    public partial class Form1 : Form

    {
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();


            clientes.Add(new Cliente()
            {
                Nome = "Roger Guedes",
                DataNascimento = "17/07/2008",
                Telefone = "9999-9999",

                en = new EnderecoCliente()
                {
                    Logradouro = "",
                    Complemento = "",
                    Bairro = "Rua sem asfalto",
                    Numero = "13",
                    Munucipio = "Monguagua",
                    Estado = "São Paulo",
                    CEP =,


                } });

        }
    }
}
