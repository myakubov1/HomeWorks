using System;
using HomeWorks.MorseTranslator;
namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MorseToRu MtR = new MorseToRu();
            MtR.Alphabet =new char[] {'1'};
            MtR.Codes = new string[] { "1" };
            Console.WriteLine($"{MtR.Alphabet[0]} | {MtR.Codes[0]} ");
            MtR.Translate();
            Console.WriteLine($"{MtR.Alphabet[0]} | {MtR.Codes[0]} ");
        }
    }
}
