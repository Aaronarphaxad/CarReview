using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReviewApp.Migrations
{
    /// <inheritdoc />
    public partial class CarReviewNewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b9518de8-70c5-423d-a40b-082a4ae2ebce"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b9c26313-dff3-49d3-95e1-65fab7481537"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "Country", "Mileage", "Model", "OwnerId", "Price", "Rating", "Year" },
                values: new object[,]
                {
                    { new Guid("2d867b1d-4dbe-4040-a4f0-9b3b007d1dc9"), "Toyota", "Silver", "Japan", "105", "Corolla", null, 8000, 4, 2007 },
                    { new Guid("67e16060-1b81-4690-aa7e-82f14dbb4429"), "Nissan", "Red", "Japan", "100", "Bluebird", null, 5000, 3, 2004 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2d867b1d-4dbe-4040-a4f0-9b3b007d1dc9"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("67e16060-1b81-4690-aa7e-82f14dbb4429"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "Country", "Mileage", "Model", "OwnerId", "Price", "Rating", "Year" },
                values: new object[,]
                {
                    { new Guid("b9518de8-70c5-423d-a40b-082a4ae2ebce"), "Toyota", "Silver", "Japan", "105", "Corolla", null, 8000, 4, 2007 },
                    { new Guid("b9c26313-dff3-49d3-95e1-65fab7481537"), "Nissan", "Red", "Japan", "100", "Bluebird", null, 5000, 3, 2004 }
                });
        }
    }
}
