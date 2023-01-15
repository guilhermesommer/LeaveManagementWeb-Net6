using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed0adcc-5947-4a0b-9dad-e00b326e1c42",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621bf487-6731-494e-8e7d-5d5b045c9180",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d908aea0-e35f-4272-b86e-650170d5ec1a", "AQAAAAIAAYagAAAAEL4spnRABlITwNh3D4zwcY6bFwy1ur30nbnOKdbzKOB0tQpH+bnHJQVGVeELTQsPoA==", "ccfdba3c-3526-4d53-aac4-45c03f6144b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1be9d8-c475-446e-8206-876ca9a17bfb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23288686-a68e-4a2e-8888-79e6668d46bb", "AQAAAAIAAYagAAAAEFEjyFJtZsvaxhNMww+ovsi/pSyrfr8jnObv0K+qPvGRndbQBDhRXDTEELqusbgF7g==", "5e5d02ec-29cd-4f93-b254-0ee2afec8732" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
