using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace librarian.API.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 1, "Jan Kowalski", 0, "", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 2, "Jan Kowalski", 0, "", new DateTime(2020, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nulla congue" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 3, "Jan Kowalski", 0, "", new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Etiam maximus" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 4, "Jan Kowalski", 0, "", new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Integer dapibus" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 5, "Jan Kowalski", 0, "", new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aliquam nec" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 6, "Jan Kowalski", 0, "", new DateTime(2015, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent luctus" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 7, "Jan Kowalski", 0, "", new DateTime(2018, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nam porttitor" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 8, "Jan Kowalski", 0, "", new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed placerat" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 9, "Jan Kowalski", 0, "", new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "In maximus" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "PhotoSrc", "ReleaseDate", "Title" },
                values: new object[] { 10, "Jan Kowalski", 0, "", new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nullam ac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
