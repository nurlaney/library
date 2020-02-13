namespace MyLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnonsSet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Authors", "Surname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Books", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Surname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Genres", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.OrderItems", "OrderDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderItems", "OrderDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Surname", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Books", "Name", c => c.String());
            AlterColumn("dbo.Authors", "Surname", c => c.String());
            AlterColumn("dbo.Authors", "Name", c => c.String());
        }
    }
}
