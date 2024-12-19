using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Account_Details
    {
        public int Account_No;
        public double P ;
        public double R ;
        public double N ;

        public void Account_Details1()
        {
            Console.WriteLine("Enter a Account_No : ");
            Account_No = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value of P : ");
            P = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value of R : ");
            R = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value of N : ");
            N = double.Parse(Console.ReadLine());
        }
    }

    internal class Interest : Account_Details
    {
        public double ans;
        public void Interest1()
        {

            ans = (P * R * N) / 100;

            Console.WriteLine($"Interest is {ans}");
        }
    }
}
