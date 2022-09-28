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
            int[] luckyNumbers = { 4, 15, 13, 5, 3, 66 };
            // can hold 1 array item
            string[] friends = new string[1];
            friends[0] = "Kevin";
            // display error cause array can handle 1 array
            // friends[1] = "albert";

            // assign new array into index 1, so 15 replace 900
            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[0]);
            Console.ReadLine();
        }
    }
}
