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
            string phrase;
            phrase = "Fundamental C#";
            // \n for new line
            Console.WriteLine("My Name is Arthur\nand My name is Richard");
            // \" for add double quote
            Console.WriteLine("Rose is \"Red\"" + " and violet is \'purple\'");
            // \t for horizontal tab
            Console.WriteLine("Link\tMove");
            // for more info can see on learn.microsoft dotnet/csharp
            // how get length on string
            Console.WriteLine(phrase.Length);
            // make string to Caps
            Console.WriteLine(phrase.ToUpper());
            // and this for lower string
            Console.WriteLine(phrase.ToLower());
            // using contains, return true, because C# it does.
            Console.WriteLine(phrase.Contains("C#"));
            // using indexOf to tell us what index position C# start inside, return 12
            Console.WriteLine(phrase.IndexOf("C#"));
            // get string using index position, and length,
            // return C cause we start from index 12 and just put 1 length
            Console.WriteLine(phrase.Substring(12, 1));
            Console.ReadLine();
        }
    }
}
