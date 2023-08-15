using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace puppiesApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Puppies",
                columns: new[] { "id", "breed", "created_at", "name" },
                values: new object[,]
                {
                    { -7, "Yorkshire Terrier", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luna" },
                    { -6, "Rottweiler", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daisy" },
                    { -5, "Poodle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo" },
                    { -4, "Labrador Retriever", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bella" },
                    { -3, "Bulldog", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max" },
                    { -2, "Golden Retriever", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy" },
                    { -1, "German Shepherd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Puppies",
                keyColumn: "id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Puppies",
                keyColumn: "id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Puppies",
                keyColumn: "id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Puppies",
                keyColumn: "id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Puppies",
                keyColumn: "id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Puppies",
                keyColumn: "id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Puppies",
                keyColumn: "id",
                keyValue: -1);
        }
    }
}
