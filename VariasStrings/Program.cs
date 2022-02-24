using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "Um tab\t e um copyright\u03A9";
            string frase2 = @"Um tab\t e um copyright\u03A9";
            string frase3 = "\u000A";

            Console.WriteLine(frase1);
            Console.WriteLine(frase2);
            Console.WriteLine(frase3);
        }
    }
}
