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
            string name, age;
            // Writes the text representation
            // of the specified value or values to the standard output stream.
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " your age is " + age);

            Console.ReadLine();

        }
    }
}
