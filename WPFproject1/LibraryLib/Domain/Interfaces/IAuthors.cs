using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
   public interface IAuthors
    {
        //create
        bool CreateAuthor(Author author);
        bool CreateAuthor(string firstName, string lastName);
        //Read
        List<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        //Update
        bool UpdateAuthor(Author author);
        //Delete
        bool DeleteAuthor(Author author);
        bool DeleteAuthorById(int id);
    }
}
