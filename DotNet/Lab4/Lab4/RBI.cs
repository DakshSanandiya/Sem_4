using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class RBI
    {
        public void calculateInterest(float p,float r, float n)
        {
            Console.WriteLine($"RBI interest is {(p*r*n)/100}");
        }
    }
    internal class HDFC : RBI
    {
       public void calculateInterest(float p, float r, float n)
        {
            Console.WriteLine($"HDFC interest is {(p * r * n) / 100}");
        }
    }
    internal class SBI : RBI
    {
        public void calculateInterest(float p, float r, float n)
        {
            Console.WriteLine($"SBI interest is {(p * r * n) / 100}");
        }
    }
    internal class ICICI : RBI
    {
        public void calculateInterest(float p, float r, float n)
        {
            Console.WriteLine($"ICICI interest is {(p * r * n) / 100}");
        }
    }
}
