using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Bank_Account
    {
        public int Account_No;
        public string Email;
        public string Name;
        public string Account_Type;
        public int Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter a Account_No : ");
            Account_No = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Email : ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter a Name : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter a Account_Type : ");
            Account_Type = Console.ReadLine();

            Console.WriteLine("Enter a Account_Balance : ");
            Account_Balance = int.Parse(Console.ReadLine());
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account_No is {Account_No}");
            Console.WriteLine($"Email is {Email}");
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Account_Type is {Account_Type}");
            Console.WriteLine($"Account_Balance is {Account_Balance}");
        }
    }
}
