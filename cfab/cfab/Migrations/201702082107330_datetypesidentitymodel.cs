namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetypesidentitymodel : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT DateTypes ON INSERT INTO DateTypes(Id, DateTypeName) VALUES (1, 'Chatty')");
            Sql("SET IDENTITY_INSERT DateTypes ON INSERT INTO DateTypes(Id, DateTypeName) VALUES (2, 'Active')");
            Sql("SET IDENTITY_INSERT DateTypes ON INSERT INTO DateTypes(Id, DateTypeName) VALUES (3, 'Artsy')");
        }
        
        public override void Down()
        {
        }
    }
}
