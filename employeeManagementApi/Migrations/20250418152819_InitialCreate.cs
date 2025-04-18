using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace employeeManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Personal_email = table.Column<string>(type: "text", nullable: true),
                    Work_email = table.Column<string>(type: "text", nullable: true),
                    SSN = table.Column<string>(type: "text", nullable: true),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    Zip = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Reporting_employee_id = table.Column<int>(type: "integer", nullable: false),
                    Joining_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Exit_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Is_active = table.Column<bool>(type: "boolean", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Total_payable_hours = table.Column<decimal>(type: "numeric", nullable: false),
                    From_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    To_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gross_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    Net_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    Salary_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalary",
                columns: table => new
                {
                    EpmSalaryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Employee_id = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Total_payable_hours = table.Column<decimal>(type: "numeric", nullable: false),
                    From_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    To_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gross_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    Net_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    salary_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmpCreated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmpUpdated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalary", x => x.EpmSalaryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeSalary");
        }
    }
}
