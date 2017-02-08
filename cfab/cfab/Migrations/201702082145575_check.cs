namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Dates", "IsChatty");
            DropColumn("dbo.Dates", "IsActive");
            DropColumn("dbo.Dates", "IsArtsy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dates", "IsArtsy", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dates", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dates", "IsChatty", c => c.Boolean(nullable: false));
        }
    }
}
