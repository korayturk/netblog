using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBLog.Data.Migrations
{
    public partial class Added_Url_Column_to_Category_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Category");
        }
    }
}
