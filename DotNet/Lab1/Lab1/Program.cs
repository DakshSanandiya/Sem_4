
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number bitween 1-10 :");
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            //1. Write a program to print your name, address, contact number & city.

            Console.WriteLine("name = Daksh Sanandiya \naddress = Darshan University -Rajkot \n" +
                "contact number : 1234567890 \ncity : Morbi");

        }

        else if (n == 2)
        {
            //2. Write a program to get two numbers from user and print those numbers.
            Console.WriteLine("Enter a number :");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number :");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Frist number : {n1} \nSecond Number : {n2}");
        }

        else if (n == 3)
        {
            //Write program to prompt a user to input his/her name and country name and then
            //output will be shown as given: Hello<yourname> from country <countryname>

            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your country :");
            string country = Console.ReadLine();

            Console.WriteLine($"Hello {name} from country {country}");
        }

        else if (n == 4)
        {
            //4. Write a program to calculate the size of the area in square-feet based on
            // Specified length and width.
            Console.WriteLine("Enter length :");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width :");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine($"area in square-feet is {length * width}");
        }
        else if (n == 5)
        {
            // 5.Write a program to calculate area of Square, Rectangle and Circle.
            Console.WriteLine("Enter (1-3) \n1 = : area of Square \n2 = area of Rectangle\n3 = area of Circle");
            int i = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                Console.WriteLine("Enter length :");
                int length = int.Parse(Console.ReadLine());

                Console.WriteLine($"area of Square is {length * length}");
            }
            else if (i == 2)
            {
                Console.WriteLine("Enter length :");
                int length = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter width :");
                int width = int.Parse(Console.ReadLine());

                Console.WriteLine($"area of Rectangle is {length * width}");
            }
            else if (i == 3)
            {
                Console.WriteLine("Enter redius :");
                int redius = int.Parse(Console.ReadLine());

                Console.WriteLine($"area of Circle : {2 * 3.14 * redius * redius}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        else if (n == 6)
        {
            //6. Write a program to calculate Celsius to Fahrenheit and vice-versa using
            //function.
            Console.WriteLine("Enter (1-2) \n1 = CelsiusToFahrenheit\n2 = FahrenheitToCelsius");
            int j = int.Parse(Console.ReadLine());
            if (j == 1)
            {
                CelsiusToFahrenheit();
            }
            else if (j == 2)
            {
                FahrenheitToCelsius();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        else if (n == 7)
        {
            //7. Write a program to find out Simple Interest using function. (I = PRN/100) 
            Program intrest = new Program();
            intrest.SimpleInterest();
        }




        else
        {
            Console.WriteLine("Invalid Input");
        }
    }

    // for program 6 
    public static void CelsiusToFahrenheit()
    {
        Console.WriteLine("Enter a value of Celsius :");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine($"value of Fahrenheit is {c * (9 / 5) + 32}");
    }
    public static void FahrenheitToCelsius()
    {
        Console.WriteLine("Enter a value of Fahrenheit :");
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine($"value of Celsius is {(f - 32) * (5 / 9)}");
    }

    // for program 7

    public void SimpleInterest()
    {
        Console.WriteLine("Enter a value of P :");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a value of R :");
        int r = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a value of N :");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Simple Interest is {(p * r * n) / 100}");
    }
}
