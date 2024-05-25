using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinic.Migrations
{
    public partial class updateversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sci_price",
                table: "tbl_scitools",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "medicinecat_image",
                table: "tbl_medicinecateogry",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sci_price",
                table: "tbl_scitools");

            migrationBuilder.DropColumn(
                name: "medicinecat_image",
                table: "tbl_medicinecateogry");
        }
    }
}
