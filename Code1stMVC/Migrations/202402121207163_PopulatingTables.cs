namespace Code1stMVC.Migrations
{
    using Code1stMVC.Models;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTables : DbMigration
    {
        public override void Up()
        {
            // Sql("INSERT INTO Authors(id, name) VALUES(1,Nikhil)");


            Sql("SET IDENTITY_INSERT Authors ON");




            // Disable identity insert for Authors table
            Sql("SET IDENTITY_INSERT Authors OFF");


            //Sql("INSERT INTO Authors(id, name) VALUES(1, 'John Doe')");
            //Sql("INSERT INTO Authors(id, name) VALUES(2, 'Jane Smith')");
            //Sql("INSERT INTO Authors(id, name) VALUES(3, 'Alice Johnson')");
            //Sql("INSERT INTO Authors(id, name) VALUES(4, 'Michael Brown')");
            //Sql("INSERT INTO Authors(id, name) VALUES(5, 'Emily Davis')");




            Sql("INSERT INTO Authors( name) VALUES('John Doe')");
            Sql("INSERT INTO Authors( name) VALUES('Jane Smith')");
            Sql("INSERT INTO Authors( name) VALUES('Alice Johnson')");
            Sql("INSERT INTO Authors( name) VALUES('Michael Brown')");
            Sql("INSERT INTO Authors( name) VALUES('Emily Davis')");

            Sql("INSERT INTO Courses( discripion, Title, Fullprice, Author_Id) VALUES('Course description 1', 'Course Title 1', 49.99, 1)");
            Sql("INSERT INTO Courses( discripion, Title, Fullprice, Author_Id) VALUES ('Course description 2', 'Course Title 2', 59.99, 2)");
            Sql("INSERT INTO Courses( discripion, Title, Fullprice, Author_Id) VALUES('Course description 3', 'Course Title 3', 69.99, 3)");
            Sql("INSERT INTO Courses( discripion, Title, Fullprice, Author_Id) VALUES( 'Course description 4', 'Course Title 4', 79.99, 4)");
            Sql("INSERT INTO Courses( discripion, Title, Fullprice, Author_Id) VALUES( 'Course description 5', 'Course Title 5', 89.99, 5)");

            Sql("INSERT INTO Tags(id, name) VALUES(1, 'Tag 1')");
            Sql("INSERT INTO Tags(id, name) VALUES(2, 'Tag 2')");
            Sql("INSERT INTO Tags(id, name) VALUES(3, 'Tag 3')");
            Sql("INSERT INTO Tags(id, name) VALUES(4, 'Tag 4')");
            Sql("INSERT INTO Tags(id, name) VALUES(5, 'Tag 5')");



        }

        public override void Down()
        {
        }
    }
}
