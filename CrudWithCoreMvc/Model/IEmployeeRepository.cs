using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithCoreMvc.Model
{
    interface IEmployeeRepository 
    {
        Employee AddEmployee(Employee employee);
        Employee GetEmployee(int id);
        Employee UpdateEmployee(Employee changedEmployee);
        Employee DeleteEmployee(int id);

    }
}
