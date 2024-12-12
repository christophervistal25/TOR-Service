using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeederForCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45a8ddee-682d-4889-b63a-87c69e2f2aa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ccfdd7-a82a-43b3-a39b-44d3082d91a2");

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 14, 26, 19, 368, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2412076d-5641-4922-a77e-59ccada9590d", null, "User", "USER" },
                    { "343e5eef-cb91-4a37-8b3c-ebb450c08172", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Continent", "CreatedAt", "Name", "Region" },
                values: new object[,]
                {
                    { 1, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2420), "BRUNEI", "ASEAN" },
                    { 2, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2460), "CAMBODIA", "ASEAN" },
                    { 3, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2460), "INDONESIA", "ASEAN" },
                    { 4, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2460), "LAOS", "ASEAN" },
                    { 5, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2460), "MALAYSIA", "ASEAN" },
                    { 6, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2470), "MYANMAR", "ASEAN" },
                    { 7, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2470), "SINGAPORE", "ASEAN" },
                    { 8, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2470), "THAILAND", "ASEAN" },
                    { 9, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2470), "VIETNAM", "ASEAN" },
                    { 10, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2470), "CHINA", "EAST ASIA" },
                    { 11, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2470), "HONGKONG", "EAST ASIA" },
                    { 12, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2480), "JAPAN", "EAST ASIA" },
                    { 13, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2480), "KOREA", "EAST ASIA" },
                    { 14, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2480), "TAIWAN", "EAST ASIA" },
                    { 15, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2480), "BANGLADESH", "SOUTH ASIA" },
                    { 16, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2480), "INDIA", "SOUTH ASIA" },
                    { 17, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2480), "IRAN", "SOUTH ASIA" },
                    { 18, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2480), "NEPAL", "SOUTH ASIA" },
                    { 19, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "PAKISTAN", "SOUTH ASIA" },
                    { 20, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "SRI LANKA", "SOUTH ASIA" },
                    { 21, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "BAHRAIN", "MIDDLE EAST" },
                    { 22, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "EGYPT", "MIDDLE EAST" },
                    { 23, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "ISRAEL", "MIDDLE EAST" },
                    { 24, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "JORDAN", "MIDDLE EAST" },
                    { 25, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "KUWAIT", "MIDDLE EAST" },
                    { 26, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2490), "SAUDI ARABIA", "MIDDLE EAST" },
                    { 27, "ASIA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2500), "UNITED ARAB EMIRATES", "MIDDLE EAST" },
                    { 28, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2500), "CANADA", "NORTH AMERICA" },
                    { 29, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2500), "MEXICO", "NORTH AMERICA" },
                    { 30, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2500), "USA", "NORTH AMERICA" },
                    { 31, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2500), "ARGENTINA", "SOUTH AMERICA" },
                    { 32, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2500), "BRAZIL", "SOUTH AMERICA" },
                    { 33, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2500), "COLOMBIA", "SOUTH AMERICA" },
                    { 34, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2510), "PERU", "SOUTH AMERICA" },
                    { 35, "AMERICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2510), "VENEZUELA", "SOUTH AMERICA" },
                    { 36, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "AUSTRIA", "WESTERN EUROPE" },
                    { 37, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "BELGIUM", "WESTERN EUROPE" },
                    { 38, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "FRANCE", "WESTERN EUROPE" },
                    { 39, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "GERMANY", "WESTERN EUROPE" },
                    { 40, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "LUXEMBOURG", "WESTERN EUROPE" },
                    { 41, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "NETHERLANDS", "WESTERN EUROPE" },
                    { 42, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "SWITZERLAND", "WESTERN EUROPE" },
                    { 43, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2520), "DENMARK", "NORTHERN EUROPE" },
                    { 44, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "FINLAND", "NORTHERN EUROPE" },
                    { 45, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "IRELAND", "NORTHERN EUROPE" },
                    { 46, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "NORWAY", "NORTHERN EUROPE" },
                    { 47, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "SWEDEN", "NORTHERN EUROPE" },
                    { 48, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "UNITED KINGDOM", "NORTHERN EUROPE" },
                    { 49, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "GREECE", "SOUTHERN EUROPE" },
                    { 50, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "ITALY", "SOUTHERN EUROPE" },
                    { 51, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2530), "PORTUGAL", "SOUTHERN EUROPE" },
                    { 52, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2540), "SPAIN", "SOUTHERN EUROPE" },
                    { 53, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2540), "UNION OF SERBIA AND MONTENEGRO", "SOUTHERN EUROPE" },
                    { 54, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2540), "COMMONWEALTH OF INDEPENDENT STATES", "EASTERN EUROPE" },
                    { 55, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2540), "POLAND", "EASTERN EUROPE" },
                    { 56, "EUROPE", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2540), "RUSSIA", "EASTERN EUROPE" },
                    { 57, "AUSTRALASIA/PACIFIC", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2540), "AUSTRALIA", "AUSTRALASIA/PACIFIC" },
                    { 58, "AUSTRALASIA/PACIFIC", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2540), "GUAM", "AUSTRALASIA/PACIFIC" },
                    { 59, "AUSTRALASIA/PACIFIC", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2550), "NAURU", "AUSTRALASIA/PACIFIC" },
                    { 60, "AUSTRALASIA/PACIFIC", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2550), "NEW ZEALAND", "AUSTRALASIA/PACIFIC" },
                    { 61, "AUSTRALASIA/PACIFIC", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2550), "PAPUA NEW GUINEA", "AUSTRALASIA/PACIFIC" },
                    { 62, "AFRICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2550), "NIGERIA", "AFRICA" },
                    { 63, "AFRICA", new DateTime(2024, 12, 12, 22, 26, 19, 368, DateTimeKind.Local).AddTicks(2550), "SOUTH AFRICA", "AFRICA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2412076d-5641-4922-a77e-59ccada9590d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "343e5eef-cb91-4a37-8b3c-ebb450c08172");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "AccomodationClassifications",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2024, 12, 12, 9, 8, 19, 982, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45a8ddee-682d-4889-b63a-87c69e2f2aa4", null, "Admin", "ADMIN" },
                    { "52ccfdd7-a82a-43b3-a39b-44d3082d91a2", null, "User", "USER" }
                });
        }
    }
}
