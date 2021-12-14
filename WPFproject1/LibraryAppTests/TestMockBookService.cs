using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using LibraryLib.Domain.Services;
using LibraryLib.Domain.Services.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppTests
{
    [TestClass]
   public class TestMockBookService
    {
        [TestMethod]
        public void Get_ALL_Books_Test()
        {
            //Arrange

            IBooks bookService = new MockBookService();

            //act
            List<Book> books = bookService.GetAllBooks();

            //assert

            Assert.IsNotNull(books);


        }

        [TestMethod]
        public void Get_Book_Id()
        {
            IBooks booksService = new MockBookService();

            Book book = booksService.GetbookbyId(0);

            Assert.IsNotNull(book);

            Assert.IsTrue(book.BookName == "Hamlet");
        }

        [TestMethod]

        public void Creat_Book()
        {
            
            IBooks booksService = new MockBookService();

            booksService.CreateBook(new Book { });
            
            
          
        

            

        }
        [TestMethod]
        public void Delelete_Book()
        {
            IBooks BookService = new MockBookService();
            List<Book> books = new List<Book>(){ new Book { } };
            BookService.Deletebook(books.ElementAt(0));

        }



    }
}
