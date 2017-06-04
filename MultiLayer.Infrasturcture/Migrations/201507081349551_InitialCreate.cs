namespace MultiLayer.Infrasturcture.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Posts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Content = c.String(),
                    Author_Id = c.Int(),
                    Blog_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Blog_Id);

            CreateTable(
                "dbo.Blogs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "Blog_Id" });
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropTable("dbo.Blogs");
            DropTable("dbo.Posts");
            DropTable("dbo.Authors");
        }
    }
}
