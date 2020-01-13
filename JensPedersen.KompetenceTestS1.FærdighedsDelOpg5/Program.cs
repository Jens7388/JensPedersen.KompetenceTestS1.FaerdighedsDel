using System;

namespace JensPedersen.KompetenceTestS1.FærdighedsDelOpg5
{
    class Program
    {
        static void Main(string[] args)
        {
                DateTime firstPersonBirthDate = new DateTime(1990, 01, 09);

                Person firstPerson = new Person("Jens", "Jensen", firstPersonBirthDate);

                firstPerson.BirthDate = firstPersonBirthDate; 

                firstPerson.CalcAge(firstPerson.BirthDate);
                Console.WriteLine("Første person:");
                firstPerson.PrintInfo();

                DateTime secondPersonBirthDate = new DateTime(1990, 01, 08);

                Person secondPerson = new Person("Peder", "Pedersen", secondPersonBirthDate);

                secondPerson.BirthDate = secondPersonBirthDate;

                secondPerson.CalcAge(secondPerson.BirthDate);
                Console.WriteLine("Anden person:");
                secondPerson.PrintInfo();
                Console.ReadLine();
        }
    }
}