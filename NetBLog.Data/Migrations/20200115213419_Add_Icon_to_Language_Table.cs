using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBLog.Data.Migrations
{
    public partial class Add_Icon_to_Language_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Language",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Language");
        }
    }
}
