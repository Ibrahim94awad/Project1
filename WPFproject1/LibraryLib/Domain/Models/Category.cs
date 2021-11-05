using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Models
{
    [Serializable]
   public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
