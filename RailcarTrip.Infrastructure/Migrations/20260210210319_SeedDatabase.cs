using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RailcarTrip.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { 1, "W", "Released from origin" },
                    { 2, "A", "Arrived at location" },
                    { 3, "D", "Departed from location" },
                    { 4, "Z", "Placed at Destination" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "Timezone" },
                values: new object[,]
                {
                    { 1, "Vancouver", "Pacific Standard Time" },
                    { 2, "Victoria", "Pacific Standard Time" },
                    { 3, "Kelowna", "Pacific Standard Time" },
                    { 4, "Kamloops", "Pacific Standard Time" },
                    { 5, "Prince George", "Pacific Standard Time" },
                    { 6, "Calgary", "Mountain Standard Time" },
                    { 7, "Edmonton", "Mountain Standard Time" },
                    { 8, "Lethbridge", "Mountain Standard Time" },
                    { 9, "Red Deer", "Mountain Standard Time" },
                    { 10, "Fort McMurray", "Mountain Standard Time" },
                    { 11, "Regina", "Canada Central Standard Time" },
                    { 12, "Saskatoon", "Canada Central Standard Time" },
                    { 13, "Moose Jaw", "Canada Central Standard Time" },
                    { 14, "Brandon", "Central Standard Time" },
                    { 15, "Winnipeg", "Central Standard Time" },
                    { 16, "Thunder Bay", "Eastern Standard Time" },
                    { 17, "Sault Ste. Marie", "Eastern Standard Time" },
                    { 18, "Sudbury", "Eastern Standard Time" },
                    { 19, "North Bay", "Eastern Standard Time" },
                    { 20, "Barrie", "Eastern Standard Time" },
                    { 21, "Toronto", "Eastern Standard Time" },
                    { 22, "Mississauga", "Eastern Standard Time" },
                    { 23, "Hamilton", "Eastern Standard Time" },
                    { 24, "London", "Eastern Standard Time" },
                    { 25, "Kitchener", "Eastern Standard Time" },
                    { 26, "Windsor", "Eastern Standard Time" },
                    { 27, "St Catherines", "Eastern Standard Time" },
                    { 28, "Oshawa", "Eastern Standard Time" },
                    { 29, "Kingston", "Eastern Standard Time" },
                    { 30, "Ottowa", "Eastern Standard Time" },
                    { 31, "Gattineau", "Eastern Standard Time" },
                    { 32, "Montreal", "Eastern Standard Time" },
                    { 33, "Quebec City", "Eastern Standard Time" },
                    { 34, "Sherbrooke", "Eastern Standard Time" },
                    { 35, "Trois-RiviÃ¨res", "Eastern Standard Time" },
                    { 36, "Saguenay", "Eastern Standard Time" },
                    { 37, "Rimouski", "Eastern Standard Time" },
                    { 38, "Edmundston", "Atlantic Standard Time" },
                    { 39, "Fredericton", "Atlantic Standard Time" },
                    { 40, "Moncton", "Atlantic Standard Time" },
                    { 41, "Saint John", "Atlantic Standard Time" },
                    { 42, "Bathurst", "Atlantic Standard Time" },
                    { 43, "Charlottetown", "Atlantic Standard Time" },
                    { 44, "Summerside", "Atlantic Standard Time" },
                    { 45, "Sydney", "Atlantic Standard Time" },
                    { 46, "Turo", "Atlantic Standard Time" },
                    { 47, "New Glasgow", "Atlantic Standard Time" },
                    { 48, "Dartmouth", "Atlantic Standard Time" },
                    { 49, "Halifax", "Atlantic Standard Time" }
                });

            migrationBuilder.InsertData(
                table: "Railcars",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1, "ACAR1234" },
                    { 2, "BCAR4321" },
                    { 3, "CCar1111" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Railcars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Railcars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Railcars",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
