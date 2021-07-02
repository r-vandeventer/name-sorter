using name_sorter.Models;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System;

namespace name_sorter.File_io
{
    public class FileReader
    {
        public List<Name> Names;
        public Name Name = new Name();

        //Read the list of names from the unsorted-names-list text file
        //Send the list back to NameSorter.cs
        public List<Name> ReadFile(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                Names = new List<Name>();

                foreach (string line in lines)
                {
                    Name name = Name.SplitName(line);
                    Names.Add(name);
                }

                return Names;
            }
            catch (FileNotFoundException) 
            {
                Console.WriteLine("The file does not exist");
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
