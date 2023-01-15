using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621bf487-6731-494e-8e7d-5d5b045c9180",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64f29c18-b5dd-43a9-933e-a4e5fab2ee68", "AQAAAAIAAYagAAAAEMfW9M43az8H6Ju9NnF2rUgb6FF+BJwQIzFNiQtnMSE679uhfq1MKnLUisdUq8qZBQ==", "222d9595-6585-4977-8ff6-17d1efd3a196" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1be9d8-c475-446e-8206-876ca9a17bfb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "733e1045-8d24-47b0-97a1-fb2351225bbc", "AQAAAAIAAYagAAAAEK3VchuIA8Nxv+eQyVm/14ARj/+Vstuk5yfJeX61o94BaEs/drI7vfRXfHxwwMsa2w==", "f254f9ec-0a1a-4c50-850d-29fee2fcbaf4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
