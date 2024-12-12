using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOR.API.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesForForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EstablishmentId",
                table: "AspNetUsers");

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
                keyValue: 19);

            migrationBuilder.AddColumn<string>(
                name: "AEIDCode",
                table: "Establishments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Establishments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DAE1As",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    EstablishmentId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AvailableRooms = table.Column<int>(type: "int", nullable: false),
                    AverageGuestNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageRoomOccupancyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageNumberOfGuestPerRoom = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAE1As", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DAE1As_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DAE1As_Establishments_EstablishmentId",
                        column: x => x.EstablishmentId,
                        principalTable: "Establishments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DAE1ADetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    GuestCheckedIn = table.Column<int>(type: "int", nullable: false),
                    GuestNight = table.Column<int>(type: "int", nullable: false),
                    RoomsOccupiedByGuest = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DAE1AId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAE1ADetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DAE1ADetails_DAE1As_DAE1AId",
                        column: x => x.DAE1AId,
                        principalTable: "DAE1As",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DAE1Bs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstablishmentId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedById1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DAE1AId = table.Column<int>(type: "int", nullable: false),
                    OthersUnspecified = table.Column<int>(type: "int", nullable: false),
                    NonPhilippineResidences = table.Column<int>(type: "int", nullable: false),
                    OverSeasFilipinos = table.Column<int>(type: "int", nullable: false),
                    PhilippinesResidentFilipinoNationality = table.Column<int>(type: "int", nullable: false),
                    PhilippinesResidentForeignNationality = table.Column<int>(type: "int", nullable: false),
                    TotalPhilippinesResident = table.Column<int>(type: "int", nullable: false),
                    TotalNonPhilippinesResident = table.Column<int>(type: "int", nullable: false),
                    TotalOverseasFilipinos = table.Column<int>(type: "int", nullable: false),
                    TotalGuestWithUnspecifiedResidence = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAE1Bs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DAE1Bs_AspNetUsers_CreatedById1",
                        column: x => x.CreatedById1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DAE1Bs_DAE1As_DAE1AId",
                        column: x => x.DAE1AId,
                        principalTable: "DAE1As",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DAE1Bs_Establishments_EstablishmentId",
                        column: x => x.EstablishmentId,
                        principalTable: "Establishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DAE1BDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    DAE1BId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAE1BDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DAE1BDetails_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DAE1BDetails_DAE1Bs_DAE1BId",
                        column: x => x.DAE1BId,
                        principalTable: "DAE1Bs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DAE2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomsOccupied = table.Column<int>(type: "int", nullable: false),
                    RoomsAvailableForTheMonth = table.Column<int>(type: "int", nullable: false),
                    TotalGuestNights = table.Column<int>(type: "int", nullable: false),
                    AverageMonthlyOccupancyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageLengthOfStayNights = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DAE1BId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAE2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DAE2s_DAE1Bs_DAE1BId",
                        column: x => x.DAE1BId,
                        principalTable: "DAE1Bs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DAE2VolumePerSexes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DAE2Id = table.Column<int>(type: "int", nullable: false),
                    PhilippineResidents = table.Column<int>(type: "int", nullable: false),
                    NonPhilippineForeignResidents = table.Column<int>(type: "int", nullable: false),
                    OverseasFilipinos = table.Column<int>(type: "int", nullable: false),
                    OtherUnspecifiedGuest = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAE2VolumePerSexes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DAE2VolumePerSexes_DAE2s_DAE2Id",
                        column: x => x.DAE2Id,
                        principalTable: "DAE2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "carrascal@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "cantilan@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "madrid@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "carmen@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "lanuza@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "cortes@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "tandag@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "tago@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Email",
                value: "lingig@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Email",
                value: "tagbina@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Email",
                value: "bislig@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Email",
                value: "marihatag@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "Email",
                value: "cagwait@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "Email",
                value: "bayabas@gmail.com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "Name" },
                values: new object[] { "lianga@gmail.com", "Lianga" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "Name" },
                values: new object[] { "hinatuan@gmail.com", "Hinatuan" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "Name" },
                values: new object[] { "carmen@gmail.com", "Carmen" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "Name" },
                values: new object[] { "barobo@gmail.com", "Barobo" });

            migrationBuilder.CreateIndex(
                name: "IX_Establishments_AEIDCode",
                table: "Establishments",
                column: "AEIDCode",
                unique: true,
                filter: "[AEIDCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EstablishmentId",
                table: "AspNetUsers",
                column: "EstablishmentId",
                unique: true,
                filter: "[EstablishmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1ADetails_DAE1AId",
                table: "DAE1ADetails",
                column: "DAE1AId");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1As_CreatedById",
                table: "DAE1As",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1As_EstablishmentId",
                table: "DAE1As",
                column: "EstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1BDetails_CountryId",
                table: "DAE1BDetails",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1BDetails_DAE1BId",
                table: "DAE1BDetails",
                column: "DAE1BId");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1Bs_CreatedById1",
                table: "DAE1Bs",
                column: "CreatedById1");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1Bs_DAE1AId",
                table: "DAE1Bs",
                column: "DAE1AId");

            migrationBuilder.CreateIndex(
                name: "IX_DAE1Bs_EstablishmentId",
                table: "DAE1Bs",
                column: "EstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DAE2s_DAE1BId",
                table: "DAE2s",
                column: "DAE1BId");

            migrationBuilder.CreateIndex(
                name: "IX_DAE2VolumePerSexes_DAE2Id",
                table: "DAE2VolumePerSexes",
                column: "DAE2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DAE1ADetails");

            migrationBuilder.DropTable(
                name: "DAE1BDetails");

            migrationBuilder.DropTable(
                name: "DAE2VolumePerSexes");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "DAE2s");

            migrationBuilder.DropTable(
                name: "DAE1Bs");

            migrationBuilder.DropTable(
                name: "DAE1As");

            migrationBuilder.DropIndex(
                name: "IX_Establishments_AEIDCode",
                table: "Establishments");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EstablishmentId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45a8ddee-682d-4889-b63a-87c69e2f2aa4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ccfdd7-a82a-43b3-a39b-44d3082d91a2");

            migrationBuilder.DropColumn(
                name: "AEIDCode",
                table: "Establishments");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Establishments");

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastDiv = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketCap = table.Column<long>(type: "bigint", nullable: false),
                    Purchase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockId = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id");
                });

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

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "carrascal@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "cantilan@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "madrid@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "carmen@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "lanuza@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "cortes@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "tandag@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "tago@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Email",
                value: "lingig@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Email",
                value: "tagbina@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Email",
                value: "bislig@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Email",
                value: "marihatag@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 13,
                column: "Email",
                value: "cagwait@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 14,
                column: "Email",
                value: "bayabas@gmai..com");

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Email", "Name" },
                values: new object[] { "cortes@gmai..com", "Cortes" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Email", "Name" },
                values: new object[] { "lianga@gmai..com", "Lianga" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Email", "Name" },
                values: new object[] { "hinatuan@gmai..com", "Hinatuan" });

            migrationBuilder.UpdateData(
                table: "Municipalities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Email", "Name" },
                values: new object[] { "carmen@gmai..com", "Carmen" });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Contact", "Email", "Name", "Province" },
                values: new object[] { 19, "09123456789", "barobo@gmai..com", "Barobo", "Surigao del Sur" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EstablishmentId",
                table: "AspNetUsers",
                column: "EstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_StockId",
                table: "Comment",
                column: "StockId");
        }
    }
}
