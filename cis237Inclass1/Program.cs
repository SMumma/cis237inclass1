using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
        class Program
        {
            static void Main(string[] args)
            {
                Employee myEmployee = new Employee();
                myEmployee.FirstName = "Sue";
                myEmployee.LastName = "Mumma";
                myEmployee.WeeklySalary = 2048.34m;

                Console.WriteLine("Hi, my name is: " + myEmployee);
                Console.WriteLine("This is my salary: " + myEmployee.WeeklySalary);

                Employee[] employees = new Employee[10];

                employees[0] = new Employee("James", "Kirk", 453.00m);
                employees[1] = new Employee("Jean-Luc", "Picard", 434.00m);
                employees[2] = new Employee("James", "Avery", 353.00m);
                employees[3] = new Employee("Kathryn", "Janeway", 653.00m);
                employees[4] = new Employee("Johnnie", "Bianco", 253.00m);
                employees[5] = new Employee("Lorrie", "Anderson", 2153.00m);
                employees[6] = new Employee("Bob", "Wilcox", 853.00m);
                employees[7] = new Employee("Indigo", "Anthony", 753.00m);

                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());
                    }
                }
            }
        }
    }