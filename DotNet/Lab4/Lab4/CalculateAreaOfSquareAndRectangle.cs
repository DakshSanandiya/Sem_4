using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class CalculateAreaOfSquareAndRectangle
    {
        public void area(float l)
        {
            Console.WriteLine($"Area Of Square is {l*l}");
        }
        public void area(float l, float b)
        {
            Console.WriteLine($"Area Of Square is {l * b}");
        }
    }
}
