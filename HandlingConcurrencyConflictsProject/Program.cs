using HandlingConcurrencyConflictsProject.Services;
using System;

namespace HandlingConcurrencyConflictsProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            HandlingConcurrencyConflicts hCC = new HandlingConcurrencyConflicts();
            hCC.Process().GetAwaiter().GetResult();
            Console.WriteLine("Hello World!");
        }
    }
}
