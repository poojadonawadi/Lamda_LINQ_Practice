using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_And_LINQ_Practice
{
    internal class EmployeeSalary
    {
        public string name { get; set; }
        public int id { get; set; }
        public string department { get; set; }
        public int salary { get; set; }
        public static List<EmployeeSalary> GetEmployeeList()
        {
            List<EmployeeSalary> emp = new List<EmployeeSalary>()
            {
                new EmployeeSalary{name = "ankitha", id = 1, department = "Computer", salary = 15000},
                new EmployeeSalary{name = "Disha", id = 17, department = "Sales", salary = 20000},
                new EmployeeSalary{name = "Shilpa", id = 15, department = "Accountant", salary = 12000},
                new EmployeeSalary{name = "Akhila", id = 8, department = "Computer", salary = 15000},
                new EmployeeSalary{name = "Vaishanvi", id = 19, department = "Sales", salary = 30000},
                new EmployeeSalary{name = "Aishwarya", id = 12, department = "Sales", salary = 27000},
                new EmployeeSalary{name = "Pushpa", id = 10, department = "Computer", salary = 18000},
                new EmployeeSalary{name = "Vijaylaxmi", id = 13, department = "Accountant", salary = 22000}
            };
            return emp;
        }
        public static void FilterBySalary()
        {
            List<EmployeeSalary> empList = GetEmployeeList()
                .Where(sal => sal.salary >= 20000 && sal.department == "Sales")
                .ToList();

            foreach (EmployeeSalary list in empList)
            {
                Console.WriteLine($"Name:{list.name} Id:{list.id} Department:{list.department} Salary:{list.salary}");
            }
        }

        //Using LINQ syntax
        public static void FilterSalaryUsingLINQ()
        {
            List<EmployeeSalary> linqEmpList = (from list in GetEmployeeList()
                                                where list.department == "Sales" && list.salary >= 20000
                                                select list)
                                                .ToList();
            foreach (EmployeeSalary linQlist in linqEmpList)
            {
                Console.WriteLine($"Name:{linQlist.name} Id:{linQlist.id} Department:{linQlist.department} Salary:{linQlist.salary}");
            }

        }
    }
}

