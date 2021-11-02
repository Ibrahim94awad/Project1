using LibraryLib.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Domain.Interfaces
{
  public  interface ICutomers
    {
        //Create
        bool CreateCutomer(Cutomer cutomer);
        bool CreateCutomber(string firstName, string lastName);

        //Read
        List<Cutomer> GetAllcustomers();
        Cutomer GetAllcutomersById(int id);

        //Update
        bool UpdateCutomer(Cutomer cutomer);


        //Delete
        bool DeleteCutomer(Cutomer cutomer);
        bool DeleteCutomerbyID(int id);

    }
}
