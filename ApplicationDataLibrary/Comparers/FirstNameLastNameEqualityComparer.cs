using System;
using System.Collections.Generic;

namespace ApplicationDataLibrary.Comparers
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

        public int GetHashCode(Person person) => HashCode.Combine(person.FirstName, person.LastName);
    }
}
