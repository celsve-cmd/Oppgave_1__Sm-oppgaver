using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Oppgave_1__Småoppgaver
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublicity { get; set; }

        public Book(string title, string author, int yearOfPublicity)
        {
            Title = title;
            Author = author;
            YearOfPublicity = yearOfPublicity;
        }
    }
}
