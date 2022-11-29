using CompareNetObjectsApp.Classes;

namespace CompareNetObjectsApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            CompareByIdWithExcept();
            CompareFirstLastNameAndBirthDate();

            Console.ReadLine();
        }

        private static void CompareByIdWithExcept()
        {
            var people1 = PersonOperations.Read("people1.json");
            
            // alter two records
            people1[0].Id = 34;
            people1[5].Id = 22;

            var people2 = PersonOperations.Read("people2.json");
            var result = people2.Except(people1, new IdComparer()).ToList();
            Console.WriteLine(result.Count == 2);
        }

        private static void CompareFirstLastNameAndBirthDate()
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
        }
    }


}