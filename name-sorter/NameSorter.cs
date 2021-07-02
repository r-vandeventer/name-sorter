using name_sorter.File_io;
using name_sorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    public class NameSorter
    {
        public FileReader FileReader = new FileReader();
        public FileWriter FileWriter = new FileWriter();
        public List<Name> Names = new List<Name>();
        public List<string> SortedNames = new List<string>();

        //Acquire the list of names in the text file and order alpabetically
        public void SortNames(string fileName)
        {
            Names = FileReader.ReadFile(fileName);
            Names = (List<Name>)Names.OrderBy(x => x.LastName).ToList();

            foreach (Name name in Names)
            {
                SortedNames.Add(name.ToString());
            }

            WriteNames(SortedNames);
        }

        //Write the names in the console window and to file
        public void WriteNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            FileWriter.WriteFile(names);
        }
    }
}
