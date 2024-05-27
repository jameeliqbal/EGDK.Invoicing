using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGDK.Invoicing.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Products (Name,Description, Price, Quantity,CategoryId)" +
                " Values ('ProductOne','Description of ProductOne',100,10, (SELECT Id FROM Categories WHERE Name = 'CategoryOne'))");

            migrationBuilder
                .Sql("INSERT INTO Products (Name,Description, Price, Quantity,CategoryId)" +
                " Values ('ProductTwo','Description of ProductTwo',200,20, (SELECT Id FROM Categories WHERE Name = 'CategoryTwo'))");
            migrationBuilder
                .Sql("INSERT INTO Products (Name,Description, Price, Quantity,CategoryId)" +
                " Values ('ProductThree','Description of ProductThree',300,30, (SELECT Id FROM Categories WHERE Name = 'CategoryTwo'))");

            migrationBuilder
                .Sql("INSERT INTO Products (Name,Description, Price, Quantity,CategoryId)" +
                " Values ('ProductFour','Description of ProductFour',400,40, (SELECT Id FROM Categories WHERE Name = 'CategoryThree'))");
            migrationBuilder
                .Sql("INSERT INTO Products (Name,Description, Price, Quantity,CategoryId)" +
                " Values ('ProductFive','Description of ProductFive',500,50, (SELECT Id FROM Categories WHERE Name = 'CategoryThree'))");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Products");
        }
    }
}
