using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämnings_MVC.Data.Migrations
{
    public partial class IssueStatus3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Issue",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Issue");
        }
    }
}
