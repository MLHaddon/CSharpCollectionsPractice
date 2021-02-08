using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
        //! Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            int[] num = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] alt = new bool[10];
            for (int i = 0; i < alt.Length; i++) {
                if (i % 2 == 0) {
                    alt[i] = true;
                }
                else {
                    alt[i] = false;
                }
                Console.WriteLine(alt[i]);
            }
        //! List of Flavors
            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Rocky Road");
            flavors.Add("Mint");
            // Output the length of this list after building it
            Console.WriteLine(flavors.Count);
            // Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            // Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors.Count);
        //! User Info Dictionary
            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> favFlavors = new Dictionary<string, string>();
            // Add key/value pairs to this dictionary where:
            // - each key is a name from your names array
            // - each value is a randomly select a flavor from your flavors list.
            Random rand = new Random();
            for (int i = 0; i < names.Length; i++) {
                favFlavors.Add(names[i], flavors[rand.Next(0, flavors.Count - 1)]);
            }
            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in favFlavors) {
                Console.WriteLine($"{entry.Key}, Fav Falvor: {entry.Value}");
            }
        }
    }
}
