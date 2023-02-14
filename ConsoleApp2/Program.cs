using System;
using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber , secondNumber;
            string action;

            Console.WriteLine("Input firstnumber : ");

            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Input secondnumber : ");

            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Input action +,-,*,/");
            
            action = Console.ReadLine();

            if (action == "+")
            {
                double resultadd = firstNumber + secondNumber;

                Console.WriteLine(firstNumber + " + " + secondNumber + " = " + resultadd);
            }
            else if (action == "-")
            {
                double resultsub = firstNumber - secondNumber;

                Console.WriteLine(firstNumber + " - " + secondNumber + " = " + resultsub);
            }
            else if (action == "*")
            {
                double resultmult = firstNumber * secondNumber;
                Console.WriteLine(firstNumber + " * " + secondNumber + " = " + resultmult);
            }
            else if (action == "/")
            {
                double resultdiv = firstNumber / secondNumber;

                Console.WriteLine(firstNumber + " / " + secondNumber + " = " + resultdiv);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
