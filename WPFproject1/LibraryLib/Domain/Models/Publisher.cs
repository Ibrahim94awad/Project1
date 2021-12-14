using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Models
{
    [Serializable]
  public  class Publisher:BaseModel
    {
        public string PublisherName { get; set; }
    }
}
