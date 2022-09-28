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
            string name;
            name = "Kevin";
            int age;
            age = 27;

            YourName(name, age);

            Console.ReadLine();
        }

        static void YourName(string name, int age)
        {
            Console.WriteLine("My name is " + name);
            Console.WriteLine("Age " + age);
        }
    }
}
