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
    public class FileOPublisherservice : IPublishers
    {
        string loc = @"C:\\Csharp intacbrussel\\Publisher.txt";
        private List<Publisher> publishers = new List<Publisher>();


        public bool CreatePublisher(Publisher publisher)
        {
            GetAllPublisers();
            publishers.Add(publisher);
            SavePublisher();
            return publishers.Contains(publisher);
        }

        public bool CreatePublisher(string firstName)
        {
            GetAllPublisers();
            Publisher newpublisher = new Publisher { Id = publishers.Count, PublisherName = firstName };
            return CreatePublisher(newpublisher);
        }

        public bool DeletePublisher(Publisher publisher)
        {
            Publisher x = publishers.Where(b => b.Id == publisher.Id).FirstOrDefault();
            bool res = publishers.Remove(x);


            SavePublisher();
            return res;
        }

        public bool DeletePublisherById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> GetAllPublisers()
        {
            if (File.Exists(loc))
            {
                publishers = Serializator.Deserializer<List<Publisher>>(loc);
                return publishers;

            }
            else
            {
                Serializator.serialize(loc, new List<Publisher>());
                return new List<Publisher>();
            }
        }

        public Publisher GetPublisherbyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            throw new NotImplementedException();
        }
        private void SavePublisher()
        {
            Serializator.serialize(loc, publishers);
        }
    }
}
