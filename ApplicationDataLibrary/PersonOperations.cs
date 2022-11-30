
using SystemJsonLibrary;

namespace ApplicationDataLibrary;

public class PersonOperations
{
    /// <summary>
    /// Read people from json file
    /// </summary>
    /// <param name="fileName">Existing file with people</param>
    /// <returns></returns>
    public static List<Person> Read(string fileName)
    {
        var json = File.ReadAllText(fileName);
        return Helpers.DeserializeObject<List<Person>>(json);
    }
}