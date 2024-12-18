using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Staff
    {
        public string StaffName;
        public string StaffDepartment;
        public string StaffDesignation;
        public string StaffExperience;
        public int StaffSalary;

        public void GetStaffData()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter a Name : ");
            StaffName = Console.ReadLine();

            Console.Write("Enter a Department : ");
            StaffDepartment = Console.ReadLine();

            Console.Write("Enter a Designation : ");
            StaffDesignation = Console.ReadLine();

            Console.Write("Enter a Experience : ");
            StaffExperience = Console.ReadLine();

            Console.Write("Enter a Salary : ");
            StaffSalary = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------");

        }
        public void DisplayStaff()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Staff Name is {StaffName}");
            Console.WriteLine($"Staff Salary is {StaffSalary}");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
