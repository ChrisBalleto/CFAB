namespace cfab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class realseedzips : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (1, 53224)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (2, 53223)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (3, 53225)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (4, 53218)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (5, 53116)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (6, 53222)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (7, 53209)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (8, 53216)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (9, 53210)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (10, 53206)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (11, 53212)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (12, 53202)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (13, 53211)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (14, 53204)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (15, 53233)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (16, 53205)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (17, 53215)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (18, 53219)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (19, 53207)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (20, 53221)");
            Sql("SET IDENTITY_INSERT Zipcodes ON INSERT INTO Zipcodes(Id, ZipcodeNum) VALUES (21, 53214)");
        }
        
        public override void Down()
        {
        }
    }
}
