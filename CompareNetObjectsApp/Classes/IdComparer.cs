namespace CompareNetObjectsApp.Classes;

/// <summary>
/// Compare on Id property
/// </summary>
public class IdComparer : IEqualityComparer<Person>
{
    public int GetHashCode(Person person) => person.Id.GetHashCode();

    public bool Equals(Person person1, Person person)
    {
        if (ReferenceEquals(person1, person)) return true;
        if (ReferenceEquals(person1, null)) return false;
        if (ReferenceEquals(person, null)) return false;
        if (person1.GetType() != person.GetType()) return false;
        return person1.Id == person.Id;
    }


}