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
            // we can add additon ( + ), substraction ( - ),
            // division ( / ), multiplication ( * ) 
            // and mod using ( % )
            Console.WriteLine( 5 % 2 );
            // 4 + 2 * 3 = 2 * 3 + 4 = 10
            Console.WriteLine(4 + 2 * 3);
            // if using (4 + 2) * 3 = 18
            Console.WriteLine((4 + 2) * 3);
            // decimal number
            Console.WriteLine(5.0 + 1.1);
            // Math.abs for absolute number
            Console.ReadLine();
        }
    }
}
