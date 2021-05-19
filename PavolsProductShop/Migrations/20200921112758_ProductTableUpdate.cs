using Microsoft.EntityFrameworkCore.Migrations;

namespace PavolsProductShop.Migrations
{
    public partial class ProductTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Code",
                value: "Chocolate_Assorted");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Code",
                value: "Chocolate_Mixed");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Code",
                value: "Chocolate_MMS");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Code",
                value: "Fruit_Chewy");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "Code",
                value: "Fruit_Pops");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "Code",
                value: "Fruit_Sour");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "Code",
                value: "Gummy_Import");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "Code",
                value: "Gummy_Sour");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "Code",
                value: "Gummy_Traditional");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "Code",
                value: "Halloween_Assorted");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "Code",
                value: "Halloween Orange");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "Code",
                value: "Halloween_Red");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "Code",
                value: "Hard_Fruit");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "Code",
                value: "Hard_Assorted");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15,
                column: "Code",
                value: "Hard_Sour");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "Code",
                value: "Chocolate_Assorted,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "Code",
                value: "Chocolate_Mixed,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "Code",
                value: "Chocolate_MMS,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "Code",
                value: "Fruit_Chewy,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "Code",
                value: "Fruit_Pops,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "Code",
                value: "Fruit_Sour,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "Code",
                value: "Gummy_Import,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "Code",
                value: "Gummy_Sour,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "Code",
                value: "Gummy_Traditional,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                column: "Code",
                value: "Halloween_Assorted,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                column: "Code",
                value: "Halloween Orange,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                column: "Code",
                value: "Halloween_Red,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                column: "Code",
                value: "Hard_Fruit,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                column: "Code",
                value: "Hard_Assorted,");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15,
                column: "Code",
                value: "Hard_Sour,");
        }
    }
}
