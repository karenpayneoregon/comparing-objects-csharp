using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDataLibrary
{
    public class FirstNameLastNameEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            
            return x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode(Person obj)
        {
            return HashCode.Combine(obj.FirstName, obj.LastName);
        }
    }

}
