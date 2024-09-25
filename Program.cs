using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string confirm;

            do
            {
                Console.WriteLine("Enter the first number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Operation Name");
                string userOperator = Console.ReadLine().ToLower();

                if (userOperator == "+" || userOperator == "add" || userOperator == "addition" || userOperator == "plus" || userOperator == "sum" || userOperator == "increase" || userOperator == "combine" || userOperator == "total")
                {
                    int add = num1 + num2;
                    Console.WriteLine("Result is = {0}", add);
                }
                else if (userOperator == "-" || userOperator == "minus" || userOperator == "subtraction" || userOperator == "subtract" || userOperator == "deduct" || userOperator == "decrease" || userOperator == "remove" || userOperator == "take away")
                {

                    int sub = num1 - num2;
                    Console.WriteLine("Result is = {0}", sub);
                }
                else if (userOperator == "*" || userOperator == "multiply" || userOperator == "times" || userOperator == "product" || userOperator == "scale" || userOperator == "times by" || userOperator == "factor")
                {
                    int multiflying = num1 * num2;
                    Console.WriteLine("Result is = {0}", multiflying);

                }
                else if (userOperator == "/" || userOperator == "divide" || userOperator == "over" || userOperator == "quotient" || userOperator == "fraction" || userOperator == "split" || userOperator == "ratio")
                {
                    int divison = num1 / num2;
                    Console.WriteLine("Result is = {0}", divison);
                }
                else if (userOperator == "%" || userOperator == "mod" || userOperator == "remainder" || userOperator == "div mod" || userOperator == "modulo" || userOperator == "residual" || userOperator == "leftover" || userOperator == "modulus")
                {
                    int modulus = num1 % num2;
                    Console.WriteLine("Result is {0}", modulus);
                }
                else if (userOperator == "power" || userOperator == "exponent" || userOperator == "raise to" || userOperator == "To the power of" || userOperator == "powers" || userOperator == "Square/Cube")
                {
                    int power = num1 ^ num2;
                    Console.WriteLine("Result is = {0}", power);
                }
                else if (userOperator == "fraction of 100" || userOperator == "percent" || userOperator == "proportion" || userOperator == "percentage" || userOperator == "out of 100" || userOperator == " Ratio per hundred" || userOperator == "Percentage calculation")
                {
                    int per = num1 + num2;
                    int percentageTotal = ((num1 + num2) / per) * 100;
                    Console.WriteLine("Result is = {0}", percentageTotal);
                }
                else if (userOperator == "mean" || userOperator == "arithmetic mean" || userOperator == "central tendency" || userOperator == "typical value" || userOperator == "average" || userOperator == "expected value" || userOperator == "median " || userOperator == "mode " || userOperator == "norm" || userOperator == "standard value" || userOperator == "representative value")
                {
                    int sum = num1 + num2;
                    int avg = sum / 2;
                    Console.WriteLine("Result is = {0}", avg);
                }

                Console.WriteLine("Do you want to repeat your program? Yes or No");

                confirm = Console.ReadLine().ToLower();


            } while (confirm == "yes");
        }
    }
}
