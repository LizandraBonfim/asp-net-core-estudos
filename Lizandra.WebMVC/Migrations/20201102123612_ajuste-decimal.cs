using Microsoft.EntityFrameworkCore.Migrations;

namespace Lizandra.WebMVC.Migrations
{
    public partial class ajustedecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BaseSalary",
                table: "Sellers",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "SalesRecords",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BaseSalary",
                table: "Sellers",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "SalesRecords",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");
        }
    }
}
