using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Student
    {
        //Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI  
        public string Student_Name;
        public long Enrollment_No;
        public int Semester;
        public double CPI;
        public double SPI;

        public Student()
        {
            Console.WriteLine("Enter a Enrollment_No : ");
            Enrollment_No = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Student_Name : ");
            Student_Name = Console.ReadLine();

            Console.WriteLine("Enter a CPI : ");
            CPI = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a SPI : ");
            SPI = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Semester : ");
            Semester = int.Parse(Console.ReadLine());
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Enrollment_No is {Enrollment_No}");
            Console.WriteLine($"Student_Name is {Student_Name}");
            Console.WriteLine($"Semester is {Semester}");
            Console.WriteLine($"CPI is {CPI}");
            Console.WriteLine($"SPI is {SPI}");
        }
    }
}
