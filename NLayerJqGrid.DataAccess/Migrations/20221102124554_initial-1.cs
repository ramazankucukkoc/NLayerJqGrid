using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerJqGrid.DataAccess.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "NLayer");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "NLayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "NLayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "NLayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdcutName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Brand = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Stock = table.Column<short>(type: "smallint", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "NLayer",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                schema: "NLayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "NLayer",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "NLayer",
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedByName", "CreatedDate", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, "Cheese", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8383), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8391), "Not girilmedi" },
                    { 2, "Meat", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8394), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8394), "Not girilmedi" },
                    { 3, "Fish", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8395), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8395), "Not girilmedi" },
                    { 4, "Bread", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8396), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 581, DateTimeKind.Local).AddTicks(8397), "Not girilmedi" }
                });

            migrationBuilder.InsertData(
                schema: "NLayer",
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedByName", "CreatedDate", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProdcutName", "SalesPrice", "Stock", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Bosch", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(209), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(211), "Not girilmedi", "Cheddar", 25m, (short)22, 22m },
                    { 2, "Bosch", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(215), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(215), "Not girilmedi", "Brie", 25m, (short)12, 20m },
                    { 3, "Bosch", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(217), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(217), "Not girilmedi", "Stilton", 25m, (short)13, 12m },
                    { 4, "Bosch", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(219), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(219), "Not girilmedi", "Cheshire", 35m, (short)21, 32m },
                    { 5, "Bosch", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(220), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(221), "Not girilmedi", "Swiss", 120m, (short)31, 100m },
                    { 6, "Bosch", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(222), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(222), "Not girilmedi", "Gruyere", 65m, (short)10, 45m },
                    { 7, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(223), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(224), "Not girilmedi", "Colby", 25m, (short)100, 24m },
                    { 8, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(225), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(225), "Not girilmedi", "Mozzela", 43m, (short)34, 35m },
                    { 9, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(226), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(227), "Not girilmedi", "Ricotta", 25m, (short)200, 20m },
                    { 10, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(228), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(228), "Not girilmedi", "Parmesan", 25m, (short)321, 20m },
                    { 11, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(229), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(230), "Not girilmedi", "Ham", 25m, (short)34, 20m },
                    { 12, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(231), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(231), "Not girilmedi", "Beef", 55m, (short)56, 46m },
                    { 13, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(232), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(232), "Not girilmedi", "Chicken", 95m, (short)60, 90m },
                    { 14, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(233), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(234), "Not girilmedi", "Turkey", 250m, (short)37, 200m },
                    { 15, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(235), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 2, 15, 45, 54, 582, DateTimeKind.Local).AddTicks(235), "Not girilmedi", "Prosciutto", 325m, (short)400, 321m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OperationClaims_UserId",
                schema: "NLayer",
                table: "OperationClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "NLayer",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationClaims",
                schema: "NLayer");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "NLayer");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "NLayer");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "NLayer");
        }
    }
}
