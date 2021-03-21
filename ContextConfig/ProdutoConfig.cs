﻿using CadastroCliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CadastroCliente.ContextConfig
{
    public class ProdutoConfig: EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(x =>x.Id);
            ToTable("dbo.Produtos");
        }
    }
}