using System.Collections.Generic;

namespace ApplicationDataLibrary
{
    public class FirstNameComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.FirstName == y.FirstName;
        }

        public int GetHashCode(Person obj)
        {
            return (obj.FirstName != null ? obj.FirstName.GetHashCode() : 0);
        }
    }
}