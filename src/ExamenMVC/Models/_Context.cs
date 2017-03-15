using Microsoft.EntityFrameworkCore;

namespace ExamenMVC.Models
{
    public partial class _Context : DbContext
    {
        public _Context(DbContextOptions<_Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeId").HasColumnType("numeric").ValueGeneratedOnAdd();
                entity.Property(e => e.EmployeeNumber).HasColumnName("EmployeeNumber").HasColumnType("varchar(8)");
                entity.Property(e => e.EmployeeName).HasColumnName("EmployeeName").HasColumnType("varchar(200)");
                entity.HasIndex(e => e.EmployeeNumber).IsUnique();
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.ToTable("Phones");
                entity.Property(e => e.PhoneId).HasColumnName("PhoneId").HasColumnType("numeric").ValueGeneratedOnAdd();
                entity.Property(e => e.PhoneNumber).HasColumnName("PhoneNumber").HasColumnType("varchar(20)");
                entity.Property(e => e.EmployeeNumber).HasColumnName("EmployeeNumber").HasColumnType("varchar(8)");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Taskss");
                entity.Property(e => e.TaskId).HasColumnName("TaskId").HasColumnType("numeric").ValueGeneratedOnAdd();
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeId").HasColumnType("numeric");
                entity.Property(e => e.TaskName).HasColumnName("TaskName").HasColumnType("varchar(200)");
                entity.HasIndex(e => e.TaskName).IsUnique();
            });
        }
    }
}