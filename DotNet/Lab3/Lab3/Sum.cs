using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
   abstract internal class Sum
    {
        public abstract void SumOfTwo(int a, int b);
        public abstract void SumOfThree(int a, int b, int c);
    }

    class Calculate : Sum
    {
        public override void SumOfTwo(int a, int b)
        {
            Console.WriteLine(a+b);  
        }
        public override void SumOfThree(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }

}
