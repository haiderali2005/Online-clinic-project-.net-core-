using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clinic.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbl_medicines_medicinecat_id",
                table: "tbl_medicines",
                column: "medicinecat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_medicines_tbl_medicinecateogry_medicinecat_id",
                table: "tbl_medicines",
                column: "medicinecat_id",
                principalTable: "tbl_medicinecateogry",
                principalColumn: "medicinecat_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_medicines_tbl_medicinecateogry_medicinecat_id",
                table: "tbl_medicines");

            migrationBuilder.DropIndex(
                name: "IX_tbl_medicines_medicinecat_id",
                table: "tbl_medicines");
        }
    }
}
