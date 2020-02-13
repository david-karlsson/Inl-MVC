using Microsoft.EntityFrameworkCore.Migrations;

namespace Inlämnings_MVC.Data.Migrations
{
    public partial class IssueStatus6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Issue");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Issue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Issue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Issue",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
