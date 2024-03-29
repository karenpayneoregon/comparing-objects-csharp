# About

Provides various examples for comparing objects. Most examples on the web usually deal with simple list of string or int while code samples here show how to work with `List<T>`. Keep in mind that the examples are a starting point to learn from as it is not possible to cover all situations.

:heavy_check_mark:  Code will be added over time.

![img](assets/unitTesting.png) ![img](assets/csharpSmall.png)


:heavy_check_mark: 11/30/2022 Updated to .NET Core 7 from .NET Core 5 which is out of support.


---

:white_circle: json read using System.Text.Json;

:white_circle: JsonLibrary provides json read operations

:white_circle: ApplicationDataLibrary containers comparers



## Sample

```csharp
[TestMethod]
[TestTraits(Trait.Distinct)]
public void FirstNameLastName_Equality_Comparer()
{
    var people = ReadPeopleFromFile;
    people.Add(people[0]);
    Assert.AreEqual(people.Count, 51);
    
    var distinct = people.Distinct(new FirstNameLastNameEqualityComparer());
    
    Assert.IsTrue(distinct.Count() == 50);
}
```
</br>

```csharp
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
```

### Wrappers

```csharp
public class Wrappers
{
    public static IEqualityComparer<Person> FirstNamEqualityComparer => 
        Equality<Person>.CreateComparer(p => p.FirstName);
    
    public static IEqualityComparer<Person> LastNamEqualityComparer => 
        Equality<Person>.CreateComparer(p => p.LastName);
    
    public static LambdaEqualityComparer<Person> FirstNameLambda => 
        new((p1, p2) => 
        p1.FirstName == p2.FirstName, x => x.FirstName.GetHashCode());
    
    public static LambdaEqualityComparer<Person> LastNameLambda => 
        new((p1, p2) => 
        p1.LastName == p2.LastName, x => x.LastName.GetHashCode());
}
```

