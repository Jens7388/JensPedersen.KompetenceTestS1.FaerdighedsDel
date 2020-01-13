using System;

namespace JensPedersen.KompetenceTestS1.FærdighedsDelOpg4
{
    class Program
    {
        private static void Calculation(double firstNumber, double secondNumber)
        {
            Console.WriteLine("Resultater: ");

            double result = firstNumber + secondNumber;
            Console.WriteLine($"Addition: {firstNumber} + {secondNumber} = {result}");

            result = firstNumber - secondNumber;
            Console.WriteLine($"Subtraktion: {firstNumber} - {secondNumber} = {result}");

            result = firstNumber * secondNumber;
            Console.WriteLine($"Multiplikation: {firstNumber} * {secondNumber} = {result}");

            if(firstNumber != 0 && secondNumber != 0)
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"Division: {firstNumber} / {secondNumber} = {result}");

                result = firstNumber % secondNumber;
                Console.WriteLine($"Modulus: {firstNumber} % {secondNumber} = {result}");
            }
            else
            {
                Console.WriteLine("Division og modulus er ikke muligt da et af tallene er 0");
            }        
            Console.ReadLine();
        }
        private static void Main()
        {
            Console.WriteLine("Indtast 2 tal, og få addition, subtraktion, multiplikation, division og modulus udregnet.");
            Console.Write("Indtast første tal: ");
            string input = Console.ReadLine();
            double.TryParse(input, out double firstNumber);

            Console.Write("Indtast andet tal: ");
            input = Console.ReadLine();
            double.TryParse(input, out double secondNumber);

            Calculation(firstNumber, secondNumber);
        }
    }
}