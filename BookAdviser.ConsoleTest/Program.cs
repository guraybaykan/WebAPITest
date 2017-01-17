using BookAdviser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BookAdviserUnitOfWork work = new BookAdviserUnitOfWork();
            Book b = new Book
            {
                Name = "1984",
                Author = new Author { Name = "George Orwell" },
                Price = 19.76M,
                Publisher = new Publisher { Name = "Can Yayınları" },
                LanguageID = "TR",
                Translator = new Author { Name = " Celal Üster" },
                PublishYear = 2016,
            };
            work.Books.Add(b);
        }
    }
}
