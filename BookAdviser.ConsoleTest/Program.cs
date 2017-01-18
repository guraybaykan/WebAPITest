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
            using (BookAdviserEntities context = new BookAdviserEntities())
            {
                User u = new User();
                u.Name = "asdf";
                u.Email = "sinem@sinem.com";
                u.Password = "5";

                List l = new List
                {
                    Name = "lisreyte",

                };

                var book = context.Books.FirstOrDefault(x => x.ID == 1);
                l.Books.Add(book);
                l.User = u;
                context.Users.Add(u);
                context.Lists.Add(l);
                context.SaveChanges();


                var r = context.Lists.FirstOrDefault();
                r.Books.Remove(r.Books.FirstOrDefault());
            }

            try
            {
                BookAdviserUnitOfWork work = new BookAdviserUnitOfWork();
                var books = work.Books.GetAll();

                List<BookDTO> dtos = new List<BookDTO>();

                //foreach(var book in books)
                //{
                //    //BookDTO b = (BookDTO) book;
                //    dtos.Add(b);
                //}

                //var list  = books.Cast<BookDTO>();
                //foreach(var l in list)
                //{

                //}

                var t = 6;
                //foreach(var book in books)
                //{
                //    var dto = new BookDTO { 
                //        Name=book.Name,
                //        AuthorName=book.Author.Name,
                //        Publisher=book.Publisher.Name,
                //        Abstract=book.Abstract,
                //        Language=book.Language.Name,
                //        PublishYear=book.PublishYear,
                //        Price=book.Price,
                //        ISBN=book.ISBN,
                //    };
                //    if(book.Translator!=null)
                //    {
                //        dto.TranslatorName = book.Translator.Name;
                //    }

                    
                //    dtos.Add(dto);
                    
                //}

                //books.Select(x => new BookDTO
                //    {
                //        Name = x.Name,
                //        AuthorName = x.Author.Name,
                //        Publisher = x.Publisher.Name,
                //        Abstract = x.Abstract,
                //        Language = x.Language.Name,
                //        PublishYear = x.PublishYear,
                //        Price = x.Price,
                //        ISBN = x.ISBN,
                //        TranslatorName = x.Translator == null ? null : x.Translator.Name 
                //    }).ToArray();

               // book.Price = 75M;
               //work.Books.Add(book);
               // work.Complete();
               

                //Book b = new Book
                //{
                //    Name = "Huzursuzluk",
                //    Author = new Author { Name = "Zülfi Livaneli" },
                //    Price = 11.25M,
                //    Publisher = new Publisher { Name = "Doğan Kitap" },
                //    LanguageID = "TR",
                //  //  Translator = new Author { Name = " Celal Üster" },
                //    PublishYear = 2016,
                //};
                //work.Books.Add(b);
                //work.Complete();


            }
            catch (Exception ex)
            {
                var x = ex as System.Data.Entity.Validation.DbEntityValidationException;
            }
        }

        class BookDTO 
        {
            public static implicit operator BookDTO(Book book)
            {
                BookDTO dto = new BookDTO
                {
                    Name = book.Name,
                    AuthorName = book.Author.Name,
                    Publisher = book.Publisher.Name,
                    Abstract = book.Abstract,
                    Language = book.Language.Name,
                    PublishYear = book.PublishYear,
                    Price = book.Price,
                    ISBN = book.ISBN,
                };

                if (book.Translator != null)
                {
                    dto.TranslatorName = book.Translator.Name;
                }


                return dto;
            }

            //public static explicit operator BookDTO(Book book)
            //{
            //    BookDTO dto = new BookDTO
            //    {
            //        Name = book.Name,
            //        AuthorName = book.Author.Name,
            //        Publisher = book.Publisher.Name,
            //        Abstract = book.Abstract,
            //        Language = book.Language.Name,
            //        PublishYear = book.PublishYear,
            //        Price = book.Price,
            //        ISBN = book.ISBN,
            //    };

            //    if (book.Translator != null)
            //    {
            //        dto.TranslatorName = book.Translator.Name;
            //    }


            //    return dto;
            //}
            public string Name { get; set; }
            public string AuthorName { get; set; }
            public string Publisher { get; set; }
            public string Abstract { get; set; }
            public string Language { get; set; }
            public string TranslatorName { get; set; }
            public Nullable<int> PublishYear { get; set; }
            public string ISBN { get; set; }
            public Nullable<decimal> Price { get; set; }
        }

    }
}
