using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services
{
    public class FileOCategoryService : ICatogeries
    {
        public bool CreateCatogery(Category category)
        {
            throw new NotImplementedException();
        }

        public bool CreateCatogery(string name)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBookByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBookByCategoryID(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetAllCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllcatogiers()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCatogery(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
