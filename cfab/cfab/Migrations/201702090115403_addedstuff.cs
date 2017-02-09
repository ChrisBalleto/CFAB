namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedstuff : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Dates", "Posting_Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dates", "Posting_Date", c => c.DateTime());
        }
    }
}
