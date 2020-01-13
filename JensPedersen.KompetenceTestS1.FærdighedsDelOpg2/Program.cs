using System;

namespace JensPedersen.KompetenceTestS1.FærdighedsDelOpg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De første 10 tal i 7 tabellen:");
            for(int i = 7; i <= 7 * 10; i += 7)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}