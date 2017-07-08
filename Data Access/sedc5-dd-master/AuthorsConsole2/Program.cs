using AuthorEntities2;
using AuthorsDataAccess2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsConsole2
{
    class Program
    {
        private static string connectionString;

        static void Main(string[] args)
        {
            connectionString = ConfigurationManager.ConnectionStrings["BooksDb"].ConnectionString;
            var loader = new AuthorsRepository(connectionString);

            while (true)
            {
                Console.WriteLine("1) Get all authors");
                Console.WriteLine("2) Get authors by name");
                Console.WriteLine("3) Get author by ID");
                Console.WriteLine("4) Add new author");
                var choice = Console.ReadLine();
                if (choice == "2")
                {
                    Console.Write("Enter name fragment: ");
                    var fragment = Console.ReadLine();
                    var results = loader.GetAuthorsByName(fragment);
                    PrintAuthors(results);
                }
                else if (choice == "1")
                {
                    var results = loader.GetAllAuthors();
                    PrintAuthors(results);
                }
                else if (choice == "3")
                {
                    Console.Write("Enter Id: ");
                    var fragment = Int32.Parse(Console.ReadLine());
                    var result = loader.GetAuthorById(fragment);
                    PrintAuthor(result);
                }

            }

        }
        private static void PrintAuthors(IEnumerable<Author> authors)
        {
            foreach (var author in authors)
            {
                Console.WriteLine(author);
            }
        }
        private static void PrintAuthor(Author author)
        {
                Console.WriteLine(author);
        }
    }
}
