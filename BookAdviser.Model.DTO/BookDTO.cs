using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Model.DTO
{
    public class BookDTO
    {
        //public static implicit operator BookDTO(Book book)
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
        public int ID { get; set; }
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
