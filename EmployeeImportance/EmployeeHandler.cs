namespace EmployeeImportance
{
    public class EmployeeHandler
    {
        private readonly IEmployeeRepository _employees;

        public EmployeeHandler(IEmployeeRepository employees)
        {
            _employees = employees;
        }

        public int GetOverallImportance(int id)
        {
            var rootEmployee = _employees.GetById(id);
            var importanceSum = GetSubImportanceSum(rootEmployee);

            return importanceSum;
        }

        private int GetSubImportanceSum(Employee employee)
        {
            var sum = employee.Importance;

            if (employee.Subordinates.Count == 0)
            {
                return sum;
            }

            foreach (var subOrdinate in employee.Subordinates)
            {
                var followerEmployee = _employees.GetById(subOrdinate);
                sum += GetSubImportanceSum(followerEmployee);
            }

            return sum;
        }
    }
}
