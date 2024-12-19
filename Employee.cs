using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_And_LINQ_Practice
{
    internal class Employee
    {
        public int id { get; set; }
        public int salary { get; set; }
        public string department { get; set; }
        public static List<Employee> GetEmployee()
        {
            List<Employee> empList = new List<Employee>() {
                new Employee { id = 101, salary = 2000, department = "IT"},
                new Employee { id = 111, salary = 5000, department = "Sales"},
                new Employee { id = 121, salary = 1500, department = "IT"},
                new Employee { id = 131, salary = 7000, department = "Management"},
                new Employee { id = 141, salary = 10000, department = "Sales"},
                new Employee { id = 151, salary = 1700, department = "Sales"},

            };
            return empList;
        }

        public static void FilterByDepartment()
        {
            //Using lambda expression
            List<Employee> emp = GetEmployee()
                .FindAll(e => e.department == "IT" && e.salary >= 2000)
                .ToList();
            foreach (Employee employees in emp)
            {
                Console.WriteLine($"Id:{employees.id} Salary: {employees.salary} Department : {employees.department}");
            }
        }

        public static void FilterUsingLINQ()
        {
            //using LINQ
             List<Employee> empLINQ = (from e in Employee.GetEmployee()
                                       where e.department == "IT" && e.salary >= 2000
                                       select e).ToList();

            foreach (Employee employee in empLINQ)
            {
                Console.WriteLine($"ID: {employee.id}, Salary : {employee.salary}, Deparment:{employee.department} ");
            }
        }
    }
}


