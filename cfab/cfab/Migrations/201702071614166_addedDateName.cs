namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDateName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dates", "DateName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dates", "DateName");
        }
    }
}
