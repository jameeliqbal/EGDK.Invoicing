using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGDK.Invoicing.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Customers (Name, Email, Address, Phone) VALUES ('CustomerOne','customer@one.com','Address of CustomerOne','1111111111')");
            migrationBuilder
                .Sql("INSERT INTO Customers (Name, Email, Address, Phone) VALUES ('CustomerTwo','customer@two.com','Address of CustomerTwo','2222222222')");
            migrationBuilder
                .Sql("INSERT INTO Customers (Name, Email, Address, Phone) VALUES ('CustomerThree','customer@three.com','Address of CustomerThree','3333333333')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Customers");
        }
    }
}
