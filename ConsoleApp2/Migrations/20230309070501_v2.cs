using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "IdCategory", "Name" },
                values: new object[,]
                {
                    { new Guid("2fdd35fd-df4d-451d-a4ae-25fbdfd475eb"), "овощи" },
                    { new Guid("311e5b91-1622-4b8b-81f3-59da12a294a9"), "фрукты" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: new Guid("2fdd35fd-df4d-451d-a4ae-25fbdfd475eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: new Guid("311e5b91-1622-4b8b-81f3-59da12a294a9"));
        }
    }
}
