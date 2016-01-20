namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Isbn", c => c.String());
            DropColumn("dbo.Books", "Isdn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Isdn", c => c.String());
            DropColumn("dbo.Books", "Isbn");
        }
    }
}
