using LibraryLib.Domain.Interfaces;
using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Services.Mock
{
    class MockpublisherService : IPublishers
    {
        public bool CreatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public bool CreatePublisher(string firstName)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
