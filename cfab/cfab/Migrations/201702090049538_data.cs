namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dates", "Posting_Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dates", "Posting_Date");
        }
    }
}
