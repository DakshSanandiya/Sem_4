using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("Enter a initialBalance");
            float initialBalance = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a accountHolderName");
            float accountHolderName = float.Parse(Console.ReadLine());
        }
        public void Deposite(int cash)
        {
            Console.WriteLine("Deposite With cash");
        }
        public void Deposite(float check)
        {
            Console.WriteLine("Deposite With check");
        }
        public void withdraw(float check)
        {
            Console.WriteLine("withdraw With check");
        }

        public void withdraw(int cash)
        {
            Console.WriteLine("withdraw With cash");
        }
    }
}
