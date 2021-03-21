using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CadastroCliente.ContextConfig
{
    public class ClienteConfig: EntityTypeConfiguration <Cliente>
    {
        public ClienteConfig()
        {
            HasKey(x => x.Id);
        }
    }
}