using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class ConvertMonthlyAddOnToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2949ef4b-eae0-4a0b-84bd-5f406de7da77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "738edc2c-f9ae-4aa8-a8ff-d2e8c1d3695a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89835df1-64b8-4fac-8184-58b823b4fba9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd2a1e40-6627-4383-9bd8-6f0df0d9ce85", "59ebe2ab-3020-49b8-a877-020e2ae6fda6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80594a17-c6dd-41b9-b9b6-40439801ddfb", "20249c0b-2462-4d04-a07b-ab28de7ee9e7", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c26a90f1-c1d9-4c14-ab38-7bb841222764", "f5f384a3-5cb1-400f-9d4b-38a65c0b51da", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80594a17-c6dd-41b9-b9b6-40439801ddfb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c26a90f1-c1d9-4c14-ab38-7bb841222764");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd2a1e40-6627-4383-9bd8-6f0df0d9ce85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "738edc2c-f9ae-4aa8-a8ff-d2e8c1d3695a", "acf2f717-3030-4149-954e-680de73b35ab", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2949ef4b-eae0-4a0b-84bd-5f406de7da77", "2d5093be-74f7-4d3f-bc14-c0a77554f1de", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89835df1-64b8-4fac-8184-58b823b4fba9", "ffbebf38-ef37-42dc-ac06-33a452a99157", "Customer", "CUSTOMER" });
        }
    }
}
