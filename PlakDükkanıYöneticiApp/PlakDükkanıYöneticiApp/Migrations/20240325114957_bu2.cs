using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakDükkanıYöneticiApp.Migrations
{
    /// <inheritdoc />
    public partial class bu2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sanatcis",
                columns: new[] { "Id", "AlbumSanatcısı" },
                values: new object[,]
                {
                    { 1, "Hadise" },
                    { 2, "Tarkan" },
                    { 3, "Azer Bülbül" },
                    { 4, "Rihanna" },
                    { 5, "Lady Gaga" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
