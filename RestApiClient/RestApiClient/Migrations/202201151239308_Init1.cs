namespace WebAppAspNetMvcIdentity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticlesEvents",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Provider = c.String(nullable: false),
                        News_Id = c.Int(),
                        News_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.News", t => t.News_Id)
                .ForeignKey("dbo.News", t => t.News_Id1)
                .Index(t => t.News_Id)
                .Index(t => t.News_Id1);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Featured = c.Boolean(),
                        Title = c.String(nullable: false),
                        Url = c.String(nullable: false),
                        ImageUrl = c.String(),
                        NewsSite = c.String(nullable: false),
                        Summary = c.String(),
                        PublishedAt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArticlesEvents", "News_Id1", "dbo.News");
            DropForeignKey("dbo.ArticlesEvents", "News_Id", "dbo.News");
            DropIndex("dbo.ArticlesEvents", new[] { "News_Id1" });
            DropIndex("dbo.ArticlesEvents", new[] { "News_Id" });
            DropTable("dbo.News");
            DropTable("dbo.ArticlesEvents");
        }
    }
}
