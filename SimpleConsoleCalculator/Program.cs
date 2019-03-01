using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleCalculator
{
    class Program : CalculatorMethods
    {

        static void Main(string[] args)
        {
         
            int num1, num2;
            Console.WriteLine("Simple Console Calculator for integers in C#");
            Console.WriteLine("--------------------------------------------");


        Start:
            Console.Write("\n");
            Console.Write("Type first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose what you want to do:");
            Console.WriteLine("Type \"s\" to subtract");
            Console.WriteLine("Type \"a\" to add");
            Console.WriteLine("Type \"m\" to multiply");
            Console.WriteLine("Type \"d\" to divide");
            Console.Write("Your choice?: ");

            switch (Console.ReadLine())
            {
                case "s": Console.WriteLine($"Youe result of subtract {num1} and {num2} = " + CalculatorMethods.Subtract(num1,num2)); break;
                case "a": Console.WriteLine($"Youe result of add {num1} and {num2} = " + CalculatorMethods.Add(num1, num2)); break;
                case "m": Console.WriteLine($"Youe result of multiply {num1} and {num2} = " + CalculatorMethods.Multiply(num1, num2)); break;
                case "d": Console.WriteLine($"Youe result of divide {num1} and {num2} = " + CalculatorMethods.Divide(num1, num2)); break;

            }

            //Console.Write("Would you close this application? (y/n): ");
            //if (Console.ReadLine() == "y")
            //{
            //    Environment.Exit(0);
            //} else if (Console.ReadLine() == "n") {
            //    Console.WriteLine("You choose n ");
            //    goto Start;
            //}


            Console.ReadKey();

            
        }
    }
}
