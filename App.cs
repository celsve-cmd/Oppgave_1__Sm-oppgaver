using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Oppgave_1__Småoppgaver
{
    internal class App
    {
        public List<Book> Books;

        public App()
        {
            Books = new List<Book> 
            {
                new Book("Of Mice and Men", "John Steinbeck", 1937)
            };
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("1 - Legg til ny bok\n2 - Se bibliotek \n3 - Avslutt");
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        AddBook();
                        break;
                    case ConsoleKey.D2:
                        ShowLibrary();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\n--- Avslutter ---\n");
                        return;
                    default:
                        Console.WriteLine("Prøv igjen!\n");
                        break;
                }
            }
        }


        public void AddBook()
        {
            Console.Clear();
            Console.WriteLine("Book Title: "); 
            string title = Console.ReadLine(); 
            Console.WriteLine("Author: "); 
            string author = Console.ReadLine(); 
            Console.WriteLine("Publication Year: "); 
            int yearOfPublicity = Convert.ToInt32(Console.ReadLine());
            
            var newBook = new Book(title, author, yearOfPublicity); 
            Books.Add(newBook);
            
            Console.WriteLine($"\n{title} er lagt til i listen!"); 
            Console.WriteLine("--- Fortsett ---");
            Console.ReadKey();
            Console.Clear();
        }

        public void ShowLibrary()
        {
            Console.Clear(); 
            Console.WriteLine("--- Bibliotek ---\n"); 
            foreach (var book in Books) 
            { 
                Console.WriteLine($"Tittel: {book.Title}, Forfatter: {book.Author}, År: {book.YearOfPublicity}");
            }
            Console.WriteLine("\n--- Fortsett ---");
            Console.ReadKey();
            Console.Clear();
            }
        }
    }