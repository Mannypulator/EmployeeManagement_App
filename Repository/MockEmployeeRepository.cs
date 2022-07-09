using EmployeeManagement.Models;

namespace EmployeeManagement.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;

        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Mary", Department="HR", Email="mary@mannytech.com"},
                new Employee(){Id=2, Name="Angela", Department="IT", Email="angela@mannytech.com"},
                new Employee(){Id=3, Name="Sam", Department="IT", Email="sam@mannytech.com"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }
    }
}
