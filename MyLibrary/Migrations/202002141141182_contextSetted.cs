namespace MyLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contextSetted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "AuthorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "AuthorId");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropColumn("dbo.Books", "AuthorId");
        }
    }
}
