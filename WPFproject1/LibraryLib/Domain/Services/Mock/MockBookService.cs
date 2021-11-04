using LibraryLib.Data;
using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
   public class MockBookService : IBooks
    {
        public bool CreateBook(Book book)
        {
            if (book.BookName==string.Empty||book.publisher==null||book.Authors.Count==0||book.Categories.Count==0)
            {
                return false;
            }
                MockDataSeeder.Books.Add(book);
            return MockDataSeeder.Books.Contains(book);
        }

        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
           
            Book newbook = new Book { Id = MockDataSeeder.Books.Count, BookName = bookName, publisher = publisher, Authors = authors, Categories = categories, IsIssued = isIssued };
            return CreateBook(newbook);

        }

        public bool CreateBook(string bookName, int publisherId, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            Publisher publisher = MockDataSeeder.Publishers.Where(p => p.Id == publisherId).FirstOrDefault();
            Book newbook = new Book { Id = MockDataSeeder.Books.Count, BookName = bookName, publisher = publisher, Authors = authors, Categories = categories, IsIssued = isIssued };
            return CreateBook(newbook);


        }

        public bool Deletebook(Book book)
        {
            if (book.IsIssued==true)
            {
                return false;
            }
           return MockDataSeeder.Books.Remove(book);
        }

        public bool DeleteBookbyId(int id)
        {
            Book book = MockDataSeeder.Books.Where(b => b.Id == id).FirstOrDefault();
            return Deletebook(book);
        }

        public List<Book> GetallAvailableBooks()
        {
            //optie 1
            //List<Book> availableBooks = new List<Book>();

            //foreach (var book in MockDataSeeder.Books)
            //{
            //    if (!book.IsIssued)
            //    {
            //        availableBooks.Add(book);
            //    }
            //}
            //return availableBooks;
            //optie 2 Linq
            return MockDataSeeder.Books.Where(b =>b.IsIssued == false).ToList();
        }

        public List<Book> GetAllBookByAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBookbycatogeryID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return MockDataSeeder.Books;
        }

        public List<Book> GetAllBooksByauthorID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByCatogery(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByPublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByPublisherId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllIssuedBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetbookbyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool IssuedBook(Book book)
        {
            book.IsIssued = true;
            if (book.IsIssued==true)
            {
                return true;
            }
            else
            {
                return false;
            }
            // tweede optie
            // return book.IsIssued;
           
        }

        public bool IssuedBookbyID(int id)
        {
            Book book = GetAllBooks().Where(b => b.Id == id).FirstOrDefault();
            return IssuedBook(book);
        }

        public bool ReturnBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool ReturnBookById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBook()
        {
            throw new NotImplementedException();
        }
    }
}
