namespace WebAppAspNetMvcIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Infoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Version = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Infoes");
        }
    }
}
