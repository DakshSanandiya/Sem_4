using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class FindArea
    {
        public void area(int r)
        {
            Console.WriteLine($"Area of Circle is {3.14*r*r}");
        }
        public void area(float l)
        {
            Console.WriteLine($"Area of Circle is {l*l}");
        }
        public void area(float l, float b)
        {
            Console.WriteLine($"Area of Circle is {l * b}");
        }
    }
}
