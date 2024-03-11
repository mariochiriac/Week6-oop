using System;

namespace CMP1903M_Workshops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 6
            //Challenge: What are the valid barcode numbers on passenger's tickets?
            //



            //Week 6
            //Task 1: Using a List object

            //List called 'names' to hold a list of names
            List<string> names = new List<string>();

            names.Add("Olivia");
            names.Add("Oliver");
            names.Add("Amelia");
            names.Add("George");
            names.Add("Isla");
            names.Add("Harry");
            names.Add("Ava");
            names.Add("Noah");
            names.Add("Emily");
            names.Add("Jack");
            
            Console.WriteLine("There are " + names.Count + " items in the list.");
            //Check to see if some names are in the list...?
            Console.WriteLine("The name George is in the list: " + names.Contains("George"));
            Console.WriteLine("The name Mario is in the list: " + names.Contains("Mario"));

            //Create a simple search method to check if a name is in the list - don't use LINQ!
            Console.WriteLine("The name Harry is in the list: " + SimpleSearch(names, "Harry"));
            Console.WriteLine("The name Dequalius is in the list: " + SimpleSearch(names, "Dequalius"));

            //What about a simple sequential search (check each name in turn)



            //Use 'Add()' or a list initialiser (List<string> names = new List<string>(){"Olivia", "Oliver", "etc"};)


            //Task 2: Use a class to hold your List
            Names nameList = new Names("list.txt");
            // Adding names to the list using Add method
            /*nameList.AddName("Olivia");
            nameList.AddName("Oliver");
            nameList.AddName("Amelia");
            nameList.AddName("George");
            nameList.AddName("Isla");
            nameList.AddName("Harry");
            nameList.AddName("Ava");
            nameList.AddName("Noah");
            nameList.AddName("Emily");
            nameList.AddName("Jack");*/

            //Outputting the contents of the list
            Console.WriteLine("All items of the list:");
            nameList.OutputNames();

            //Adding a name to the list
            Console.WriteLine("Adding a new name 'Zara' to the list...");
            nameList.AddName("Zara");

            //Outputting the updated contents of the list
            Console.WriteLine("All names in the list after addition:");
            nameList.OutputNames();

            //Checking whether the list contains a name
            Console.WriteLine("Does the list contain 'Noah'? " + nameList.ContainsName("Noah"));

            //Removing a name from the list
            Console.WriteLine("Removing 'Christi' from the list...");
            bool removed = nameList.RemoveName("Christi");
            if (removed)
            {
                Console.WriteLine("'Christi' has been removed from the list");
            }
            else
            {
                Console.WriteLine("'Christi' was not found in the list.");
            }

            // Outputting the updated contents
            Console.WriteLine("All names in the list after rmoval:");
            nameList.OutputNames();


            //Task 3: Create a 'Wait' class to hold a Queue<> collection
            //Task 4: Use LINQ queries on your collection




        }

        private static bool SimpleSearch (List<string> aList, string s)
        {
            if (aList.Contains(s)) return true;
            else return false; 
        }
    }
}