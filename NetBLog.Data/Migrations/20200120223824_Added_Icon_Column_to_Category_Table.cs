using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBLog.Data.Migrations
{
    public partial class Added_Icon_Column_to_Category_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Category");
        }
    }
}
