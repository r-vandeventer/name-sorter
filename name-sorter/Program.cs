using System;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            NameSorter nameSorter = new NameSorter();
            if (args[0].Length != 0)
            {
                nameSorter.SortNames(args[0]);
            }
            else
            {
                Console.WriteLine("Please enter a file name.");
                Environment.Exit(0);
            }
        }
    }
}
