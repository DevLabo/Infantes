using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infantes.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Perimeter = table.Column<decimal>(nullable: true),
                    Length = table.Column<decimal>(nullable: true),
                    Weight = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infants");
        }
    }
}
