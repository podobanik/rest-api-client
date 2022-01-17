namespace WebAppAspNetMvcIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "Url", c => c.String());
            AlterColumn("dbo.News", "ImageUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "ImageUrl", c => c.String());
            AlterColumn("dbo.News", "Url", c => c.String(nullable: false));
        }
    }
}
