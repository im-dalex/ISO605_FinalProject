using Microsoft.EntityFrameworkCore.Migrations;

namespace TRC.Bussiness.Migrations
{
    public partial class inspectionFuelQuantityType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FuelQuantity",
                table: "Inspection",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "FuelQuantity",
                table: "Inspection",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);
        }
    }
}
