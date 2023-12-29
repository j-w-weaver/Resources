using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resources.API.Migrations
{
    public partial class updatedDbString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Very popular beach with shark teeth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Very populat beach with shark teeth");
        }
    }
}
