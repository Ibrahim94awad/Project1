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
    public class FileOAuthorService : IAuthors
    {
        string loc = @"C:\\Csharp intacbrussel\\Authors.txt";
        private List<Author> authors = new List<Author>();
        public bool CreateAuthor(Author author)
        {
            GetAllAuthors();
            authors.Add(author);
            SaveAuthor();
            return authors.Contains(author);
        }

        public bool CreateAuthor(string firstName, string lastName)
        {
            GetAllAuthors();
            Author newauthor = new Author { Id = authors.Count, FirstName = firstName, LastName = lastName };
            return CreateAuthor(newauthor);
        }

        public bool DeleteAuthor(Author author)
        {
            Author x = authors.Where(b => b.Id == author.Id).FirstOrDefault();
            bool res = authors.Remove(x);


            SaveAuthor();
            return res;
        }

        public bool DeleteAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAllAuthors()
        {
            if (File.Exists(loc))
            {
                authors = Serializator.Deserializer<List<Author>>(loc);
                return authors;

            }
            else
            {
                Serializator.serialize(loc, new List<Author>());
                return new List<Author>();
            }
        }

        public Author GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }
        private void SaveAuthor()
        {
            Serializator.serialize(loc, authors);
        }
    }
}
