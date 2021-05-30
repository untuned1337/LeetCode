using System.Collections.Generic;
using System.Linq;

namespace EmployeeImportance
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IList<Employee> _employees;

        public EmployeeRepository(IList<Employee> employees)
        {
            _employees = employees;
        }

        public Employee GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
