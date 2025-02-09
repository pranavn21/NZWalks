using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations.NZWalksAuthDb
{
    /// <inheritdoc />
    public partial class @fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "443a4473-0a14-40d7-8f25-2f56c5a5edc6", "443a4473-0a14-40d7-8f25-2f56c5a5edc6", "Reader", "READER" },
                    { "7358c7e1-db4d-4406-8cf6-72f363921202", "7358c7e1-db4d-4406-8cf6-72f363921202", "Writer", "WRITER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "443a4473-0a14-40d7-8f25-2f56c5a5edc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7358c7e1-db4d-4406-8cf6-72f363921202");
        }
    }
}
