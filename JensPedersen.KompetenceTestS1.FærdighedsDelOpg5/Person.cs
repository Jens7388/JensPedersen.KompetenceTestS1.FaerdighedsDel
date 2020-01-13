using System;
using System.Collections.Generic;
using System.Text;

namespace JensPedersen.KompetenceTestS1.FærdighedsDelOpg5
{
    class Person
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private TimeSpan age;
        private int ageYears;

        public Person(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        public TimeSpan Age { get { return age; } set { age = value; } }
        public int AgeYears { get { return ageYears; } set { ageYears = value; } }
        public void CalcAge(DateTime birthDate)
        {
            age = DateTime.Now.Subtract(birthDate);
            for(ageYears = 0; ageYears < age.TotalDays / 365.25 - 1; ageYears++)
            {

            }
        }

        public void PrintInfo()
        {            
            Console.WriteLine($"Fornavn: {firstName}");
            Console.WriteLine($"Efternavn: {lastName}");
            //året 0001 bliver udskrevet hvis datoen er ugyldig 
            if(birthDate.Year == 0001 || birthDate > DateTime.Now)
            {
                Console.WriteLine("Denne fødselsdato er ugyldig! Prøv igen");
            }
            else
            {
                Console.WriteLine($"Fødselsdato: {birthDate.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Alder: {ageYears} år\n");
            }
        }
    }
}