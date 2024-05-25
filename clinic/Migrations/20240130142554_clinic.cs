using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinic.Migrations
{
    public partial class clinic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_addtocart",
                columns: table => new
                {
                    cart_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cart_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cart_quantity = table.Column<int>(type: "int", nullable: false),
                    cart_price = table.Column<int>(type: "int", nullable: false),
                    cart_bill = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_addtocart", x => x.cart_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_admin",
                columns: table => new
                {
                    admin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    admin_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    admin_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    admin_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    admin_image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_admin", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_client",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    client_country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_client", x => x.client_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_educationevents",
                columns: table => new
                {
                    event_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    event_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    event_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    event_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    event_location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_educationevents", x => x.event_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_feedback",
                columns: table => new
                {
                    feedback_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    feedback_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    feedback_message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_feedback", x => x.feedback_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_medicinecateogry",
                columns: table => new
                {
                    medicinecat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicinecat_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_medicinecateogry", x => x.medicinecat_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_medicines",
                columns: table => new
                {
                    med_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    med_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    med_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    med_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    med_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    med_image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    medicinecat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_medicines", x => x.med_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_scitools",
                columns: table => new
                {
                    sci_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sci_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sci_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sci_image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_scitools", x => x.sci_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_addtocart");

            migrationBuilder.DropTable(
                name: "tbl_admin");

            migrationBuilder.DropTable(
                name: "tbl_client");

            migrationBuilder.DropTable(
                name: "tbl_educationevents");

            migrationBuilder.DropTable(
                name: "tbl_feedback");

            migrationBuilder.DropTable(
                name: "tbl_medicinecateogry");

            migrationBuilder.DropTable(
                name: "tbl_medicines");

            migrationBuilder.DropTable(
                name: "tbl_scitools");
        }
    }
}
