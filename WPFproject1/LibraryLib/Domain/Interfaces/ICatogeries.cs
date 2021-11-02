using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
   public interface ICatogeries
    {
        //create
        bool CreateCatogery(Category category);
        bool CreateCatogery(string name);
        //Read
        List<Category> GetAllcatogiers();
        Category GetAllCategoryById(int id);
        List<Book> GetAllBookByCategory(Category category);
        List<Book> GetAllBookByCategoryID(int id);

        //Update
        bool UpdateCatogery(Category category);

        //delete
        bool DeleteCategory(Category category);
        bool DeleteCategoryById(int id);

    }
}
