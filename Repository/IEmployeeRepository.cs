using EmployeeManagement.Models;

namespace EmployeeManagement.Repository
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(int id);
        public IEnumerable<Employee> GetEmployees();
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employeeChanges);
        public Employee DeleteEmployee(int id);
    }
}
