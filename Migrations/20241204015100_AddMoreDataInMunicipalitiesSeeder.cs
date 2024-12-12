using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreDataInMunicipalitiesSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02701c1b-8557-4b98-b107-7a9caf12902e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "365d91de-b394-4e7f-a52d-46e5d0adce5f");

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 12, 4, 1, 51, 0, 273, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d6d48c6b-5f62-4100-988f-f9711e893a94", null, "Admin", "ADMIN" },
                    { "ff7ead4d-7c49-42e2-a20d-226f453abbf3", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Contact", "Email", "Name", "Province" },
                values: new object[,]
                {
                    { 9, "09123456789", "lingig@gmai..com", "Lingig", "Surigao del Sur" },
                    { 10, "09123456789", "tagbina@gmai..com", "Tagbina", "Surigao del Sur" },
                    { 11, "09123456789", "bislig@gmai..com", "Bislig", "Surigao del Sur" },
                    { 12, "09123456789", "marihatag@gmai..com", "Marihatag", "Surigao del Sur" },
                    { 13, "09123456789", "cagwait@gmai..com", "Cagwait", "Surigao del Sur" },
                    { 14, "09123456789", "bayabas@gmai..com", "Bayabas", "Surigao del Sur" },
                    { 15, "09123456789", "cortes@gmai..com", "Cortes", "Surigao del Sur" },
                    { 16, "09123456789", "lianga@gmai..com", "Lianga", "Surigao del Sur" },
                    { 17, "09123456789", "hinatuan@gmai..com", "Hinatuan", "Surigao del Sur" },
                    { 18, "09123456789", "carmen@gmai..com", "Carmen", "Surigao del Sur" },
                    { 19, "09123456789", "barobo@gmai..com", "Barobo", "Surigao del Sur" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6d48c6b-5f62-4100-988f-f9711e893a94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff7ead4d-7c49-42e2-a20d-226f453abbf3");

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 12, 3, 8, 17, 11, 860, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02701c1b-8557-4b98-b107-7a9caf12902e", null, "User", "USER" },
                    { "365d91de-b394-4e7f-a52d-46e5d0adce5f", null, "Admin", "ADMIN" }
                });
        }
    }
}
