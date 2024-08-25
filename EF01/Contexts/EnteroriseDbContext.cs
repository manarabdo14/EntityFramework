using EF01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF01.Configrations;

namespace EF01.Contexts
{
    internal class EnteroriseDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                        .Property(E => E.EmpName)
                        .HasDefaultValue("Test")
                        .IsRequired(false);

            //modelBuilder.Entity<Department>()
            //            .ToView("Department");
            //            modelBuilder.Entity<Department>(E =>
            //            {

            //                E.HasKey(D => D.Id);
            //                E.Property(E => E.Id).UseIdentityColumn();
            //                E.Property(E => E.Name).HasColumnType(typeName: "varchar");
            //            }
            //);

            modelBuilder.Entity<Department>()
                        .HasMany(D => D.employees)
                        .WithOne(E => E.department)
                        .HasForeignKey(E => E.departmentId)
                        .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Student>()
                .HasMany(S => S.Courses)
                .WithMany(C => C.Students);

            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
            #region 
            #endregion


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                   => optionsBuilder.UseSqlServer("Server = . ; Database = EnteroriseEf01 ; Trusted_Connection = true ");
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        ////public DbSet<Product> Products { get; set; }

    }
}
