using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name ="Mark",
                    Email="mark@mannytech.com",
                    Department = Dept.HR
                },
                  new Employee
                  {
                      Id = 2,
                      Name = "Daniel",
                      Email = "daniel@mannytech.com",
                      Department = Dept.HR
                  }

            );
        }
    }
}