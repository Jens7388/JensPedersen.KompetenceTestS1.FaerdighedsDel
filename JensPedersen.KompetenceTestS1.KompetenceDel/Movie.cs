using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JensPedersen.KompetenceTestS1.KompetenceDel
{
    class Movie
    {

        private string title;
        private int releaseYear;
        private string instructor;
        private string company;

        public Movie(string title, int releaseYear, string instructor, string company)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Instructor = instructor;
            Company = company;
        }

        public string Title { get { return title; } set { title = value; } }
        public int ReleaseYear { get { return releaseYear; } set { releaseYear = value; } }
        public string Instructor { get { return instructor; } set { instructor = value; } }
        public string Company { get { return company; } set { company = value; } }
        
        }
    }

