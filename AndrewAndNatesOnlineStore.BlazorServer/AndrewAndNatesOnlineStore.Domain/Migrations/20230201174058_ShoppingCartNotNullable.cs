using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndrewAndNatesOnlineStore.Domain.Migrations
{
    /// <inheritdoc />
    public partial class ShoppingCartNotNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Customer_CustomerId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CustomerId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Shopppingcart",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shopppingcart",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomerId",
                table: "Product",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Customer_CustomerId",
                table: "Product",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId");
        }
    }
}
