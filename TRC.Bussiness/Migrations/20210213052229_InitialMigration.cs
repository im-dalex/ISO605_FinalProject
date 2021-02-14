using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TRC.Bussiness.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Identification = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CreditCard = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreditLimit = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    PersonType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: "Fisica"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Identification = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Schedule = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Commission = table.Column<int>(type: "int", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "FuelType",
                columns: table => new
                {
                    FuelTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelType", x => x.FuelTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleBrand",
                columns: table => new
                {
                    VehicleBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBrand", x => x.VehicleBrandId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModel",
                columns: table => new
                {
                    VehicleModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    VehicleBrandId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModel", x => x.VehicleModelId);
                    table.ForeignKey(
                        name: "FK_VehicleModel_VehicleBrand_VehicleBrandId",
                        column: x => x.VehicleBrandId,
                        principalTable: "VehicleBrand",
                        principalColumn: "VehicleBrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleModel_VehicleType_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NoChassis = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NoMotor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NoLicensePlate = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_FuelType",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelType",
                        principalColumn: "FuelTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicle_VehicleModel",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModel",
                        principalColumn: "VehicleModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentDetail",
                columns: table => new
                {
                    RentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RentDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "getdate()"),
                    PriceByDay = table.Column<decimal>(type: "money", nullable: false),
                    RentDays = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "A")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentDetail", x => x.RentDetailId);
                    table.ForeignKey(
                        name: "FK_RentDetail_Customer",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentDetail_Employee",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentDetail_Vehicle",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inspection",
                columns: table => new
                {
                    InspectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentDetailId = table.Column<int>(type: "int", nullable: false),
                    IsGrated = table.Column<bool>(type: "bit", nullable: false),
                    FuelQuantity = table.Column<double>(type: "float", nullable: false),
                    HasHydraulicCat = table.Column<bool>(type: "bit", nullable: false),
                    HasSpareTire = table.Column<bool>(type: "bit", nullable: false),
                    HasBrokenMirror = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "A"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    VehicleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection", x => x.InspectionId);
                    table.ForeignKey(
                        name: "FK_Inspection_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inspection_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inspection_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentDetail_Inspection",
                        column: x => x.RentDetailId,
                        principalTable: "RentDetail",
                        principalColumn: "RentDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReturnDetail",
                columns: table => new
                {
                    ReturnDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentDetailId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnDetail", x => x.ReturnDetailId);
                    table.ForeignKey(
                        name: "FK_ReturnDetail_RentDetail_RentDetailId",
                        column: x => x.RentDetailId,
                        principalTable: "RentDetail",
                        principalColumn: "RentDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CreditCard",
                table: "Customer",
                column: "CreditCard",
                unique: true,
                filter: "[CreditCard] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Identification",
                table: "Customer",
                column: "Identification",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Identification",
                table: "Employee",
                column: "Identification",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_CustomerId",
                table: "Inspection",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_EmployeeId",
                table: "Inspection",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_RentDetailId",
                table: "Inspection",
                column: "RentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_VehicleId",
                table: "Inspection",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RentDetail_CustomerId",
                table: "RentDetail",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RentDetail_EmployeeId",
                table: "RentDetail",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RentDetail_VehicleId",
                table: "RentDetail",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnDetail_RentDetailId",
                table: "ReturnDetail",
                column: "RentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_FuelTypeId",
                table: "Vehicle",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_NoChassis",
                table: "Vehicle",
                column: "NoChassis",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_NoLicensePlate",
                table: "Vehicle",
                column: "NoLicensePlate",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_NoMotor",
                table: "Vehicle",
                column: "NoMotor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleModelId",
                table: "Vehicle",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_VehicleBrandId",
                table: "VehicleModel",
                column: "VehicleBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModel_VehicleTypeId",
                table: "VehicleModel",
                column: "VehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspection");

            migrationBuilder.DropTable(
                name: "ReturnDetail");

            migrationBuilder.DropTable(
                name: "RentDetail");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "FuelType");

            migrationBuilder.DropTable(
                name: "VehicleModel");

            migrationBuilder.DropTable(
                name: "VehicleBrand");

            migrationBuilder.DropTable(
                name: "VehicleType");
        }
    }
}
