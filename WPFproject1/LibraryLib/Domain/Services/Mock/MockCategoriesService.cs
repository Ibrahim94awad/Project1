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
 public   class MockCategoriesService : ICatogeries
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
            return MockDataSeeder.Categories;
        }

        public bool UpdateCatogery(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
