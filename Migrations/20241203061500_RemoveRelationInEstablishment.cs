using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRelationInEstablishment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccomodationClassifications_Establishments_EstablishmentId",
                table: "AccomodationClassifications");

            migrationBuilder.DropIndex(
                name: "IX_AccomodationClassifications_EstablishmentId",
                table: "AccomodationClassifications");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0284cb1a-bad2-4f6d-8410-e0e78c591fad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81c7d40-a35c-4ae2-b58f-6f59513bf576");

            migrationBuilder.DropColumn(
                name: "EstablishmentId",
                table: "AccomodationClassifications");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0298992d-f362-4ee2-a973-8b9c79d2b3e5", null, "User", "USER" },
                    { "cebcf750-66e1-44d8-b6b0-c1f1f5410b26", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Establishments_AccomodationClassificationId",
                table: "Establishments",
                column: "AccomodationClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Establishments_AccomodationClassifications_AccomodationClassificationId",
                table: "Establishments",
                column: "AccomodationClassificationId",
                principalTable: "AccomodationClassifications",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establishments_AccomodationClassifications_AccomodationClassificationId",
                table: "Establishments");

            migrationBuilder.DropIndex(
                name: "IX_Establishments_AccomodationClassificationId",
                table: "Establishments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0298992d-f362-4ee2-a973-8b9c79d2b3e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cebcf750-66e1-44d8-b6b0-c1f1f5410b26");

            migrationBuilder.AddColumn<int>(
                name: "EstablishmentId",
                table: "AccomodationClassifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0284cb1a-bad2-4f6d-8410-e0e78c591fad", null, "Admin", "ADMIN" },
                    { "f81c7d40-a35c-4ae2-b58f-6f59513bf576", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccomodationClassifications_EstablishmentId",
                table: "AccomodationClassifications",
                column: "EstablishmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AccomodationClassifications_Establishments_EstablishmentId",
                table: "AccomodationClassifications",
                column: "EstablishmentId",
                principalTable: "Establishments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
