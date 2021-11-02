using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
   public interface IPublishers
    {
        //Create
        bool CreatePublisher(Publisher publisher);
        bool CreatePublisher(string firstName);
        //Read
        List<Publisher> GetAllPublisers();
        Publisher GetPublisherbyId(int id);

        //Update
        bool UpdatePublisher(Publisher publisher);

        //Delete
        bool DeletePublisher(Publisher publisher);
        bool DeletePublisherById(int id);
    }
}
