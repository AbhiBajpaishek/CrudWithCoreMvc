using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithCoreMvc.Model
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        public List<Employee> _employeeRepository;

        public MockEmployeeRepository()
        {
            _employeeRepository = new List<Employee>
            {
                new Employee{Id=1,Name="Abhishek Bajpai",Department=Dept.Finance,Email="abc@gmail.com" },
                new Employee{Id=2,Name="Amit",Department=Dept.IT,Email="amit@gmail.com" },
                new Employee{Id=3,Name="Sam Williams",Department=Dept.HR,Email="sam@gmail.com" }
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            _employeeRepository.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = GetEmployee(id);
            _employeeRepository.Remove(employee);
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeRepository.FirstOrDefault(emp => emp.Id == id);
        }

        public Employee UpdateEmployee(Employee changedEmployee)
        {
            Employee employee = GetEmployee(changedEmployee.Id);
            employee.Name = changedEmployee.Name;
            employee.Email = changedEmployee.Email;
            employee.Department = changedEmployee.Department;
            return employee;
        }
    }
}
