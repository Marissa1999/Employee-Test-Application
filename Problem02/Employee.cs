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
    class Employee
    {

        //Initialize the instance variables of the Employee class
        private string firstName;
        private string lastName;
        private decimal monthlySalary;


        //Main constructor for the Employee class that takes all inputted values in the parameter
        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }


        //Implicit property for the first name
        public string FirstName
        {
            get; set;
        }


        //Implicit property for the last name
        public string LastName
        {
            get; set;
        }




        //Property for the monthly salary
        public decimal MonthlySalary
        {

            get
            {
                //Return the monthly salary
                return this.monthlySalary;
            }

            set
            {
                //If the value is less than 0.0, set the monthly salary to 0.0
                if (value < 0.0m)
                {
                    this.monthlySalary = 0;
                }

                //Or else, the monthly salary is set to the value
                else
                {
                    this.monthlySalary = value;
                }

            }


        }


        //Returns the monthly salary with a 10% raise
        public decimal Raised10Percent()
        {
            return MonthlySalary *= 1.10m;
        }



        //Using string interpolation, display the employee record with the object values
        public void DisplayEmployeeRecord()
        {

            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"|            Employee Record             |");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"| First Name      |  {FirstName,-20}|");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"| Last Name       |  {LastName,-20}|");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"| Monthly Salary  |  {MonthlySalary,-20:C}|");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine();
        }




    }
}
