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
  public  class MockAuthorsService : IAuthors
    {
        public bool CreateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public bool CreateAuthor(string firstName, string lastName)
        {
            Author newAuthor = new Author { Id = MockDataSeeder.Publishers.Count, FirstName = firstName, LastName = lastName };
            return CreateAuthor(newAuthor);
        }

        public bool DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAllAuthors()
        {
            return MockDataSeeder.Authors;
        }

        public Author GetAuthorById(int id)
        {
            Author author = GetAllAuthors().Where(b => b.Id == id).FirstOrDefault();
            return author;
        }

        public bool UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
