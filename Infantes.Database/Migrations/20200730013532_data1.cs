using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infantes.Database.Migrations
{
    public partial class data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Infants",
                columns: new[] { "Id", "Birthdate", "Name", "Sex" },
                values: new object[] { 1, new DateTime(2020, 7, 30, 3, 35, 32, 152, DateTimeKind.Local).AddTicks(6661), "Nene", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Infants",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
