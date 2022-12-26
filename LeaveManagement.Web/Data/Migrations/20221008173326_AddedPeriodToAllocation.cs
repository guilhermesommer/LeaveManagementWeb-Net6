using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed0adcc-5947-4a0b-9dad-e00b326e1c42",
                column: "ConcurrencyStamp",
                value: "53b73244-7bb4-4e32-82cb-17cd7a9368e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90",
                column: "ConcurrencyStamp",
                value: "3e62b104-538e-414b-b661-0078f176cf15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621bf487-6731-494e-8e7d-5d5b045c9180",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "916cceee-a590-4241-aaa8-acda9aaef7d0", "AQAAAAEAACcQAAAAEKwsNhSewr2d427DMLz2oFXaDZYxuDymq/bZTjPBbhk7hNsbXxD+iqoSJiDktczVuQ==", "97191bbf-241f-4951-9a1f-aa135379f17d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1be9d8-c475-446e-8206-876ca9a17bfb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffa41336-2b80-4efe-967a-321fb827df6f", "AQAAAAEAACcQAAAAEDMyYKz95RSCqjxlatVXpW9KUYjVvJXc9oCRcpMXZIpVYTDg42RNdEGKumZ3n5sEGQ==", "054b0a00-f0db-41e4-9ab1-eca4a4be1ffe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a50b0ade-934a-4eb6-822a-f03e438c59f2", "AQAAAAEAACcQAAAAEOdHj2TH3A9djWePd+JbheeQ/G0i1YhrxNLaSfx/xfQn6Yn0ZyNbolC7Pvbjb2UbsQ==", "4a590971-0f34-43b9-a864-173435c131da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1be9d8-c475-446e-8206-876ca9a17bfb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89fcc08-78a5-4eea-9d4f-08bf2e4fd457", "AQAAAAEAACcQAAAAEJbxAYN7ONIpqXo4eNlEoo2YhXI44KOYjgr+FqSPGxkabaq5sEtpuaOuyCjHLvGGHQ==", "d9ad4647-335e-4cd7-9636-23cdc6cde5d4" });
        }
    }
}
