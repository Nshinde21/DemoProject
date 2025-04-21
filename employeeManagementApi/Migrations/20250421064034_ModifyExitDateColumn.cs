using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace employeeManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class ModifyExitDateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From_date",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Gross_salary",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Net_salary",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Salary_date",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "To_Date",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Total_payable_hours",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmpUpdated_date",
                table: "EmployeeSalary",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "EmpCreated_date",
                table: "EmployeeSalary",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "EpmSalaryId",
                table: "EmployeeSalary",
                newName: "Id");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "salary_date",
                table: "EmployeeSalary",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "From_date",
                table: "EmployeeSalary",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Reporting_employee_id",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Joining_date",
                table: "Employee",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Exit_date",
                table: "Employee",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DOB",
                table: "Employee",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateTable(
                name: "AddEmployee",
                columns: table => new
                {
                    Name = table.Column<string>(type: "text", nullable: true),
                    Personal_email = table.Column<string>(type: "text", nullable: true),
                    Work_email = table.Column<string>(type: "text", nullable: true),
                    SSN = table.Column<string>(type: "text", nullable: true),
                    DOB = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    Zip = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Reporting_employee_id = table.Column<int>(type: "integer", nullable: true),
                    Joining_date = table.Column<DateOnly>(type: "date", nullable: true),
                    Exit_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Is_active = table.Column<bool>(type: "boolean", nullable: false),
                    Created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AddSalaryData",
                columns: table => new
                {
                    Employee_id = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Total_payable_hours = table.Column<decimal>(type: "numeric", nullable: false),
                    From_date = table.Column<DateOnly>(type: "date", nullable: false),
                    To_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gross_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    Net_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    salary_date = table.Column<DateOnly>(type: "date", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GetAllEmployeesDataWithSalaries",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Personal_email = table.Column<string>(type: "text", nullable: true),
                    Work_email = table.Column<string>(type: "text", nullable: true),
                    dob = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    zip = table.Column<string>(type: "text", nullable: true),
                    joining_date = table.Column<DateOnly>(type: "date", nullable: true),
                    Total_payable_hours = table.Column<decimal>(type: "numeric", nullable: true),
                    Gross_salary = table.Column<decimal>(type: "numeric", nullable: true),
                    Net_salary = table.Column<decimal>(type: "numeric", nullable: true),
                    from_date = table.Column<DateOnly>(type: "date", nullable: true),
                    to_date = table.Column<DateOnly>(type: "date", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Is_active = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetAllEmployeesDataWithSalaries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GetDistinctTitlesWithMinMaxSalaries",
                columns: table => new
                {
                    title = table.Column<string>(type: "text", nullable: false),
                    minNet_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    maxNet_salary = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GetEmployeeSalaryDataById",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "text", nullable: true),
                    total_payable_hours = table.Column<decimal>(type: "numeric", nullable: false),
                    gross_salary = table.Column<decimal>(type: "numeric", nullable: true),
                    net_salary = table.Column<decimal>(type: "numeric", nullable: false),
                    from_date = table.Column<DateOnly>(type: "date", nullable: false),
                    to_date = table.Column<DateOnly>(type: "date", nullable: true),
                    joining_date = table.Column<DateOnly>(type: "date", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetEmployeeSalaryDataById", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GetEmployeesByAge",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    dob = table.Column<DateOnly>(type: "date", nullable: false),
                    age = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetEmployeesByAge", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GetEmployeesByReportingManager",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    reporting_employee_id = table.Column<int>(type: "integer", nullable: false),
                    manager = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetEmployeesByReportingManager", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddEmployee");

            migrationBuilder.DropTable(
                name: "AddSalaryData");

            migrationBuilder.DropTable(
                name: "GetAllEmployeesDataWithSalaries");

            migrationBuilder.DropTable(
                name: "GetDistinctTitlesWithMinMaxSalaries");

            migrationBuilder.DropTable(
                name: "GetEmployeeSalaryDataById");

            migrationBuilder.DropTable(
                name: "GetEmployeesByAge");

            migrationBuilder.DropTable(
                name: "GetEmployeesByReportingManager");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "EmployeeSalary",
                newName: "EmpUpdated_date");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "EmployeeSalary",
                newName: "EmpCreated_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EmployeeSalary",
                newName: "EpmSalaryId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "salary_date",
                table: "EmployeeSalary",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "From_date",
                table: "EmployeeSalary",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "Reporting_employee_id",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Joining_date",
                table: "Employee",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Exit_date",
                table: "Employee",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Employee",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "From_date",
                table: "Employee",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Gross_salary",
                table: "Employee",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Net_salary",
                table: "Employee",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Salary_date",
                table: "Employee",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Employee",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "To_Date",
                table: "Employee",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Total_payable_hours",
                table: "Employee",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
