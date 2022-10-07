using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ed0adcc-5947-4a0b-9dad-e00b326e1c42", "2e438a89-ceae-4b0c-bd1a-2c8615341a35", "User", "USER" },
                    { "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90", "9ca2deb5-01ec-476c-9441-b7c985eca98e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "621bf487-6731-494e-8e7d-5d5b045c9180", 0, "748f2860-73b5-48b6-ac50-807ff41070af", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAECoMD+uj2uMqIFdv8PfZ0YxnEJX6MKykYFE+eZfGHBQEk5Nc696FCa2fxyUDVv7cVg==", null, false, "23885dc9-12e1-4c0d-b83f-a3c3a5cf54df", null, false, null },
                    { "ad1be9d8-c475-446e-8206-876ca9a17bfb", 0, "23abc7bf-97da-455f-85ed-4e2d85c8546a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEDzvhuKXgOX1TgeuvRPBIwQ+7Jzg8FpwtP2rLNKtVKhB9B4c1DKa7ZA7CoeAfXgfjg==", null, false, "2d414d28-e606-4ff7-beb0-ea02e0316111", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90", "621bf487-6731-494e-8e7d-5d5b045c9180" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0ed0adcc-5947-4a0b-9dad-e00b326e1c42", "ad1be9d8-c475-446e-8206-876ca9a17bfb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90", "621bf487-6731-494e-8e7d-5d5b045c9180" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ed0adcc-5947-4a0b-9dad-e00b326e1c42", "ad1be9d8-c475-446e-8206-876ca9a17bfb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ed0adcc-5947-4a0b-9dad-e00b326e1c42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ebfcf3-48e8-45ca-a780-aa1c5a04aa90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621bf487-6731-494e-8e7d-5d5b045c9180");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1be9d8-c475-446e-8206-876ca9a17bfb");
        }
    }
}
