namespace CadastroUsuario
{
    public partial class Form1 : Form

    {


        List<Cliente> clientes = new List<Cliente>();

        private readonly BindingSource bindingSource = [];

        public Form1()
        {
            InitializeComponent();


            //Cliente1
            clientes.Add(new Cliente()
            {
                Nome = "Marivalda Lagos",
                DataNascimento = "17/07/2008",
                Telefone = "9999-9999",

                Endereco = new EnderecoCliente()
                {
                    Logradouro = "S�o miguel Judas",
                    Complemento = "Caverna",
                    Bairro = "Rua sem asfalto",
                    Numero = "13",
                    Munucipio = "Monguagua",
                    Estado = "S�o Paulo",
                    CEP = "0000-0000",


                },
                Etnia = Etnia.Indigena,
                Genero = GeneroCliente.Masculino,
                TipoCliente = TipoCliente.PF,
            });


            //Cliente2
            clientes.Add(new Cliente()
            {
                Nome = "Adolfo",
                DataNascimento = "17/07/1912",
                Telefone = "5555-9955",

                Endereco = new EnderecoCliente()
                {
                    Logradouro = "Austria",
                    Complemento = "Cabana",
                    Bairro = "Rua sem pessoas",
                    Numero = "55",
                    Munucipio = "S�o Paulo",
                    Estado = "S�o Paulo",
                    CEP = "1230-0000",


                },
                Etnia = Etnia.Branco,
                Genero = GeneroCliente.Masculino,
                TipoCliente = TipoCliente.PF,
            });

            bindingSource.DataSource = clientes;
            dataGridViewClientes.DataSource = bindingSource;


            //Cliente3
            clientes.Add(new Cliente()
            {
                Nome = "Ronaldinho",
                DataNascimento = "17/07/2004",
                Telefone = "9967-9999",

                Endereco = new EnderecoCliente()
                {
                    Logradouro = "Doutor paciente dos santos",
                    Complemento = "Matagal",
                    Bairro = "Rua sem esperan�a",
                    Numero = "22",
                    Munucipio = "Cubat�o",
                    Estado = "S�o Paulo",
                    CEP = "0120-0508",


                },
                Etnia = Etnia.Negro,
                Genero = GeneroCliente.Masculino,
                TipoCliente = TipoCliente.PF,
            });


        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            clientes.Add(new Cliente()
            {
                Nome = txtNome.Text,
                NomeSocial = txtNomeSocial.Text,
                DataNascimento = mtxtNascimento.Text,
                Telefone = mtxtTelefone.Text,
                Email = mtxtTelefone.Text,
                Estrangeiro = cbExtrangeiro.Checked,
                Endereco = new EnderecoCliente()
                {
                    Logradouro = txtLogradouro.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text,
                    Bairro = txtBairro.Text,
                    Municipio = txtMunicipio.Text,
                    CEP = mtxtCEP.Text,
                }

            });

            //Definindo erro padr�o de prenchimento de textboxes, exceto os n�o-obrigat�rios 


            //Capturando textBoxes e fazendo valida��o de prenchimento


            //Fazer valida��o de telefone
            //Ter entre 10 e 11 digitos
            //n�o ter simbolos ou espa�os


            //Fazer valida��o de Email
            //Precisa de uma parte que tenha letras, numeros e simbolos, outra de @(nomedoprovedor) e a ultima de .com


            //ComboBoxes
            //Genero


            //Etnia


            //Estado


            //Expecifica��es de conteudo de texboxes
            //Email n�o deve conter espa�os, mas pode ter numeros e s�mbolos, seguidos por um @, uma das op��es pr� definidas de fornecedores e um ".com"

            //Nascimento deve fazer sentido com o sistema de meses e dias, e n�o deve passar de 2025

            //Telefone precisa ter no minimo 10 e no maximo 11

            //Valida��es obrigat�rias
            //Listas com dados unicos
            //Ids

            //Email

            //Telefone


















        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Todos os campos foram limpos com sucesso!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtLogradouro.Clear();
            txtMunicipio.Clear();
            txtNomeSocial.Clear();
            mtxtTelefone.Clear();
            mtxtCEP.Clear();
            mtxtNascimento.Clear();
            rbTipoPF.Checked = false;
            rbTipoPJ.Checked = false;
            cbExtrangeiro.Checked = false;
            cmbEstado.SelectedIndex = -1;
            cmbEtnia.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
        }
    }
}




