using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGDK.Invoicing.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInvoices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Invoices (InvoiceNumber, InvoiceDate,Total,Discount,IsDiscountInPercentage,PaymentMode,CustomerId) " +
                "VALUES ('0001','20240518 10:34:09 AM',1000,10,1,'Cash',(SELECT Id FROM Customers WHERE Name = 'CustomerOne'))");

            migrationBuilder
                .Sql("INSERT INTO Invoices (InvoiceNumber, InvoiceDate,Total,Discount,IsDiscountInPercentage,PaymentMode,CustomerId) " +
                "VALUES ('0002','20240518 10:34:09 AM',2000,20,1,'Cash',(SELECT Id FROM Customers WHERE Name = 'CustomerTwo'))");

            migrationBuilder
                .Sql("INSERT INTO Invoices (InvoiceNumber, InvoiceDate,Total,Discount,IsDiscountInPercentage,PaymentMode,CustomerId) " +
                "VALUES ('0003','20240518 10:34:09 AM',3000,500,0,'Card',(SELECT Id FROM Customers WHERE Name = 'CustomerThree'))");


            migrationBuilder
                .Sql("INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) " +
                "VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0001'),(SELECT Id FROM Products WHERE Name='ProductOne'))");

            migrationBuilder
                .Sql("INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) " +
                "VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0002'),(SELECT Id FROM Products WHERE Name='ProductOne'))");
            migrationBuilder
                .Sql("INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) " +
                "VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0002'),(SELECT Id FROM Products WHERE Name='ProductTwo'))");

            migrationBuilder
                .Sql("INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) " +
                "VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0003'),(SELECT Id FROM Products WHERE Name='ProductOne'))");
            migrationBuilder
                .Sql("INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) " +
                "VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0003'),(SELECT Id FROM Products WHERE Name='ProductTwo'))");
            migrationBuilder
                .Sql("INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) " +
                "VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0003'),(SELECT Id FROM Products WHERE Name='ProductThree'))");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("REMOVE FROM LineItems");

            migrationBuilder
                .Sql("REMOVE FROM Invoices");
        }
    }
}
