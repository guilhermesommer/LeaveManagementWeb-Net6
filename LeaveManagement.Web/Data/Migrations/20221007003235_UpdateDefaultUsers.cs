using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed0adcc-5947-4a0b-9dad-e00b326e1c42",
                column: "ConcurrencyStamp",
                value: "c1fec309-df2f-474e-bedf-f752c434c34d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90",
                column: "ConcurrencyStamp",
                value: "4a88a8d3-d9a7-4727-840c-c63cb79c5c8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621bf487-6731-494e-8e7d-5d5b045c9180",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a50b0ade-934a-4eb6-822a-f03e438c59f2", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOdHj2TH3A9djWePd+JbheeQ/G0i1YhrxNLaSfx/xfQn6Yn0ZyNbolC7Pvbjb2UbsQ==", "4a590971-0f34-43b9-a864-173435c131da", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1be9d8-c475-446e-8206-876ca9a17bfb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b89fcc08-78a5-4eea-9d4f-08bf2e4fd457", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJbxAYN7ONIpqXo4eNlEoo2YhXI44KOYjgr+FqSPGxkabaq5sEtpuaOuyCjHLvGGHQ==", "d9ad4647-335e-4cd7-9636-23cdc6cde5d4", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed0adcc-5947-4a0b-9dad-e00b326e1c42",
                column: "ConcurrencyStamp",
                value: "2e438a89-ceae-4b0c-bd1a-2c8615341a35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90",
                column: "ConcurrencyStamp",
                value: "9ca2deb5-01ec-476c-9441-b7c985eca98e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621bf487-6731-494e-8e7d-5d5b045c9180",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "748f2860-73b5-48b6-ac50-807ff41070af", false, null, "AQAAAAEAACcQAAAAECoMD+uj2uMqIFdv8PfZ0YxnEJX6MKykYFE+eZfGHBQEk5Nc696FCa2fxyUDVv7cVg==", "23885dc9-12e1-4c0d-b83f-a3c3a5cf54df", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1be9d8-c475-446e-8206-876ca9a17bfb",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "23abc7bf-97da-455f-85ed-4e2d85c8546a", false, null, "AQAAAAEAACcQAAAAEDzvhuKXgOX1TgeuvRPBIwQ+7Jzg8FpwtP2rLNKtVKhB9B4c1DKa7ZA7CoeAfXgfjg==", "2d414d28-e606-4ff7-beb0-ea02e0316111", null });
        }
    }
}
