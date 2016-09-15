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
            //Declaring a variable of type Employee (which is a class) and
            //instanciating a new instance of Employee and assigning it to the variable
            //Using the NEW keyword means that memory will get allocated on the Heap for that class
                Employee myEmployee = new Employee();
            //Use the properties to assign values.
            myEmployee.FirstName = "Sue";
                myEmployee.LastName = "Mumma";
                myEmployee.WeeklySalary = 2048.34m;

            //Output the entire employee, which will call the ToString method implicitly
            //This would work even without overriding the ToString method in the Employee class,
            //however it would only spit out the namespace and anme of the class instead of something useful.
                Console.WriteLine("Hi, my name is: " + myEmployee);
                Console.WriteLine("This is my salary: " + myEmployee.WeeklySalary);

            //Create an array of type Employee to hold a bunch of Employees.
                Employee[] employees = new Employee[10];
            //Assign values to the array.  Each spot needs to contain an instance of an Employee
                employees[0] = new Employee("James", "Kirk", 453.00m);
                employees[1] = new Employee("Jean-Luc", "Picard", 434.00m);
                employees[2] = new Employee("James", "Avery", 353.00m);
                employees[3] = new Employee("Kathryn", "Janeway", 653.00m);
                employees[4] = new Employee("Johnnie", "Bianco", 253.00m);
                employees[5] = new Employee("Lorrie", "Anderson", 2153.00m);
                employees[6] = new Employee("Bob", "Wilcox", 853.00m);
                employees[7] = new Employee("Indigo", "Anthony", 753.00m);

            //A foreach loop.  It is useful for doing a collection of objects.
            //Each object in the array 'Employees' will get assigned to the local
            //variable 'employee' inside the loop.
                foreach (Employee employee in employees)
                {
                //Run a check to make sure the spot in the array is not empty.
                    if (employee != null)
                    {
                    //Print the employee 
                        Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());
                    }
                }
            Userinterface ui = new Userinterface();

            int choice = ui.GetUserInput();

            while (choice != 2)
            {
                if(choice == 1)
                {
                    string allOutput = "";
                    //Loop through all the employees just like above only instead of
                    //writing out the employees, we are concating them together.
                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            allOutput += employee.ToString() + " " +
                                employee.YearlySalary() +
                                Environment.NewLine;
                        }
                    }
                    //Once the concat is done, have the UI class print out the result
                    ui.PrintAllOutput(allOutput);
                }
                //Get the next choice from the user.
                choice = ui.GetUserInput();
            }
        }
       
        }
    
    }