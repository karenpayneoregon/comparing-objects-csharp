using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonLibrary;

namespace ApplicationDataLibrary
{
    public class PersonOperations
    {
        public static List<Person> Read(string fileName)
        {
            var json = File.ReadAllText(fileName);
            return Helpers.DeserializeObject<List<Person>>(json);
        }
    }
}
