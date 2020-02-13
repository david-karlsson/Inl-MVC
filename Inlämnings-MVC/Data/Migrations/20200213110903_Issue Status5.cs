using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämnings_MVC.Data.Migrations
{
    public partial class IssueStatus5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Issue",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Issue");
        }
    }
}
