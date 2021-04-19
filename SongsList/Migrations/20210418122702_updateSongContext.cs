using Microsoft.EntityFrameworkCore.Migrations;

namespace SongsList.Migrations
{
    public partial class updateSongContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[] { "P", "Pop" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "Name", "Rating", "Year" },
                values: new object[] { 4, "R", "Lose Yourself", 2, 2000 });

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3,
                columns: new[] { "GenreId", "Name", "Rating", "Year" },
                values: new object[] { "P", "Three", 5, 2010 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: "P");

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "GenreId", "Name", "Rating", "Year" },
                values: new object[] { 3, "R", "Lose Yourself", 2, 2000 });
        }
    }
}
