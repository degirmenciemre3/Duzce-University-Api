using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DuzceUniversityWebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "duyurulars",
                columns: table => new
                {
                    Id = table.Column<double>(type: "float", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KisaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_duyurulars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "duyurulars");
        }
    }
}
