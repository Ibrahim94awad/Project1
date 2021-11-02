using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
    class MockAuthorsService : IAuthors
    {
        public bool CreateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public bool CreateAuthor(string firstName, string lastName)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Author GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
