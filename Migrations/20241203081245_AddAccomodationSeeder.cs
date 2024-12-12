using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class AddAccomodationSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e77ba4d-17db-4967-a770-bf222453a5ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb442685-f6a1-45ae-ba12-0eb842cf36a7");

            migrationBuilder.InsertData(
                table: "AccomodationClassifications",
                columns: new[] { "Id", "Code", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "HTL", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9430), "Hotel", "Active" },
                    { 2, "CON", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9430), "Condotel", "Active" },
                    { 3, "SER", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Serviced Residence", "Active" },
                    { 4, "RES", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Resort", "Active" },
                    { 5, "APA", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Apartelle", "Active" },
                    { 6, "MOT", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Motel", "Active" },
                    { 7, "PEN", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Pension House", "Active" },
                    { 8, "HSS", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Home Stay Site", "Active" },
                    { 9, "TIN", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Tourist Inn", "Active" },
                    { 10, "OTH", new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440), "Others", "Active" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73343e09-05f2-4bd6-a8d6-f5fa7d97de43", null, "User", "USER" },
                    { "84282cae-a3ab-400a-92aa-0294de073550", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73343e09-05f2-4bd6-a8d6-f5fa7d97de43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84282cae-a3ab-400a-92aa-0294de073550");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e77ba4d-17db-4967-a770-bf222453a5ff", null, "Admin", "ADMIN" },
                    { "eb442685-f6a1-45ae-ba12-0eb842cf36a7", null, "User", "USER" }
                });
        }
    }
}
