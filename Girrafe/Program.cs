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
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall man");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are a tiny man");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            } else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }

            Console.ReadLine();
        }
    }
}
