using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLib.Helpers
{
   public static class Serializator
    {
        private static BinaryFormatter _bin = new BinaryFormatter();
        public static void serialize(string pathOfFilenName,object objtoserialize)
        {
            using (Stream stream = File.Open(pathOfFilenName, FileMode.Create))
            {
                try
                {
                    _bin.Serialize(stream, objtoserialize);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize.Reason" + e.Message);
                   
                }
            }
        }

        public static T Deserializer<T>(string pathOfFileName)
        {
            T items;
            using(Stream stream = File.Open(pathOfFileName, FileMode.Open))
            {
                try
                {
                    items = (T)_bin.Deserialize(stream);

                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize.Reason :"+e.Message);
                    throw;
                }

            }
            return items;
        }
    }
}
