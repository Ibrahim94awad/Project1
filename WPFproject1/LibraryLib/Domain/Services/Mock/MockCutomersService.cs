using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
    class MockCutomersService : ICutomers
    {
        public bool CreateCutomber(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public bool CreateCutomer(Cutomer cutomer)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
