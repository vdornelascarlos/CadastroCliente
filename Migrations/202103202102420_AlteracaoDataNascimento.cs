namespace CadastroCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoDataNascimento : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "DataDeNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "DataDeNascimento", c => c.String());
        }
    }
}
