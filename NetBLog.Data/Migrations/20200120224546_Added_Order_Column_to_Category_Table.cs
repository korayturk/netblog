using Microsoft.EntityFrameworkCore.Migrations;

namespace NetBLog.Data.Migrations
{
    public partial class Added_Order_Column_to_Category_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category");
        }
    }
}
