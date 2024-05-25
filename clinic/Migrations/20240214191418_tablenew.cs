using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinic.Migrations
{
    public partial class tablenew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_scitwo",
                columns: table => new
                {
                    two_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    two_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    two_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    two_des = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    two_img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_scitwo", x => x.two_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_scitwo");
        }
    }
}
