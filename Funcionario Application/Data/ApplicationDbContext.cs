using Funcionario_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Funcionario_Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Prevent cascade delete on Designation FK
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Designation)
            .WithMany()
            .HasForeignKey(e => e.DesignationId)
            .OnDelete(DeleteBehavior.Restrict);
            // Seed EmployeeTypes
            modelBuilder.Entity<EmployeeType>().HasData(
                new EmployeeType { Id = 1, Name = "Permanent" },
                new EmployeeType { Id = 2, Name = "Temporary" },
                new EmployeeType { Id = 3, Name = "Contract" },
                new EmployeeType { Id = 4, Name = "Intern" }
            );
            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Sales" },
                new Department { Id = 4, Name = "Admin" }
            );
            // Seed Designations with DepartmentId
            modelBuilder.Entity<Designation>().HasData(
                new Designation { Id = 1, Name = "Software Developer", DepartmentId = 1 },
                new Designation { Id = 2, Name = "System Administrator", DepartmentId = 1 },
                new Designation { Id = 3, Name = "Network Engineer", DepartmentId = 1 },
                new Designation { Id = 4, Name = "HR Specialist", DepartmentId = 2 },
                new Designation { Id = 5, Name = "HR Manager", DepartmentId = 2 },
                new Designation { Id = 6, Name = "Talent Acquisition Coordinator", DepartmentId = 2 },
                new Designation { Id = 7, Name = "Sales Executive", DepartmentId = 3 },
                new Designation { Id = 8, Name = "Sales Manager", DepartmentId = 3 },
                new Designation { Id = 9, Name = "Account Executive", DepartmentId = 3 },
                new Designation { Id = 10, Name = "Office Manager", DepartmentId = 4 },
                new Designation { Id = 11, Name = "Executive Assistant", DepartmentId = 4 },
                new Designation { Id = 12, Name = "Receptionist", DepartmentId = 4 }
            );
            // Seed initial data
        }
    }
}
