using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookAdviser.Repository;
using System.Collections.Generic;

namespace BookAdviser.Test
{
    [TestClass]
    public class AuthorTest
    {
        [TestMethod]
        public void SaveAuthor()
        {
            BookAdviserUnitOfWork ba = new BookAdviserUnitOfWork();
            var author = new Author
            {
                Name = "Oscar Wilde1" 
            };

            ba.Authors.Add(author);
            ba.Complete();
            ba.Dispose();



            ba = new BookAdviserUnitOfWork();

            var written = ba.Authors.Find(x =>x.Name.IndexOf("Oscar") != -1);
            bool flag = false;
            foreach(var i in written)
            {
                flag = true;
            }

            Assert.AreEqual(flag, true);
            
        }

        [TestMethod]
        public void UpdateAuthor()
        {
            BookAdviserUnitOfWork ba = new BookAdviserUnitOfWork();
            var author = ba.Authors.Get(4);
            author.Name = "Atilla Taş";
            ba.Complete();

            ba.Dispose();
            ba = new BookAdviserUnitOfWork();
            var r = ba.Authors.Get(4);
            Assert.AreEqual(author.Name, "Atilla Taş");
        }
    }
}
