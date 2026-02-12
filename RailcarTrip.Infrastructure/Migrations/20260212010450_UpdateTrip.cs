using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailcarTrip.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTrip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RailcarId",
                table: "Trips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trips_RailcarId",
                table: "Trips",
                column: "RailcarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Railcars_RailcarId",
                table: "Trips",
                column: "RailcarId",
                principalTable: "Railcars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Railcars_RailcarId",
                table: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Trips_RailcarId",
                table: "Trips");

            migrationBuilder.DropColumn(
                name: "RailcarId",
                table: "Trips");
        }
    }
}
