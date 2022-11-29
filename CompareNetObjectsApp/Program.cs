using CompareNetObjectsApp.Classes;

namespace CompareNetObjectsApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var people1 = PersonOperations.Read("people1.json");
            var people2 = PersonOperations.Read("people2.json");

            for (int index = 0; index < people1.Count; index++)
            {
                if (people1[index] != people2[index])
                {
                    Console.WriteLine(people1[index].Id);
                }
            }

            Console.ReadLine();
        }
    }


}