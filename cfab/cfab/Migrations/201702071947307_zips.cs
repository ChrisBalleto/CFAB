namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zips : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dates", "willEat", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dates", "willEat");
        }
    }
}
