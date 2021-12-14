using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Models
{
    [Serializable]
   public class Cutomer:BaseModel
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Cutomer cutomer &&
                   FirstName == cutomer.FirstName &&
                   LastName == cutomer.LastName;
        }

        public override int GetHashCode()
        {
            int hashCode = 1938039292;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            return hashCode;
        }
    }
}
