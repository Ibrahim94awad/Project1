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
    public class FileOCategoryService : ICatogeries
    {
        string loc = @"C:\\Csharp intacbrussel\\Category.txt";
        private List<Category> Categories = new List<Category>();
        public bool CreateCatogery(Category category)
        {
            GetAllcatogiers();
            Categories.Add(category);
            SaveCategory();
            return Categories.Contains(category);
        }

        public bool CreateCatogery(string name)
        {
            GetAllcatogiers();
            Category newcategory = new Category { CategoryName = name };
            return CreateCatogery(newcategory);
        }

        public bool DeleteCategory(Category category)
        {
            Category x = Categories.Where(b => b.Id == category.Id).FirstOrDefault();
            bool res = Categories.Remove(x);


            SaveCategory();
            return res;
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
            if (File.Exists(loc))
            {
                Categories = Serializator.Deserializer<List<Category>>(loc);
                return Categories;

            }
            else
            {
                Serializator.serialize(loc, new List<Category>());
                return new List<Category>();
            }
        }
    

        public bool UpdateCatogery(Category category)
        {
            throw new NotImplementedException();
        }
        private void SaveCategory()
        {
            Serializator.serialize(loc, Categories);
        }
    }
}
