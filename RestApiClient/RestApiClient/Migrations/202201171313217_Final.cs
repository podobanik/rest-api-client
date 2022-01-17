namespace WebAppAspNetMvcIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "ImageUrl", c => c.String());
            AlterColumn("dbo.News", "Summary", c => c.String(nullable: false));
            AlterColumn("dbo.News", "PublishedAt", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "PublishedAt", c => c.String(nullable: false));
            AlterColumn("dbo.News", "Summary", c => c.String());
            AlterColumn("dbo.News", "ImageUrl", c => c.String(nullable: false));
        }
    }
}
