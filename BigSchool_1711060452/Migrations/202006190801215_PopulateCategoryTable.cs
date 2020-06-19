namespace BigSchool_1711060452.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'dEVELOPMENT')");

            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'bUSINESS')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
