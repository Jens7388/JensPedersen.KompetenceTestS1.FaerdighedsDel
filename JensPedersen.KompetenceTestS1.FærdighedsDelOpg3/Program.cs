using System;

namespace JensPedersen.KompetenceTestS1.FærdighedsDelOpg3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Gæt et tal mellem 1 og 10: ");
                int userNumber = 0;
                Random generator = new Random();
                int correctNumber = generator.Next(1, 10);

                while(userNumber != correctNumber)
                {
                    string input = Console.ReadLine();
                    int.TryParse(input, out userNumber);
                    if(userNumber == correctNumber)
                    {
                        Console.WriteLine("Korrekt!");
                        break;
                    }
                    else
                    {
                        Console.Write("Forkert! Prøv igen: ");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }           
        }
    }
}