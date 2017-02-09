namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredAddedToModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dates", "DateName", c => c.String(nullable: false));
            AlterColumn("dbo.Dates", "StreetOne", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dates", "StreetOne", c => c.String());
            AlterColumn("dbo.Dates", "DateName", c => c.String());
        }
    }
}
