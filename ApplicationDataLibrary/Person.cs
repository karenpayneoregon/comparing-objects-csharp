using System;
using ApplicationDataLibrary.ExtensionMethods;

namespace ApplicationDataLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public int CarId { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
        public override bool Equals(object sender)
        {
            if (sender == null)
                return false;

            if (!(sender is Person person))
                return false;

            /*
             * See abbreviated / extension AreEqual below
             */
            return Id == person.Id &&
                   string.Equals(FirstName, person.FirstName, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(LastName, person.LastName, StringComparison.OrdinalIgnoreCase);

        }

        public bool Equals(Person person)
        {
            if (person == null)
                return false;

            return Id == person.Id && FirstName.AreEqual(person.FirstName) && LastName.AreEqual(person.LastName);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode();
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
            {
                return true;
            }

            if (person1 as object == null || person2 as object == null)
            {
                return false;
            }


            return person1.Id == person2.Id && person1.FirstName.AreEqual(person2.FirstName) && person1.LastName.AreEqual(person2.LastName);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }

}

