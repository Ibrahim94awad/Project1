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
    public class FileOCustomerservice : ICutomers
    {
        string loc = @"C:\\Csharp intacbrussel\\Customers.txt";
        private List<Cutomer> cutomers = new List<Cutomer>();
        public bool CreateCutomber(string firstName, string lastName)
        {
            GetAllcustomers();
            Cutomer cutomer1 = new Cutomer { Id = cutomers.Count, FirstName = firstName, LastName = lastName };
            return CreateCutomer(cutomer1);
            
        }

        public bool CreateCutomer(Cutomer cutomer)
        {
            GetAllcustomers();
            cutomers.Add(cutomer);
            SaveCustomer();
            
            return cutomers.Contains(cutomer);
        }

        public bool DeleteCutomer(Cutomer cutomer)
        {
            Cutomer x = cutomers.Where(b => b.Id == cutomer.Id).FirstOrDefault();
            bool res = cutomers.Remove(x);


            SaveCustomer();
            return res;
        }

        public bool DeleteCutomerbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cutomer> GetAllcustomers()
        {
            if (File.Exists(loc))
            {
                cutomers = Serializator.Deserializer<List<Cutomer>>(loc);
                return cutomers;

            }
            else
            {
                Serializator.serialize(loc, new List<Cutomer>());
                return new List<Cutomer>();
            }
        }
    

        public Cutomer GetAllcutomersById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCutomer(Cutomer cutomer)
        {
            throw new NotImplementedException();
        }
        private void SaveCustomer()
        {
            Serializator.serialize(loc, cutomers);
        }
    }
}
