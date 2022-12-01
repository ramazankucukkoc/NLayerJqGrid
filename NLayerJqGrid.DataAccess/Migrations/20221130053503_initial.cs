using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerJqGrid.DataAccess.Migrations
{
	public partial class initial : Migration
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
					Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
				name: "Companies",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					CompanyName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
					DepartmanName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
					Manager = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
					CompanyPhone = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false),
					ManagerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
					City = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
					County = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Companies", x => x.Id);
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
				name: "Departmens",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					DepartmanName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Departmens", x => x.Id);
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
					Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
				name: "Personels",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					PersonelName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
					LastName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
					DepartmanId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Personels", x => x.Id);
					table.ForeignKey(
						name: "FK_Personels_Departmens_DepartmanId",
						column: x => x.DepartmanId,
						principalTable: "Departmens",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "CompanyTransactions",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ProductId = table.Column<int>(type: "int", nullable: false),
					CompanyId = table.Column<int>(type: "int", nullable: false),
					PersonelId = table.Column<int>(type: "int", nullable: false),
					Unit = table.Column<int>(type: "int", nullable: false),
					UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					TotalPrice = table.Column<int>(type: "int", nullable: false),
					Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_CompanyTransactions", x => x.Id);
					table.ForeignKey(
						name: "FK_CompanyTransactions_Companies_CompanyId",
						column: x => x.CompanyId,
						principalTable: "Companies",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CompanyTransactions_Personels_PersonelId",
						column: x => x.PersonelId,
						principalTable: "Personels",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CompanyTransactions_Products_ProductId",
						column: x => x.ProductId,
						principalSchema: "NLayer",
						principalTable: "Products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "CustomerTransactions",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					ProductId = table.Column<int>(type: "int", nullable: false),
					CustomerId = table.Column<int>(type: "int", nullable: false),
					PersonelId = table.Column<int>(type: "int", nullable: false),
					Unit = table.Column<int>(type: "int", nullable: false),
					UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					TotalPrice = table.Column<int>(type: "int", nullable: false),
					Description = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_CustomerTransactions", x => x.Id);
					table.ForeignKey(
						name: "FK_CustomerTransactions_Customers_CustomerId",
						column: x => x.CustomerId,
						principalTable: "Customers",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CustomerTransactions_Personels_PersonelId",
						column: x => x.PersonelId,
						principalTable: "Personels",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_CustomerTransactions_Products_ProductId",
						column: x => x.ProductId,
						principalSchema: "NLayer",
						principalTable: "Products",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.InsertData(
				table: "AspNetRoles",
				columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
				values: new object[,]
				{
					{ 1, "e0951ffa-f36e-463c-9498-5f99ef2d7646", "Admin", "ADMIN" },
					{ 2, "a7c5ec4a-9865-4305-8373-086fe8e2ec01", "Editor", "EDITOR" }
				});

			migrationBuilder.InsertData(
				table: "AspNetUsers",
				columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
				values: new object[,]
				{
					{ 1, 0, "f5726388-2cfd-4cdf-9b34-8b2106224c65", "adminuser@gmail.com", true, false, null, "ADMINUSER@GMAİL.COM", "ADMINUSER", "AQAAAAEAACcQAAAAEBlzV6WlvHWwCgZHuTjrNAtU7kSkZqz5HnHUcxKj906opQjBiXH2IKVunGAWKyoCLw==", "+905555555555", true, "defaultUser.png", "b7945f50-e469-4fae-a6cc-c307f66cb46d", false, "adminuser" },
					{ 2, 0, "a8b97276-7d7a-4456-8227-01826f2cba5d", "editoruser@gmail.com", true, false, null, "EDITORUSER@GMAİL.COM", "EDITORUSER", null, "+905555555555", true, "defaultUser.png", "62d69529-61c9-4642-9586-06f24584d92c", false, "editoruser" }
				});

			migrationBuilder.InsertData(
				schema: "NLayer",
				table: "Categories",
				columns: new[] { "Id", "CategoryName", "CreatedByName", "CreatedDate", "Description", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note" },
				values: new object[,]
				{
					{ 1, "Cheese", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5423), "Kategori Bir", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5429), "Not girilmedi" },
					{ 2, "Meat", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5431), "Kategori İki", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5432), "Not girilmedi" },
					{ 3, "Fish", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5433), "Kategori Üç", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5434), "Not girilmedi" },
					{ 4, "Bread", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5435), "Kategori Dört", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(5436), "Not girilmedi" }
				});

			migrationBuilder.InsertData(
				table: "Companies",
				columns: new[] { "Id", "City", "CompanyName", "CompanyPhone", "County", "CreatedByName", "CreatedDate", "DepartmanName", "IsDeleted", "Manager", "ManagerPhone", "ModifiedByName", "ModifiedDate", "Note" },
				values: new object[,]
				{
					{ 1, "Istanbul", "Koç", "+905436251369", "Kartal", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(2756), "CEO", false, "Ramazan K.KOÇ", "+905436251369", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(2768), "Ramazan K.KOÇ Şirketin CEO'sudur." },
					{ 2, "Ankara", "Saran", "+905436251368", "Cumhur", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(2774), "CEO", false, "Mehmet K.KOÇ", "+905436251369", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(2775), "Mehmet K.KOÇ Şirketin CEO'sudur." }
				});

			migrationBuilder.InsertData(
				table: "Customers",
				columns: new[] { "Id", "Address", "City", "County", "CreatedByName", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PhoneNumber" },
				values: new object[,]
				{
					{ 1, "Fetih Mah. Aşık Nigari Sok. NO:2AB", "Konya", "Karatay", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(1505), "ramazankucukkoc43@gmail.com", "Ramazan", false, "Küçükkoç", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(1507), "Not girilmedi", "5436251369" },
					{ 2, "Sincan Mah. Aşık Nigari Sok. NO:2AB", "Ankara", "Sincan", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(1512), "alistfn06@gmail.com", "Aliş", false, "Tufan", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(1512), "Not girilmedi", "5427123456" }
				});

			migrationBuilder.InsertData(
				table: "Departmens",
				columns: new[] { "Id", "CreatedByName", "CreatedDate", "DepartmanName", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note" },
				values: new object[,]
				{
					{ 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(9340), "Müdür", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(9344), "Müdür Satış Elamanıdır." },
					{ 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(9346), "Satış Temsilcisi", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(9347), "Satış Temsilcisi İşlemleri Tamamladı." }
				});

			migrationBuilder.InsertData(
				table: "AspNetUserRoles",
				columns: new[] { "RoleId", "UserId" },
				values: new object[,]
				{
					{ 1, 1 },
					{ 2, 2 }
				});

			migrationBuilder.InsertData(
				table: "Personels",
				columns: new[] { "Id", "CreatedByName", "CreatedDate", "DepartmanId", "IsDeleted", "LastName", "ModifiedByName", "ModifiedDate", "Note", "PersonelName" },
				values: new object[,]
				{
					{ 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(3388), 1, false, "Ak", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(3393), "Not girilmedi", "Ahmet" },
					{ 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(3397), 2, false, "Kara", "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(3397), "Not girilmedi", "Mehmet" }
				});

			migrationBuilder.InsertData(
				schema: "NLayer",
				table: "Products",
				columns: new[] { "Id", "Brand", "CategoryId", "CreatedByName", "CreatedDate", "Description", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "ProdcutName", "SalesPrice", "Stock", "UnitPrice" },
				values: new object[,]
				{
					{ 1, "Bosch", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9553), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9561), "Not girilmedi", "Cheddar", 25m, (short)22, 22m },
					{ 2, "Arçelik", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9569), "Ürün Şahane", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9570), "Not girilmedi", "Brie", 25m, (short)12, 20m },
					{ 3, "Arçelik", 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9572), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9573), "Not girilmedi", "Stilton", 25m, (short)13, 12m },
					{ 4, "Arçelik", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9575), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9576), "Not girilmedi", "Cheshire", 35m, (short)21, 32m },
					{ 5, "Ugur", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9578), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9578), "Not girilmedi", "Swiss", 120m, (short)31, 100m },
					{ 6, "Ugur", 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9581), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9582), "Not girilmedi", "Gruyere", 65m, (short)10, 45m },
					{ 7, "Ugur", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9584), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9585), "Not girilmedi", "Colby", 25m, (short)100, 24m },
					{ 8, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9586), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9587), "Not girilmedi", "Mozzela", 43m, (short)34, 35m },
					{ 9, "Bosch", 3, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9589), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9590), "Not girilmedi", "Ricotta", 25m, (short)200, 20m },
					{ 10, "Profilo", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9591), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9592), "Not girilmedi", "Parmesan", 25m, (short)321, 20m },
					{ 11, "Profilo", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9594), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9594), "Not girilmedi", "Ham", 25m, (short)34, 20m },
					{ 12, "Profilo", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9596), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9597), "Not girilmedi", "Beef", 55m, (short)56, 46m },
					{ 13, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9600), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9601), "Not girilmedi", "Chicken", 95m, (short)60, 90m },
					{ 14, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9603), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9603), "Not girilmedi", "Turkey", 250m, (short)37, 200m },
					{ 15, "Bosch", 4, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9605), "Ürün Güzel", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 654, DateTimeKind.Local).AddTicks(9606), "Not girilmedi", "Prosciutto", 325m, (short)400, 321m }
				});

			migrationBuilder.InsertData(
				table: "CompanyTransactions",
				columns: new[] { "Id", "CompanyId", "CreatedByName", "CreatedDate", "Description", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PersonelId", "ProductId", "TotalPrice", "Unit", "UnitPrice" },
				values: new object[,]
				{
					{ 1, 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(9801), "Şirket Satı İşlemleri", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(9807), "Şirket için önemli satışdı.", 1, 2, 500, 5, 100m },
					{ 2, 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(9813), "Şirket Satı İşlemleri Devam Ediyor", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 652, DateTimeKind.Local).AddTicks(9814), "Şirket için önemli kar yüzdesi güzel satışdı.", 1, 5, 1500, 5, 100m }
				});

			migrationBuilder.InsertData(
				table: "CustomerTransactions",
				columns: new[] { "Id", "CreatedByName", "CreatedDate", "CustomerId", "Description", "IsDeleted", "ModifiedByName", "ModifiedDate", "Note", "PersonelId", "ProductId", "TotalPrice", "Unit", "UnitPrice" },
				values: new object[,]
				{
					{ 1, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(7201), 1, "Ürün Satısı Yapıldı.", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(7209), "Ürün Satışı Gerçekleştirdik.", 1, 1, 100, 4, 20m },
					{ 2, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(7215), 2, "Ürün Satısı Yapıldı.", false, "Ramazan KÜÇÜKKOÇ", new DateTime(2022, 11, 30, 8, 35, 2, 653, DateTimeKind.Local).AddTicks(7215), "Ürün Satışı Gerçekleştirdik.", 2, 1, 500, 10, 50m }
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
				name: "IX_CompanyTransactions_CompanyId",
				table: "CompanyTransactions",
				column: "CompanyId");

			migrationBuilder.CreateIndex(
				name: "IX_CompanyTransactions_PersonelId",
				table: "CompanyTransactions",
				column: "PersonelId");

			migrationBuilder.CreateIndex(
				name: "IX_CompanyTransactions_ProductId",
				table: "CompanyTransactions",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_CustomerTransactions_CustomerId",
				table: "CustomerTransactions",
				column: "CustomerId");

			migrationBuilder.CreateIndex(
				name: "IX_CustomerTransactions_PersonelId",
				table: "CustomerTransactions",
				column: "PersonelId");

			migrationBuilder.CreateIndex(
				name: "IX_CustomerTransactions_ProductId",
				table: "CustomerTransactions",
				column: "ProductId");

			migrationBuilder.CreateIndex(
				name: "IX_Personels_DepartmanId",
				table: "Personels",
				column: "DepartmanId");

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
				name: "CompanyTransactions");

			migrationBuilder.DropTable(
				name: "CustomerTransactions");

			migrationBuilder.DropTable(
				name: "AspNetRoles");

			migrationBuilder.DropTable(
				name: "AspNetUsers");

			migrationBuilder.DropTable(
				name: "Companies");

			migrationBuilder.DropTable(
				name: "Customers");

			migrationBuilder.DropTable(
				name: "Personels");

			migrationBuilder.DropTable(
				name: "Products",
				schema: "NLayer");

			migrationBuilder.DropTable(
				name: "Departmens");

			migrationBuilder.DropTable(
				name: "Categories",
				schema: "NLayer");
		}
	}
}
