using System;
using System.IO;
using System.Text;

namespace JensPedersen.KompetenceTestS1.FærdighedsDelOpg6
{
    class Program
    {
        static string path = @"C:\Users\jens7388\source\repos\JensPedersen.KompetenceTestS1.FærdighedsDel\JensPedersen.KompetenceTestS1.FærdighedsDelOpg6\textfil.txt";
        private static void DisplayMenu()
        {
            Console.WriteLine("Velkommen. Vælg venligst en af følgende muligheder: ");
            Console.WriteLine("1) Se alt indhold i tekstfilen");
            Console.WriteLine("2) Tilføj indhold til tekstfilen");
            Console.WriteLine("3) Afslut programmet");
        }
        private static bool DisplayTextFileContent(string path)
        {
            bool fileExists = File.Exists(path);
            if(fileExists)
            {
                using(StreamReader reader = new StreamReader(path, Encoding.Default))
                {
                    string document = "";
                    while((document = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(document);
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("Stien findes ikke! Prøv igen");
                return false;
            }
        }
        private static bool AddContentToTextFile(string path)
        {
            bool fileExists = File.Exists(path);
            if(fileExists)
            {
                using(StreamWriter sr = File.AppendText(path))
                {
                    Console.Write("Skriv hvad du ønsker at tilføje til tekstfilen: ");
                    string input = Console.ReadLine();
                    sr.WriteLine(input);
                    Console.WriteLine($"Du har tilføjet følgende tekst: {input}");
                    sr.Close();

                }
                return true;
            }
            else
            {
                Console.WriteLine("Stien findes ikke! Prøv igen");
                return false;
            }
        }
        private static void Main()
        {
            while(true)
            {
                DisplayMenu();
                string input = Console.ReadLine();
                if(input == "1")
                {
                    DisplayTextFileContent(path);
                }
                else if(input == "2")
                {
                    AddContentToTextFile(path);
                }
                else if(input == "3")
                {
                    Console.WriteLine("Farvel");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ugyldigt input! Prøv igen");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
