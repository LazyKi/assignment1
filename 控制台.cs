using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double n = 0;
            double d = 0;
            double result;
            Console.Write("Please input the first number: ");
            s=Console.ReadLine();
            n = Double.Parse(s);
            Console.Write("Enter the operator (+, -, *, /): ");
            string operation = Console.ReadLine();
            Console.Write("Please input the second number: ");
            s = Console.ReadLine();
            d = Double.Parse(s);
            switch (operation)
            {
                case "+":
                    result = n + d;
                    break;
                case "-":
                    result = n - d;
                    break;
                case "*":
                    result = n * d;
                    break;
                case "/":
                    if (d != 0)
                    {
                        result = n / d;
                    }//除数不能为0判定
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero");
                        Console.ReadKey();
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    Console.ReadKey();
                    return;

            }
            Console.WriteLine("the answer is  " + result);
            Console.ReadKey();
        }
    }
}
