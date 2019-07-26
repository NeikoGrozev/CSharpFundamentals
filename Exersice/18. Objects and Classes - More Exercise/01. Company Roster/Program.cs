namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Department> test = new Dictionary<string, Department>();

            for (int i = 0; i < num; i++)
            {
                string[] token = Console.ReadLine()
                    .Split();

                string name = token[0];
                decimal salary = decimal.Parse(token[1]);
                string departmentName = token[2];

                if (!test.ContainsKey(departmentName))
                {
                    Department prof = new Department(departmentName);
                    test.Add(prof.DepartmentName, prof);
                    test[departmentName].Employee.Add(new Employee(name, salary));
                }
                else
                {
                    test[departmentName].Employee.Add(new Employee(name, salary));
                }
            }

            decimal average = 0;
            string currentName = string.Empty;

            foreach (var item in test.Values)
            {
                decimal currentAverage = 0;

                foreach (var test1 in item.Employee.OrderByDescending(x => x.Salary))
                {
                    currentAverage += test1.Salary;
                }

                if (currentAverage > average)
                {
                    average = currentAverage;
                    currentName = item.DepartmentName;
                }
            }

            Console.WriteLine($"Highest Average Salary: {currentName}");

            foreach (var item in test.Values)
            {
                foreach (var test1 in item.Employee.OrderByDescending(x => x.Salary))
                {
                    if (item.DepartmentName == currentName)
                    {
                        Console.WriteLine($"{test1.Name} {test1.Salary:F2}");
                    }
                }
            }
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employee { get; set; }

        public Department(string department)
        {
            this.DepartmentName = department;
            this.Employee = new List<Employee>();
        }
    }

    class Employee
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
    }
}

