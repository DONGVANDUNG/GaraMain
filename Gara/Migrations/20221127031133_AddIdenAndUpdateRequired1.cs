using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gara.Migrations
{
    /// <inheritdoc />
    public partial class AddIdenAndUpdateRequired1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessaryName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    AccessaryType = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccessaryPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "varchar(200)", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessaryPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCode = table.Column<string>(type: "varchar(50)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    StartWorkAt = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    IdentificationId = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Certificate = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    SalaryUnit = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Errors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRepairs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RepairTimes = table.Column<int>(type: "int", nullable: true),
                    WarrantyTimes = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRepairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerRepairs_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationType = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IdentificationNo = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Identifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    VehicleBrand = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Status = table.Column<string>(type: "varchar(200)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    VehicleStatus = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    TotalPayment = table.Column<double>(type: "float", nullable: false),
                    WarantyPeriod = table.Column<int>(type: "int", nullable: true),
                    WarantyPeriodType = table.Column<string>(type: "varchar(200)", nullable: true),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    EmployeeFix = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehiclePayments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehiclePayments_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessaryPaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessaryPaymentId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false),
                    AccessaryId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessaryPaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessaryPaymentDetails_Accessaries_AccessaryId",
                        column: x => x.AccessaryId,
                        principalTable: "Accessaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessaryPaymentDetails_AccessaryPayments_AccessaryPaymentId",
                        column: x => x.AccessaryPaymentId,
                        principalTable: "AccessaryPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessaryPaymentDetails_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehiclePaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePaymentId = table.Column<int>(type: "int", nullable: false),
                    AccessaryId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AccessaryNumber = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehiclePaymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehiclePaymentDetails_Accessaries_AccessaryId",
                        column: x => x.AccessaryId,
                        principalTable: "Accessaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehiclePaymentDetails_VehiclePayments_VehiclePaymentId",
                        column: x => x.VehiclePaymentId,
                        principalTable: "VehiclePayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessaryPaymentDetails_AccessaryId",
                table: "AccessaryPaymentDetails",
                column: "AccessaryId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessaryPaymentDetails_AccessaryPaymentId",
                table: "AccessaryPaymentDetails",
                column: "AccessaryPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessaryPaymentDetails_ProducerId",
                table: "AccessaryPaymentDetails",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRepairs_CustomerId",
                table: "CustomerRepairs",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Identifications_EmployeeId",
                table: "Identifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePaymentDetails_AccessaryId",
                table: "VehiclePaymentDetails",
                column: "AccessaryId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePaymentDetails_VehiclePaymentId",
                table: "VehiclePaymentDetails",
                column: "VehiclePaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePayments_CustomerId",
                table: "VehiclePayments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclePayments_PaymentTypeId",
                table: "VehiclePayments",
                column: "PaymentTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessaryPaymentDetails");

            migrationBuilder.DropTable(
                name: "CustomerRepairs");

            migrationBuilder.DropTable(
                name: "Errors");

            migrationBuilder.DropTable(
                name: "Identifications");

            migrationBuilder.DropTable(
                name: "VehiclePaymentDetails");

            migrationBuilder.DropTable(
                name: "AccessaryPayments");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Accessaries");

            migrationBuilder.DropTable(
                name: "VehiclePayments");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PaymentTypes");
        }
    }
}
