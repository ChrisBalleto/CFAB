namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetypeid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DateTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Dates", "DateTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dates", "DateTypeId");
            AddForeignKey("dbo.Dates", "DateTypeId", "dbo.DateTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dates", "DateTypeId", "dbo.DateTypes");
            DropIndex("dbo.Dates", new[] { "DateTypeId" });
            DropColumn("dbo.Dates", "DateTypeId");
            DropTable("dbo.DateTypes");
        }
    }
}
