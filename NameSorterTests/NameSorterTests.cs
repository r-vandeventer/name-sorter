using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using name_sorter.File_io;
using name_sorter.Models;
using System.Collections.Generic;

namespace NameSorterTests
{
    [TestClass]
    public class NameSorterTests
    {
        [TestMethod]
        public void Test_FileRead()
        {
            var fr = new FileReader();
            List<Name> names = new List<Name>();

            names = fr.ReadFile("unsorted-names-list.txt");
            Assert.IsNotNull(names);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException), "The file does not exist")]
        public void Test_FileRead_FileNotFoundException()
        {
            var fr = new FileReader();
            List<Name> names = new List<Name>();

            names = fr.ReadFile("unsorted-names.txt");
        }

        [TestMethod]
        public void Test_FileWrite()
        {
            var fw = new FileWriter();
            List<string> names = new List<string>() { "Janet Parsons", "Vaughn Lewis" };

            fw.WriteFile(names);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "The path or contents are empty")]
        public void Test_FileWriteException()
        {
            var fw = new FileWriter();
            List<string> names = null;

            fw.WriteFile(names);
        }
    }
}
