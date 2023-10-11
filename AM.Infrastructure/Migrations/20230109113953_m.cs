using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CIN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "Bouquets",
                columns: table => new
                {
                    BouquetCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccompagningMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BouquetType = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "date", nullable: false),
                    CustomerCIN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bouquets", x => x.BouquetCode);
                    table.ForeignKey(
                        name: "FK_Bouquets_Customers_CustomerCIN",
                        column: x => x.CustomerCIN,
                        principalTable: "Customers",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    FlowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    BouquetFK = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "date", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Savage = table.Column<bool>(type: "bit", nullable: true),
                    Season = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.FlowerId);
                    table.ForeignKey(
                        name: "FK_Flowers_Bouquets_BouquetFK",
                        column: x => x.BouquetFK,
                        principalTable: "Bouquets",
                        principalColumn: "BouquetCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bouquets_CustomerCIN",
                table: "Bouquets",
                column: "CustomerCIN");

            migrationBuilder.CreateIndex(
                name: "IX_Flowers_BouquetFK",
                table: "Flowers",
                column: "BouquetFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flowers");

            migrationBuilder.DropTable(
                name: "Bouquets");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
