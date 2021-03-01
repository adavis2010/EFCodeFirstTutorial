using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCodeFirstTutorial.Migrations
{
    public partial class F : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Customers_CustomerId",
                table: "Orderlines");

            migrationBuilder.DropIndex(
                name: "IX_Orderlines_CustomerId",
                table: "Orderlines");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orderlines");

            migrationBuilder.CreateIndex(
                name: "IX_Orderlines_ItemId",
                table: "Orderlines",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orderlines_OrderId",
                table: "Orderlines",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Items_ItemId",
                table: "Orderlines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Orders_OrderId",
                table: "Orderlines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Items_ItemId",
                table: "Orderlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderlines_Orders_OrderId",
                table: "Orderlines");

            migrationBuilder.DropIndex(
                name: "IX_Orderlines_ItemId",
                table: "Orderlines");

            migrationBuilder.DropIndex(
                name: "IX_Orderlines_OrderId",
                table: "Orderlines");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Orderlines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orderlines_CustomerId",
                table: "Orderlines",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderlines_Customers_CustomerId",
                table: "Orderlines",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
