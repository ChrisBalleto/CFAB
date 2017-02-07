namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeddateprices : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT DatePrices ON INSERT INTO DatePrices(Id, DatePriceRange) VALUES (1, 'Free')");
            Sql("SET IDENTITY_INSERT DatePrices ON INSERT INTO DatePrices(Id, DatePriceRange) VALUES (2, 'Cheap')");
            Sql("SET IDENTITY_INSERT DatePrices ON INSERT INTO DatePrices(Id, DatePriceRange) VALUES (3, 'Moderate')");
            Sql("SET IDENTITY_INSERT DatePrices ON INSERT INTO DatePrices(Id, DatePriceRange) VALUES (4, 'Pricey')");
            Sql("SET IDENTITY_INSERT DatePrices ON INSERT INTO DatePrices(Id, DatePriceRange) VALUES (5, 'High Roller')");
        }
        
        public override void Down()
        {
        }
    }
}
