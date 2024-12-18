using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a program number (1-7) : ");
            int programNO = int.Parse(Console.ReadLine());

            if (programNO == 1)
            {
                int a = 5;
                int b = 0;

                try
                {
                    Console.WriteLine(a / b);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    Console.WriteLine(a / b);
                }
            }
            else if (programNO == 2)
            {
                int[] arr = new int[5];


                try
                {
                    for (int i = 0; i <= arr.Length; i++)
                    {
                        arr[i] = i;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (programNO == 3)
            {
                Calculate calculate = new Calculate();

                calculate.SumOfThree(5, 6, 0);
                calculate.SumOfTwo(5, 6);
            }
            else if (programNO == 4)
            {
                Results s1 = new Answer();

                int x = s1.add(5, 4);
                int y = s1.sub(5, 4);

                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            else if (programNO == 5)
            {
                String x = "Haril Parmar";

                string p = "Haril ";
                string q = "Parmar";

                String a = x.ToUpper();
                Console.WriteLine("Upper Case : " + a);

                String b = x.ToLower();
                Console.WriteLine("Lower Case : " + b);

                int c = x.Length;
                Console.WriteLine("Length of String  : " + c);

                string d = x.Substring(0, 4);
                Console.WriteLine("Substring : " + d);

                String e = String.Concat(p, q);
                Console.WriteLine("Concate : " + e);

                int f = x.IndexOf("a");
                Console.WriteLine("Index of a : " + f);

            }
            else if (programNO == 6)
            {
                CaseChanger c1 = new CaseChanger();

                String x = Console.ReadLine();
                String Y = c1.Change(x);

                Console.WriteLine(Y);
            }
            else if (programNO == 7)
            {
                Shape a1 = new Shape();

                double x = a1.AreaOfCircle(3);
                double y = a1.AreaOfSquare(3);
                double z = a1.AreaOfTriangle(3, 4);

                Console.WriteLine("Area of Circle is : " + x);
                Console.WriteLine("Area of Sqaure is : " + y);
                Console.WriteLine("Area of Triangle is : " + z);
            }
        }
    }
}
