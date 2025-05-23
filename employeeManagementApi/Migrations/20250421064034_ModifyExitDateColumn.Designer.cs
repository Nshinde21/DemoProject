﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApi.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace employeeManagementApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250421064034_ModifyExitDateColumn")]
    partial class ModifyExitDateColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("employeeManagementApi.Models.AddEmployee", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly?>("DOB")
                        .HasColumnType("date");

                    b.Property<DateTime?>("Exit_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<DateOnly?>("Joining_date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Personal_email")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int?>("Reporting_employee_id")
                        .HasColumnType("integer");

                    b.Property<string>("SSN")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Updated_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Work_email")
                        .HasColumnType("text");

                    b.Property<string>("Zip")
                        .HasColumnType("text");

                    b.ToTable("AddEmployee");
                });

            modelBuilder.Entity("employeeManagementApi.Models.AddSalaryData", b =>
                {
                    b.Property<int>("Employee_id")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("From_date")
                        .HasColumnType("date")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period from date");

                    b.Property<decimal>("Gross_salary")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Net_salary")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime>("To_Date")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period to date");

                    b.Property<decimal>("Total_payable_hours")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("salary_date")
                        .HasColumnType("date");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("timestamp with time zone");

                    b.ToTable("AddSalaryData");
                });

            modelBuilder.Entity("employeeManagementApi.Models.EmployeeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly?>("DOB")
                        .HasColumnType("date");

                    b.Property<DateTime?>("Exit_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<DateOnly?>("Joining_date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Personal_email")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int?>("Reporting_employee_id")
                        .HasColumnType("integer");

                    b.Property<string>("SSN")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<DateTime>("Updated_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Work_email")
                        .HasColumnType("text");

                    b.Property<string>("Zip")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("employeeManagementApi.Models.GetAllEmployeesDataWithSalaries", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<decimal?>("Gross_salary")
                        .HasColumnType("numeric");

                    b.Property<bool?>("Is_active")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal?>("Net_salary")
                        .HasColumnType("numeric");

                    b.Property<string>("Personal_email")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<decimal?>("Total_payable_hours")
                        .HasColumnType("numeric");

                    b.Property<string>("Work_email")
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly?>("dob")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("from_date")
                        .HasColumnType("date")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period from date");

                    b.Property<DateOnly?>("joining_date")
                        .HasColumnType("date");

                    b.Property<string>("state")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("to_date")
                        .HasColumnType("date")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period to date");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("zip")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("GetAllEmployeesDataWithSalaries");
                });

            modelBuilder.Entity("employeeManagementApi.Models.GetDistinctTitlesWithMinMaxSalaries", b =>
                {
                    b.Property<decimal>("maxNet_salary")
                        .HasColumnType("numeric");

                    b.Property<decimal>("minNet_salary")
                        .HasColumnType("numeric");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.ToTable("GetDistinctTitlesWithMinMaxSalaries");
                });

            modelBuilder.Entity("employeeManagementApi.Models.GetEmployeeSalaryDataById", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateOnly>("from_date")
                        .HasColumnType("date")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period from date");

                    b.Property<decimal?>("gross_salary")
                        .HasColumnType("numeric");

                    b.Property<bool?>("is_active")
                        .HasColumnType("boolean");

                    b.Property<DateOnly?>("joining_date")
                        .HasColumnType("date");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<decimal>("net_salary")
                        .HasColumnType("numeric");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("to_date")
                        .HasColumnType("date")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period to date");

                    b.Property<decimal>("total_payable_hours")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("GetEmployeeSalaryDataById");
                });

            modelBuilder.Entity("employeeManagementApi.Models.GetEmployeesByAge", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "Employee Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<decimal>("age")
                        .HasColumnType("numeric")
                        .HasAnnotation("Relational:JsonPropertyName", "Employee Age");

                    b.Property<DateOnly>("dob")
                        .HasColumnType("date")
                        .HasAnnotation("Relational:JsonPropertyName", "Employee Date of Birth");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "Employee Name");

                    b.HasKey("id");

                    b.ToTable("GetEmployeesByAge");
                });

            modelBuilder.Entity("employeeManagementApi.Models.GetEmployeesByReportingManager", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "Employee Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("manager")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "Manager Name");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("reporting_employee_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "Manager Id");

                    b.HasKey("id");

                    b.ToTable("GetEmployeesByReportingManager");
                });

            modelBuilder.Entity("employeeManagementApi.Models.SalaryData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "Employee Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Employee_id")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("From_date")
                        .HasColumnType("date")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period from date");

                    b.Property<decimal>("Gross_salary")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Net_salary")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime>("To_Date")
                        .HasColumnType("timestamp with time zone")
                        .HasAnnotation("Relational:JsonPropertyName", "Pay Period to date");

                    b.Property<decimal>("Total_payable_hours")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("salary_date")
                        .HasColumnType("date");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("EmployeeSalary");
                });
#pragma warning restore 612, 618
        }
    }
}
