using System;

namespace EmployeeWageProblem
{
    /// <summary>
    /// Contains the Main Method
    /// </summary>
    class Program
    {
        /// <summary>
        /// Displaying the Greeting Message.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");

            //EloyeeCheck.CheckEmployeeAttendance();

            Employeewage.CalculateEmpWage();
        }
    }
}
