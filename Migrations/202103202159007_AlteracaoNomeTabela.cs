namespace CadastroCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoNomeTabela : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produtos", newName: "Produtoes");
        }
    }
}
