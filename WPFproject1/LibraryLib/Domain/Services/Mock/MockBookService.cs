﻿using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
  public  public class MockBookService : IBooks
    {
        public bool CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool CreateBook(string bookName, Publisher publisher, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            throw new NotImplementedException();
        }

        public bool CreateBook(string bookName, int publisherId, List<Author> authors, List<Category> categories, bool isIssued = false)
        {
            throw new NotImplementedException();
        }

        public bool Deletebook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBookbyId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetallAvailableBooks()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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

        public bool IssuedBook()
        {
            throw new NotImplementedException();
        }

        public bool IssuedBookbyID()
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
    }
}