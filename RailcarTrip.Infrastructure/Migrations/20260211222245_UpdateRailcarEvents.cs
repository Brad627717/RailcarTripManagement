using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RailcarTrip.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRailcarEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Railcar_Events_Railcars_RailcarCode",
                table: "Railcar_Events");

            migrationBuilder.RenameColumn(
                name: "RailcarCode",
                table: "Railcar_Events",
                newName: "RailcarId");

            migrationBuilder.RenameIndex(
                name: "IX_Railcar_Events_RailcarCode",
                table: "Railcar_Events",
                newName: "IX_Railcar_Events_RailcarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Railcar_Events_Railcars_RailcarId",
                table: "Railcar_Events",
                column: "RailcarId",
                principalTable: "Railcars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Railcar_Events_Railcars_RailcarId",
                table: "Railcar_Events");

            migrationBuilder.RenameColumn(
                name: "RailcarId",
                table: "Railcar_Events",
                newName: "RailcarCode");

            migrationBuilder.RenameIndex(
                name: "IX_Railcar_Events_RailcarId",
                table: "Railcar_Events",
                newName: "IX_Railcar_Events_RailcarCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Railcar_Events_Railcars_RailcarCode",
                table: "Railcar_Events",
                column: "RailcarCode",
                principalTable: "Railcars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
