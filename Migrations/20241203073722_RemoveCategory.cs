using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establishments_AccomodationClassifications_AccomodationClassificationId",
                table: "Establishments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0298992d-f362-4ee2-a973-8b9c79d2b3e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cebcf750-66e1-44d8-b6b0-c1f1f5410b26");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Establishments");

            migrationBuilder.AlterColumn<int>(
                name: "AccomodationClassificationId",
                table: "Establishments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e77ba4d-17db-4967-a770-bf222453a5ff", null, "Admin", "ADMIN" },
                    { "eb442685-f6a1-45ae-ba12-0eb842cf36a7", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Establishments_AccomodationClassifications_AccomodationClassificationId",
                table: "Establishments",
                column: "AccomodationClassificationId",
                principalTable: "AccomodationClassifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establishments_AccomodationClassifications_AccomodationClassificationId",
                table: "Establishments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e77ba4d-17db-4967-a770-bf222453a5ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb442685-f6a1-45ae-ba12-0eb842cf36a7");

            migrationBuilder.AlterColumn<int>(
                name: "AccomodationClassificationId",
                table: "Establishments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Establishments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0298992d-f362-4ee2-a973-8b9c79d2b3e5", null, "User", "USER" },
                    { "cebcf750-66e1-44d8-b6b0-c1f1f5410b26", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Establishments_AccomodationClassifications_AccomodationClassificationId",
                table: "Establishments",
                column: "AccomodationClassificationId",
                principalTable: "AccomodationClassifications",
                principalColumn: "Id");
        }
    }
}
