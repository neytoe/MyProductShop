using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProductShop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: false),
                    Code = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 1, "Chocolate" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 2, "Fruit Candy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 3, "Gummy Candy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 4, "Halloween Candy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 5, "Hard Candy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 1, 1, "Chocolate_Assorted", 0.20m, "Assorted Chocolate", 4.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 2, 1, "Chocolate_Mixed", 0.20m, "Chocolate Mixed Candy", 5.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 3, 1, "Chocolate_MMS", 0.20m, "M&M", 3.75m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 4, 2, "Fruit_Chewy", 0.20m, "Chewy Fruit Candy", 6.9m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 5, 2, "Fruit_Pops", 0.20m, "Fruit Lolli Pops", 2.9m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 6, 2, "Fruit_Sour", 0.20m, "Sour Fruit Candy", 4.95m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 7, 3, "Gummy_Import", 0.20m, "Imported Gummy Candy", 11.9m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 8, 3, "Gummy_Sour", 0.20m, "Gummy Sour Candy", 1.9m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 9, 3, "Gummy_Traditional", 0.20m, "Traditional Gummy Candy", 2.9m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 10, 4, "Halloween_Assorted", 0.20m, "Assorted Halloween Candy", 3.5m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 11, 4, "Halloween_Orange", 0.20m, "Halloween Orange Cones", 4.33m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 12, 4, "Halloween_Red", 0.20m, "Halloween Red Cones", 3.98m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 13, 5, "Hard_Fruit", 0.20m, "Hard Fruit Candy", 9.9m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 14, 5, "Hard_Assorted", 0.20m, "Hard Assorted Candy", 8.97m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "DiscountPercent", "Name", "Price" },
                values: new object[] { 15, 5, "Hard_Sour", 0.20m, "Sour Hard Candy", 5.55m });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
