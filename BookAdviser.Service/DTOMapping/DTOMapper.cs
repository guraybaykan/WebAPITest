using BookAdviser.Model.DTO;
using BookAdviser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAdviser.Service.DTOMapping
{
   public static class DTOMapper
    {
       public static BookDTO GetBookDTO(this Book book)
       {
           var BDTO = new BookDTO
           {
               ID=book.ID,
               Name = book.Name,
               AuthorName = book.Author.Name,
               Publisher = book.Publisher.Name,
               Abstract = book.Abstract,
               Language = book.Language.Name,
               PublishYear = book.PublishYear,
               Price = book.Price,
               ISBN = book.ISBN,
               TranslatorName = book.Translator == null ? null : book.Translator.Name
           };
           return BDTO;
       }
       public static AuthorDTO GetAuthorDTO(this Author author)
       {
           var authorDTO = new AuthorDTO
           {
               ID = author.ID,
               Name = author.Name,
           };
           return authorDTO;
       }

       public static Author GetAuthor(this AuthorDTO authorDTO)
       {
           var author = new Author
           {
               ID = authorDTO.ID,
               Name = authorDTO.Name,
           };
           return author;
       }
    }

}
