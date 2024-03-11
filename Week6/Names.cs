using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Workshops
{
    public class Names
    {
        //class Names to hold your list of names and various methods
        private List<string> names;
        
        public Names(string filename)
        {
            names = new List<string>();
            LoadFromFile(filename);
        }

        public void LoadFromFile(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    AddName(line.Trim());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading names from file: " + e.Message);
            }
        }


        public void AddName(string name)
        {
            if (!names.Contains(name))
            {
                int index = names.BinarySearch(name);
                if (index < 0)
                    index = ~index;
                names.Insert(index, name);
            }
        }
        public bool ContainsName(string name)
        {
            return name.Contains(name);
        }

        public void OutputNames()
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public bool RemoveName(string name)
        {
            if (names.Contains(name))
            {
                names.Remove(name);
                return true;
            }
            else return false;
        }
    }
}
