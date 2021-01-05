//ID: 1775227
//Name: Marissa Goncalves
//Assignment 1 - Problem 2: EmployeeTest app

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {

            //Create new objects with different values from the Employee class
            Employee one = new Employee("Fred", "Andrews", 6258.80m);
            Employee two = new Employee("Daniel", "Graham", 3698.34m);
            Employee three = new Employee("Mike", "Frank", -320.23m);

            //Skip a line
            Console.WriteLine();

            //Print a title before showing the initial employee records
            Console.WriteLine("Initial Employee Records");

            //Call each object to this method, to display the records in an organized table
            one.DisplayEmployeeRecord();
            two.DisplayEmployeeRecord();
            three.DisplayEmployeeRecord();

            //Skip a line
            Console.WriteLine();


            //Call each object in this method, to raise the monthly salary by 10%
            one.Raised10Percent();
            two.Raised10Percent();
            three.Raised10Percent();


            //Skip a line
            Console.WriteLine();

            //Print a title before showing the employee records after the 10% raise
            Console.WriteLine("Employee Records After 10% Raise");


            //Call each object to this method, to display the records in an organized table again to test the Raised10Percent() method
            one.DisplayEmployeeRecord();
            two.DisplayEmployeeRecord();
            three.DisplayEmployeeRecord();

        }
    }
}
