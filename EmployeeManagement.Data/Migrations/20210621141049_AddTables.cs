using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Data.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeLeaveType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Days = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberofDays = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmployeeLeaveTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveAllocations_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveAllocations_EmployeeLeaveType_EmployeeLeaveTypeId",
                        column: x => x.EmployeeLeaveTypeId,
                        principalTable: "EmployeeLeaveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovedEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmpoyeeLeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    EmlpoyeeLeaveTypeId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestDated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequests_AspNetUsers_ApprovedEmployeeId",
                        column: x => x.ApprovedEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequests_AspNetUsers_RequestingEmployeeId",
                        column: x => x.RequestingEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaveRequests_EmployeeLeaveType_EmlpoyeeLeaveTypeId",
                        column: x => x.EmlpoyeeLeaveTypeId,
                        principalTable: "EmployeeLeaveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveAllocations_EmployeeId",
                table: "EmployeeLeaveAllocations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveAllocations_EmployeeLeaveTypeId",
                table: "EmployeeLeaveAllocations",
                column: "EmployeeLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequests_ApprovedEmployeeId",
                table: "EmployeeLeaveRequests",
                column: "ApprovedEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequests_EmlpoyeeLeaveTypeId",
                table: "EmployeeLeaveRequests",
                column: "EmlpoyeeLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaveRequests_RequestingEmployeeId",
                table: "EmployeeLeaveRequests",
                column: "RequestingEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLeaveAllocations");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveRequests");

            migrationBuilder.DropTable(
                name: "EmployeeLeaveType");
        }
    }
}
