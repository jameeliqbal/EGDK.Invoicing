using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGDK.Invoicing.Data.Migrations
{
    /// <inheritdoc />
    public partial class InvoiceLineItemFieldProductIdFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdcutId",
                table: "LineItems",
                newName: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "LineItems",
                newName: "ProdcutId");
        }
    }
}
