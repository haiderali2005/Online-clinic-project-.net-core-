using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinic.Migrations
{
    public partial class workplease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_scihome",
                columns: table => new
                {
                    scihome_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scihome_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scihome_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scihome_des = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scihome_img = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_scihome", x => x.scihome_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_scihome");
        }
    }
}
