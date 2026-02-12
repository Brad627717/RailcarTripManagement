using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailcarTrip.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Railcars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "CCAR1111");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Railcars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "CCar1111");
        }
    }
}
