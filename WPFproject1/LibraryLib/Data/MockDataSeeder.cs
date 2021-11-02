using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Data
{
    public class MockDataSeeder
    {
        public static List<Author> Authors = new List<Author>()
        {
            new Author{Id=0,FirstName="William",LastName="ShakesPeare"},
            new Author{Id=1,FirstName="Agatha",LastName="Christie"},
            new Author{Id=2,FirstName="Barbra",LastName="Cartland"},
            new Author{Id=3,FirstName="Danielle",LastName="Steel"},
        };

        public static List<Publisher> Publishers = new List<Publisher>()
        {
            new Publisher{Id=0,PublisherName="Hachette"},
            new Publisher{Id=1,PublisherName="HarperCollins"},
            new Publisher{Id=2,PublisherName="Macmillan"},

        };

        public static List<Category> Categories = new List<Category>()
        {
            new Category{Id=0,CategoryName="Horror"},
            new Category{Id=1,CategoryName="Fiction"},
            new Category{Id=2,CategoryName="Action"},
            new Category{Id=3,CategoryName="Fantasy"},
            new Category{Id=4,CategoryName="Comedy"},
        };

        public static List<Cutomer> Cutomers = new List<Cutomer>()
        {
            new Cutomer{Id=0,FirstName="Ibrahim",LastName="Awad"},
            new Cutomer{Id=1,FirstName="Joe",LastName="Doe"},
            new Cutomer{Id=2,FirstName="Khaled",LastName="Jaseen"},
            new Cutomer{Id=3,FirstName="Bob",LastName="Smith"},

        };

        public static List<Book> Books = new List<Book>()
        {
            new Book{Id=0,BookName="Hamlet",
                publisher=Publishers.ElementAt(0),
                Authors=new List<Author>(){Authors.ElementAt(0)},
                Categories=new List<Category>(){Categories.ElementAt(1)},
                IsIssued=false,
            },


            new Book{Id=1,BookName="Murder on the orient Express",
                publisher=Publishers.ElementAt(2),
                Authors=new List<Author>(){Authors.ElementAt(1),Authors.ElementAt(3)},
                Categories=new List<Category>(){Categories.ElementAt(0),Categories.ElementAt(1)},
                IsIssued=true,
            }



        };






    }
}
