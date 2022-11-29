using System;

namespace ConsoleNetCoreApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CodeSample.Execute(DummyMethod));
            Console.ReadLine();
        }
        static int DummyMethod(string input) => input == "Karen" ? 0 : 1;
    }
    public class CodeSample
    {
        public static bool Execute(Func<string, int> sender)
        {
            return sender("Karen") == 0;
        }
    }
}

