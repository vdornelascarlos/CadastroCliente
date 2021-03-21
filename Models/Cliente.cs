using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string EndereçoDeEmail { get; set; }
        public DateTime DataDeNascimento { get; set; }

    }
}