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
  public  class MockCutomersService : ICutomers
    {
      

        public bool CreateCutomer(Cutomer cutomer)
        {
            MockDataSeeder.Cutomers.Add(cutomer);
            return MockDataSeeder.Cutomers.Contains(cutomer);
        }
        public bool CreateCutomber(string firstName, string lastName)
        {
            Cutomer newCustomer = new Cutomer { Id = MockDataSeeder.Cutomers.Count, FirstName = firstName, LastName = lastName };
            return CreateCutomer(newCustomer);
        }

        public bool DeleteCutomer(Cutomer cutomer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCutomerbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cutomer> GetAllcustomers()
        {
            return MockDataSeeder.Cutomers;

        }

        public Cutomer GetAllcutomersById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCutomer(Cutomer cutomer)
        {
            throw new NotImplementedException();
        }
    }
}
