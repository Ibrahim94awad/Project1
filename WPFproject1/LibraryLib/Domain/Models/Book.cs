using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Models
{
     public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public Publisher publisher { get; set; }
        public List<Author>Authors { get; set; }
        public List<Category> Categories { get; set; }
        public bool IsIssued { get; set; }



       
    }
}
