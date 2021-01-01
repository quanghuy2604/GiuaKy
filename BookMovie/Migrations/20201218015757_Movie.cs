using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMovie.Migrations
{
    public partial class Movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatVes",
                columns: table => new
                {
                    sdt = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenrap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sove = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatVes", x => x.sdt);
                });

            migrationBuilder.CreateTable(
                name: "LichChieus",
                columns: table => new
                {
                    idLC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenphim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenrap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    giochieu = table.Column<DateTime>(type: "datetime2", nullable: false)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichChieus", x => x.idLC);
                });

            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    tenphim = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    thoiluong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.tenphim);
                });

            migrationBuilder.CreateTable(
                name: "Raps",
                columns: table => new
                {
                    tenrap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    chotrong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raps", x => x.tenrap);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatVes");

            migrationBuilder.DropTable(
                name: "LichChieus");

            migrationBuilder.DropTable(
                name: "Phims");

            migrationBuilder.DropTable(
                name: "Raps");
        }
    }
}
