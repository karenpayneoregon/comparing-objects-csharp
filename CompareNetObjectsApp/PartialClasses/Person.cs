using CompareNetObjectsApp.ExtensionMethods;

// ReSharper disable once CheckNamespace
namespace CompareNetObjectsApp.Classes
{
    public partial class Person : IEquatable<Person>
    {
        public override bool Equals(object sender)
        {
            if (sender is not Person person)
            {
                return false;
            }

            return Id == person.Id &&
                   string.Equals(FirstName, person.FirstName, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(LastName, person.LastName, StringComparison.OrdinalIgnoreCase) &&
                   BirthDate == person.BirthDate;

        }

        public bool Equals(Person person)
        {
            if (person == null)
            {
                return false;
            }

            return Id == person.Id && FirstName.AreEqual(person.FirstName) && LastName.AreEqual(person.LastName);
        }

        public override int GetHashCode() 
            => Id.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode() ^ BirthDate.GetHashCode();

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
            {
                return true;
            }

            if ((object)person1 == null || (object)person2 == null)
            {
                return false;
            }


            return person1.Id == person2.Id &&
                   person1.FirstName.AreEqual(person2.FirstName) &&
                   person1.LastName.AreEqual(person2.LastName) && 
                   person1.BirthDate.AreEqual(person2.BirthDate);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
