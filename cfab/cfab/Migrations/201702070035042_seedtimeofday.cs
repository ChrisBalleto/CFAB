namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedtimeofday : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT DateTimeOfDays ON INSERT INTO DateTimeOfDays(Id, DateTimeOfDayType) VALUES (1, 'Morning')");
            Sql("SET IDENTITY_INSERT DateTimeOfDays ON INSERT INTO DateTimeOfDays(Id, DateTimeOfDayType) VALUES (2, 'Afternoon')");
            Sql("SET IDENTITY_INSERT DateTimeOfDays ON INSERT INTO DateTimeOfDays(Id, DateTimeOfDayType) VALUES (3, 'Evening')");
            Sql("SET IDENTITY_INSERT DateTimeOfDays ON INSERT INTO DateTimeOfDays(Id, DateTimeOfDayType) VALUES (4, 'Late Evening')");
        }
        
        public override void Down()
        {
        }
    }
}
