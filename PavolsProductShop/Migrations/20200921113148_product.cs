using Microsoft.EntityFrameworkCore.Migrations;

namespace PavolsProductShop.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "Code",
                value: "Halloween_Orange");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "Code",
                value: "Halloween Orange");
        }
    }
}
