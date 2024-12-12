using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class AddContactNumberAndEmailInMunicipality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea5aec6c-735b-40ef-bce5-595a35a58428");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f34a28f0-f723-4290-b7f9-861acf73619a");

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

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "carrascal@gmai..com" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "cantilan@gmai..com" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "madrid@gmai..com" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "carmen@gmai..com" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "lanuza@gmai..com" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "cortes@gmai..com" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "tandag@gmai..com" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "09123456789", "tago@gmai..com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Contact", "Email" },
                values: new object[] { "", "" });
        }
    }
}
