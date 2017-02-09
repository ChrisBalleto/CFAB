namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workingOnDateModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dates", "Posting_Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dates", "Posting_Date", c => c.DateTime(nullable: false));
        }
    }
}
