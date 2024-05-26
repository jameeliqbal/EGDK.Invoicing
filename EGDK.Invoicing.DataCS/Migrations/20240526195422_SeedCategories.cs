using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGDK.Invoicing.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Categories (Name, Description) VALUES ('CategoryOne','Description of CategoryOne')");
            migrationBuilder
                .Sql("INSERT INTO Categories (Name, Description) VALUES ('CategoryTwo','Description of CategoryTwo')");
            migrationBuilder
                .Sql("INSERT INTO Categories (Name, Description) VALUES ('CategoryThree','Description of CategoryThree')");
     
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Categories");

        }
    }
}
