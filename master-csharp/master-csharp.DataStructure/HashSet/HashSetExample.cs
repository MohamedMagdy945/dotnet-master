using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_csharp.DataStructure.HashSet
{
    class HashSetExample
    {
        public static void Use()
        {
            // Create a HashSet of strings
            HashSet<string> fruits = new HashSet<string>();

            // Adding elements
            fruits.Add("Apple");   // true, added
            fruits.Add("Banana");  // true, added
            fruits.Add("Orange");  // true, added
            fruits.Add("Apple");   // false, already exists

            Console.WriteLine("Fruits after adding:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Checking existence
            if (fruits.Contains("Banana"))
            {
                Console.WriteLine("\nBanana is in the set");
            }

            // Removing an element
            fruits.Remove("Orange");

            Console.WriteLine("\nFruits after removing Orange:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Set operations example
            HashSet<string> tropicalFruits = new HashSet<string> { "Mango", "Banana", "Pineapple" };

            // Union: all elements from both sets
            HashSet<string> allFruits = new HashSet<string>(fruits);
            allFruits.UnionWith(tropicalFruits);

            Console.WriteLine("\nAll fruits (Union):");
            foreach (var fruit in allFruits)
            {
                Console.WriteLine(fruit);
            }

            // Intersection: only common elements
            HashSet<string> commonFruits = new HashSet<string>(fruits);
            commonFruits.IntersectWith(tropicalFruits);

            Console.WriteLine("\nCommon fruits (Intersection):");
            foreach (var fruit in commonFruits)
            {
                Console.WriteLine(fruit);
            }

            // Difference: elements in fruits but not in tropicalFruits
            HashSet<string> diffFruits = new HashSet<string>(fruits);
            diffFruits.ExceptWith(tropicalFruits);

            Console.WriteLine("\nFruits only in original set (Difference):");
            foreach (var fruit in diffFruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
