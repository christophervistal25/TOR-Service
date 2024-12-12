using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMunicipalSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73343e09-05f2-4bd6-a8d6-f5fa7d97de43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84282cae-a3ab-400a-92aa-0294de073550");

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 15, 23, 188, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ea5aec6c-735b-40ef-bce5-595a35a58428", null, "User", "USER" },
                    { "f34a28f0-f723-4290-b7f9-861acf73619a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Contact", "Email", "Name", "Province" },
                values: new object[,]
                {
                    { 1, "", "", "Carrascal", "Surigao del Sur" },
                    { 2, "", "", "Cantilan", "Surigao del Sur" },
                    { 3, "", "", "Madrid", "Surigao del Sur" },
                    { 4, "", "", "Carmen", "Surigao del Sur" },
                    { 5, "", "", "Lanuza", "Surigao del Sur" },
                    { 6, "", "", "Cortes", "Surigao del Sur" },
                    { 7, "", "", "Tandag City", "Surigao del Sur" },
                    { 8, "", "", "Tago", "Surigao del Sur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea5aec6c-735b-40ef-bce5-595a35a58428");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f34a28f0-f723-4290-b7f9-861acf73619a");

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 12, 45, 704, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73343e09-05f2-4bd6-a8d6-f5fa7d97de43", null, "User", "USER" },
                    { "84282cae-a3ab-400a-92aa-0294de073550", null, "Admin", "ADMIN" }
                });
        }
    }
}
