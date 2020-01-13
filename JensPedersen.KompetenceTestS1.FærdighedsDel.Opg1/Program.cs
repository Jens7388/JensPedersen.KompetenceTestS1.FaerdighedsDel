using System;

namespace JensPedersen.KompetenceTestS1.FærdighedsDel.Opg1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Skriv dit fornavn: ");
                string firstName = Console.ReadLine();

                Console.Write("Skriv dit efternavn: ");
                string lastName = Console.ReadLine();

                Console.WriteLine($"Du hedder: {firstName} {lastName}");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}