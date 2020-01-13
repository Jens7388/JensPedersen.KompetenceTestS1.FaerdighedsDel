using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JensPedersen.KompetenceTestS1.KompetenceDel
{
    class Program
    {
        static List<Movie> movieList = new List<Movie>();

        //Sti til tekstfilen
        static string path = @"C:\Users\jens7388\source\repos\JensPedersen.KompetenceTestS1.FærdighedsDel\JensPedersen.KompetenceTestS1.KompetenceDel\film.txt";

        //Indlæs alle film på tekstfilen
        private static bool LoadMovies()
        {
            bool fileExists = File.Exists(path);
            if(fileExists)
            {
                using(FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using(StreamReader reader = new StreamReader(fileStream))
                    {
                        while(!reader.EndOfStream)
                        {
                            string lines;
                            while((lines = reader.ReadLine()) != null)
                            {
                                try
                                {
                                    string[] info = lines.Split(",");
                                    int.TryParse(info[1], out int year);

                                    Movie movie = new Movie(info[0], year, info[2], info[3]);
                                    movieList.Add(movie);
                                }
                                //Forhindrer at programmet crasher pga mellemrum i tekstfilen
                                catch(IndexOutOfRangeException)
                                {

                                }
                            }
                        }
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("ADVARSEL.\nFilen kunne ikke indlæses!");
                return false;
            }
        }
        //hovedmenu
        private static void MainMenu()
        {
            Console.WriteLine("Velkommen. Vælg venligst en af følgende muligheder: ");
            Console.WriteLine("1) Tilføj en film");
            Console.WriteLine("2) Se alle tilføjede film");
            Console.WriteLine("3) Søg på en film");
            Console.WriteLine("4) Afslut");
        }

        //Tilføj film
        private static bool AddMovie()
        {
            bool fileExists = File.Exists(path);
            if(fileExists)
            {
                using(StreamWriter sr = File.AppendText(path))
                {
                    Console.Write("Indtast filmens titel: ");
                    string title = Console.ReadLine();

                    Console.Write("Indtast filmens udgivelsesår: ");
                    string releaseYearInput = Console.ReadLine();
                    int.TryParse(releaseYearInput, out int releaseYear);

                    Console.Write("Indtast filmens instruktør: ");
                    string instructor = Console.ReadLine();

                    Console.Write("Indtast filmens selvskab: ");
                    string studio = Console.ReadLine();

                    Movie newMovie = new Movie(title, releaseYear, instructor, studio);
                    string input = newMovie.Title + "," + newMovie.ReleaseYear + "," + newMovie.Instructor + "," + newMovie.Company + ",";
                    movieList.Add(newMovie);
                    sr.WriteLine(input);
                    Console.WriteLine("Film tilføjet!");
                    sr.Close();
                }
                return true;
            }
            else
            {
                Console.WriteLine("Stien findes ikke! Prøv igen.");
                return false;
            }
        }
        //Se alle film på listen
        private static bool ViewAllMovies()
        {
            bool fileExists = File.Exists(path);
            if(fileExists)
            {
                Console.WriteLine("\nAlle film: ");
                foreach(Movie movie in movieList)
                {
                    Console.WriteLine($"Titel: {movie.Title}");
                    Console.WriteLine($"Udgivelsesår: {movie.ReleaseYear}");
                    Console.WriteLine($"Instruktør: {movie.Instructor}");
                    Console.WriteLine($"Selvskab: {movie.Company}\n");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Stien findes ikke! Prøv igen.");
                return false;
            }
        }
        //Søg efter film
        private static bool SearchForMovie()
        {
            bool fileExists = File.Exists(path);
            if(fileExists)
            {
                Console.Write("Skriv titlen du vil søge på: ");
                string input = Console.ReadLine().ToLower();
                IEnumerable<Movie> result = movieList.Where(movie => movie.Title.ToLower().Contains(input.ToLower()));
                Console.WriteLine("\nResultatet af din søgning:");
                foreach(Movie movie in result)
                {
                    Console.WriteLine($"Titel: {movie.Title}");
                    Console.WriteLine($"Udgivelsesår: {movie.ReleaseYear}");
                    Console.WriteLine($"Instruktør: {movie.Instructor}");
                    Console.WriteLine($"Selvskab: {movie.Company}\n");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Stien findes ikke! Prøv igen.");
                return false;
            }
        }

        private static void Main()
        {
            LoadMovies();
            while(true)
            {
                MainMenu();
                string input = Console.ReadLine();
                if(input == "1")
                {
                    AddMovie();
                }
                else if(input == "2")
                {
                    ViewAllMovies();
                }
                else if(input == "3")
                {
                    SearchForMovie();
                }
                else if(input == "4")
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
