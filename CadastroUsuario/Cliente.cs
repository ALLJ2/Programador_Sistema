using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario
{
    internal class Cliente
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        EnderecoCliente Endereco { get; set; }
        GeneroCliente Genero { get; set; }
        Etnia Etnia {get; set;}
        public string NomeSocial { get; set; }
        public bool Estrangeiro { get; set; }
        TipoCliente TipoCliente { get; set; }
    }
}
