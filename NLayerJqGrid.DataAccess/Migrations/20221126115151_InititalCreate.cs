using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerJqGrid.DataAccess.Migrations
{
    public partial class InititalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "NLayer");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    County = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                schema: "NLayer",
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedByName", "CreatedDate", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note" },
                values: new object[,]
                {
                    { 1, "Cheese", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5927), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5928), "Not girilmedi" },
                    { 2, "Meat", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5930), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5930), "Not girilmedi" },
                    { 3, "Fish", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5932), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5932), "Not girilmedi" },
                    { 4, "Bread", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5933), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5934), "Not girilmedi" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "County", "CreatedByName", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Fetih Mah. Aşık Nigari Sok. NO:2AB", "Konya", "Karatay", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4970), "ramazankucukkoc43@gmail.com", "Ramazan", false, "Küçükkoç", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4986), "Not girilmedi", "5436251369" },
                    { 2, "Sincan Mah. Aşık Nigari Sok. NO:2AB", "Ankara", "Sincan", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4995), "alistfn06@gmail.com", "Aliş", false, "Tufan", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4996), "Not girilmedi", "5427123456" }
                });

            migrationBuilder.InsertData(
                schema: "NLayer",
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedByName", "CreatedDate", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProdcutName", "SalesPrice", "Stock", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Bosch", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8382), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8386), "Not girilmedi", "Cheddar", 25m, (short)22, 22m },
                    { 2, "Bosch", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8394), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8395), "Not girilmedi", "Brie", 25m, (short)12, 20m },
                    { 3, "Bosch", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8397), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8397), "Not girilmedi", "Stilton", 25m, (short)13, 12m },
                    { 4, "Bosch", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8399), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8399), "Not girilmedi", "Cheshire", 35m, (short)21, 32m },
                    { 5, "Bosch", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8401), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8401), "Not girilmedi", "Swiss", 120m, (short)31, 100m },
                    { 6, "Bosch", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8403), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8403), "Not girilmedi", "Gruyere", 65m, (short)10, 45m },
                    { 7, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8404), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8405), "Not girilmedi", "Colby", 25m, (short)100, 24m },
                    { 8, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8408), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8409), "Not girilmedi", "Mozzela", 43m, (short)34, 35m },
                    { 9, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8410), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8411), "Not girilmedi", "Ricotta", 25m, (short)200, 20m },
                    { 10, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8412), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8412), "Not girilmedi", "Parmesan", 25m, (short)321, 20m },
                    { 11, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8414), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8414), "Not girilmedi", "Ham", 25m, (short)34, 20m },
                    { 12, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8416), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8416), "Not girilmedi", "Beef", 55m, (short)56, 46m },
                    { 13, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8418), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8418), "Not girilmedi", "Chicken", 95m, (short)60, 90m },
                    { 14, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8420), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8421), "Not girilmedi", "Turkey", 250m, (short)37, 200m },
                    { 15, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8422), false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8423), "Not girilmedi", "Prosciutto", 325m, (short)400, 321m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "NLayer",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "NLayer");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "NLayer");
        }
    }
}
