using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girrafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double is number decimal
            double num1, num2;
            Console.Write("Enter a number: ");
            // Convert string to double number decimal
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // addition num1 + num2
            Console.WriteLine(num1 + num2);

            // show result num1 + num2
            Console.ReadLine();
        }
    }
}
