using Microsoft.EntityFrameworkCore.Migrations;

namespace TestingWebPortal.Migrations
{
    public partial class AddcountOfAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "countOfAnswers",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "countOfAnswers",
                table: "Questions");
        }
    }
}
