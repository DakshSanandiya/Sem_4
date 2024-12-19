using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class AreaofRectangle
    {
        public AreaofRectangle()
        {
            Console.WriteLine("Enter length :");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width :");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine($"area of Rectangle is {length * width}");
        }
    }
}
