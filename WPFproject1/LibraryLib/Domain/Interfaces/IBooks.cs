using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
    interface IBooks
    {
        //Create
        bool CreateBook(Book book);
        bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false);
        bool CreateBook(string bookName, int publisherId, List<Author> authors, List<Category> categories, bool isIssued = false);
        //Read
        List<Book> GetAllBooks();
        List<Book> GetallAvailableBooks();
        List<Book> GetAllIssuedBooks();
        Book GetbookbyId(int id);
        List<Book> GetAllBooksByCatogery(Category category);
        List<Book> GetAllBookbycatogeryID(int id);
        List<Book> GetAllBookByAuthor(Author author);
        List<Book> GetAllBooksByauthorID(int id);
        List<Book> GetAllBooksByPublisher(Publisher publisher);
        List<Book> GetAllBooksByPublisherId(int id);

        //Update

        bool UpdateBook();
        bool IssuedBook();
        bool IssuedBookbyID();
        bool ReturnBook(Book book);
        bool ReturnBookById(int id);

        //Delete
        bool Deletebook(Book book);
        bool DeleteBookbyId(int id);
    }
}
