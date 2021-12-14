using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using LibraryLib.Domain.Services.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppTests
{
    [TestClass]
   public class TestMockAuthorService
    {
        [TestMethod]

        public void Get_All_Authors_Test()
        {
            IAuthors AuthorsService = new MockAuthorsService();
            List<Author> authors = AuthorsService.GetAllAuthors();
            Assert.IsNotNull(authors);

        }
        [TestMethod]
        public void Get_Author_By_ID()
        {
            IAuthors AuthorsService = new MockAuthorsService();
            Author author = AuthorsService.GetAuthorById(0);
            Assert.IsNotNull(author);


        }
    }
}
