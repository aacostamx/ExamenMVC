using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ExamenMVC.Models;

namespace ExamenMVC.Migrations
{
    [DbContext(typeof(_Context))]
    [Migration("20170315004718_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamenMVC.Models.Employee", b =>
                {
                    b.Property<decimal>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeId")
                        .HasColumnType("numeric");

                    b.Property<string>("EmployeeName")
                        .HasColumnName("EmployeeName")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnName("EmployeeNumber")
                        .HasColumnType("varchar(8)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeeNumber")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ExamenMVC.Models.Phone", b =>
                {
                    b.Property<decimal>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PhoneId")
                        .HasColumnType("numeric");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnName("EmployeeNumber")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("PhoneNumber")
                        .HasColumnType("varchar(20)");

                    b.HasKey("PhoneId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("ExamenMVC.Models.Task", b =>
                {
                    b.Property<decimal>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TaskId")
                        .HasColumnType("numeric");

                    b.Property<decimal>("EmployeeId")
                        .HasColumnName("EmployeeId")
                        .HasColumnType("numeric");

                    b.Property<string>("TaskName")
                        .HasColumnName("TaskName")
                        .HasColumnType("varchar(200)");

                    b.HasKey("TaskId");

                    b.HasIndex("TaskName")
                        .IsUnique();

                    b.ToTable("Taskss");
                });
        }
    }
}
