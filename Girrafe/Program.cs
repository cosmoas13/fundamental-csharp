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
            /*int[] luckyNumbers = { 4, 8, 15, 16, 23, 44 };
            for (int i = 1; i <= luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }*/
/*            Console.WriteLine(GetPow(3, 2));*/
            Console.WriteLine(GetFac(3));
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

        static int GetFac(int res)
        {
            int num = 1;
            int result = 1;
            for (int i = 0; i < res; i++)
            {
                result = result * num;
                num = num + 1;
            }
            return result;
        }
    }
}
