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
 public   class MockpublisherService : IPublishers
    {
        public bool CreatePublisher(Publisher publisher)
        {
            MockDataSeeder.Publishers.Add(publisher);
            return MockDataSeeder.Publishers.Contains(publisher);
        }

        public bool CreatePublisher(string firstName)
        {
            Publisher publisher = new Publisher { Id = MockDataSeeder.Publishers.Count, PublisherName = firstName };
            return CreatePublisher(publisher);
        }

        public bool DeletePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public bool DeletePublisherById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> GetAllPublisers()
        {
            return MockDataSeeder.Publishers;
        }

        public Publisher GetPublisherbyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }
    }
}
