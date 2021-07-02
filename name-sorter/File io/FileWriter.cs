using name_sorter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.File_io
{
    public class FileWriter
    {
        public static readonly string SortedFile = "sorted-names-list.txt";

        //Write the list of names to the sorted-names-list text file
        public void WriteFile(List<string> names)
        {
            try
            {
                File.WriteAllLines(SortedFile, names);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path or contents are empty");
                throw;
            }
            catch (IOException e)
            {
                Console.WriteLine("Something wrong occurred" + e.Message);
                throw;
            }
        }
    }
}
