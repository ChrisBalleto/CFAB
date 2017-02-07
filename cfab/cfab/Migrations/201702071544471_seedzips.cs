namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedzips : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zipcodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZipCodeNum = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Dates", "StreetOne", c => c.String());
            AddColumn("dbo.Dates", "StreetTwo", c => c.String());
            AddColumn("dbo.Dates", "ZipcodeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dates", "ZipcodeId");
            AddForeignKey("dbo.Dates", "ZipcodeId", "dbo.Zipcodes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dates", "ZipcodeId", "dbo.Zipcodes");
            DropIndex("dbo.Dates", new[] { "ZipcodeId" });
            DropColumn("dbo.Dates", "ZipcodeId");
            DropColumn("dbo.Dates", "StreetTwo");
            DropColumn("dbo.Dates", "StreetOne");
            DropTable("dbo.Zipcodes");
        }
    }
}
