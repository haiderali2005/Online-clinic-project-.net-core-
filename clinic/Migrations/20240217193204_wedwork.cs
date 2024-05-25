using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinic.Migrations
{
    public partial class wedwork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_addtocart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_addtocart",
                columns: table => new
                {
                    cart_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cart_bill = table.Column<int>(type: "int", nullable: true),
                    cart_img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cart_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cart_price = table.Column<int>(type: "int", nullable: true),
                    cart_quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_addtocart", x => x.cart_id);
                });
        }
    }
}
