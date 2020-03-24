using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class StartStopDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54888e6e-ba99-4a7b-87bc-9f4cb241e5b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b7d955c-731c-456a-a6c3-3cc10abd7ef5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8282c58a-dea9-4be6-b272-7af4189db898");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8282c58a-dea9-4be6-b272-7af4189db898", "e179cb06-09d3-46af-b7bb-c918c9647120", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54888e6e-ba99-4a7b-87bc-9f4cb241e5b8", "b8045c8e-624f-4029-b3fb-3996fe75bb38", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b7d955c-731c-456a-a6c3-3cc10abd7ef5", "1ec78429-4ff5-46b0-97ea-39a7c7304f58", "Customer", "CUSTOMER" });
        }
    }
}
