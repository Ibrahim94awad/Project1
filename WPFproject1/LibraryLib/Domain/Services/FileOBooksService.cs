using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using LibraryLib.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services
{
    public class FileOBooksService : IBooks
    {
        //Path where to store books .txt file
        string loc = @"C:\\Csharp intacbrussel\\Book.txt";
       // string loc = @"C:\\Book.txt";
        private List<Book> books=new List<Book>();




        public bool CreateBook(Book book)
        {
            GetAllBooks();
            books.Add(book);
            SaveBook();
            return books.Contains(book);
        }

        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            GetAllBooks();
            Book newBook = new Book { Id = books.Count, BookName = bookName, publisher = publisher, Authors = authors, Categories = categories, IsIssued = isIssued };
            return CreateBook(newBook);
        }

        public bool CreateBook(string bookName, int publisherId, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            throw new NotImplementedException();
        }

        public bool Deletebook(Book book)
        {
            Book x = books.Where(b => b.Id == book.Id).FirstOrDefault();
            bool res=books.Remove(x);


            SaveBook();
            return res;
        }

        public bool DeleteBookbyId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetallAvailableBooks()
        {

            return GetAllBooks().Where(b => b.IsIssued == false).ToList();

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
            if (File.Exists(loc))
            {
                books = Serializator.Deserializer<List<Book>>(loc);
                return books;

            }
            else
            {
                Serializator.serialize(loc, new List<Book>());
                return new List<Book>();
            }
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
            throw new NotImplementedException();
        }

        public bool IssuedBookbyID(int id)
        {
            throw new NotImplementedException();
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

        private void SaveBook()
        {
            Serializator.serialize(loc, books);
        }
    }
}
