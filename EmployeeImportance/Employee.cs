using System.Collections.Generic;

namespace EmployeeImportance
{
    public class Employee
    {
        public int Id { get; set; }
        public int Importance { get; set; }
        public IList<int> Subordinates{ get; set; }
    }
}
