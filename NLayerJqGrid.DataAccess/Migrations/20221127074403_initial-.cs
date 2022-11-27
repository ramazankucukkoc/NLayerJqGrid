using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayerJqGrid.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3633), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3639), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3641), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2110), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6722), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6733), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6737), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6739), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6741), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6741) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6742), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6744), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6748), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6754), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6758), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6762), new DateTime(2022, 11, 27, 10, 44, 2, 813, DateTimeKind.Local).AddTicks(6763) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5927), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5932), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5933), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4970), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4995), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8382), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8394), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8397), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8399), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8401), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8404), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8408), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8412), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8414), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8416), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8418), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                schema: "NLayer",
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8422), new DateTime(2022, 11, 26, 14, 51, 51, 302, DateTimeKind.Local).AddTicks(8423) });
        }
    }
}
