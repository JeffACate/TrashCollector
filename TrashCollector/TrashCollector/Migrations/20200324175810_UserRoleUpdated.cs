using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UserRoleUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a995320-2be5-4810-8010-23c55a653bf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f148091-871f-49f9-a485-9fe12b1d4078");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1e6bdb8-a528-453b-8bbf-a698ed04fec9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63f5608d-ee63-47bb-b28a-e19df3176a1e", "019e9155-bef1-4fe2-ac03-ae6d642dc869", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffa519d6-987c-4cf8-82b6-0c648a9d778a", "9d56beee-fa4f-4cfe-9449-0ada54ce389a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63f5608d-ee63-47bb-b28a-e19df3176a1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffa519d6-987c-4cf8-82b6-0c648a9d778a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1e6bdb8-a528-453b-8bbf-a698ed04fec9", "3c0b44da-5f47-482e-bb4b-1a4ac247db21", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a995320-2be5-4810-8010-23c55a653bf6", "68dc7747-8ddb-4524-9e54-164e1aa72c7e", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f148091-871f-49f9-a485-9fe12b1d4078", "1550ec90-9da8-4559-8b53-e880678ce1c6", "Customer", "CUSTOMER" });
        }
    }
}
