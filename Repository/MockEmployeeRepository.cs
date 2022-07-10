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
                new Employee(){ Id = 1, Name = "Mary", Department=Dept.HR, Email="mary@mannytech.com"},
                new Employee(){Id=2, Name="Angela", Department=Dept.IT, Email="angela@mannytech.com"},
                new Employee(){Id=3, Name="Sam", Department=Dept.IT, Email="sam@mannytech.com"}
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(employee => employee.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
