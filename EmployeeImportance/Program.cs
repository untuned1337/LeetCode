using System;
using System.Collections.Generic;

namespace EmployeeImportance
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = BuildDummyEmployees();
            var employeeRepository = new EmployeeRepository(employees);
            var employeeHandler = new EmployeeHandler(employeeRepository);

            var overallImportance = employeeHandler.GetOverallImportance(1);

            Console.WriteLine(overallImportance);
        }

        public static IList<Employee> BuildDummyEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Importance = 5,
                    Subordinates = new List<int>{ 2, 3 },
                },
                new Employee()
                {
                    Id = 2,
                    Importance = 3,
                    Subordinates = new List<int>(),
                },
                new Employee()
                {
                    Id = 3,
                    Importance = 3,
                    Subordinates = new List<int>(),
                }
            };

            return employees;
        }
    }
}
