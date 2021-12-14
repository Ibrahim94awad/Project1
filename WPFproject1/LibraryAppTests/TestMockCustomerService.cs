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
  public class TestMockCustomerService
    {
        [TestMethod]
        public void Get_Customers_Test()
        {
            ICutomers customerService = new MockCutomersService();
            List<Cutomer> cutomers = customerService.GetAllcustomers();

            Assert.IsNotNull(cutomers);

        }

    }
}
