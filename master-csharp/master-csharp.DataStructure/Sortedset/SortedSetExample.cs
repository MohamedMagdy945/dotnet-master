
namespace master_csharp.DataStructure.Sortedset
{
    class SortedSetExample
    {
        public static void Test()
        {
            // Create a SortedSet of strings
            SortedSet<string> fruits = new SortedSet<string>();

            // Add elements
            fruits.Add("Banana");
            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("Mango");
            fruits.Add("Apple"); // duplicate ignored

            Console.WriteLine("Fruits (Sorted):");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Remove element
            fruits.Remove("Banana");

            Console.WriteLine("\nAfter removing Banana:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Set operations
            SortedSet<string> tropicalFruits = new SortedSet<string> { "Mango", "Pineapple", "Banana" };

            // Union
            SortedSet<string> allFruits = new SortedSet<string>(fruits);
            allFruits.UnionWith(tropicalFruits);

            Console.WriteLine("\nAll Fruits (Union):");
            foreach (var fruit in allFruits)
            {
                Console.WriteLine(fruit);
            }

            // Intersection
            SortedSet<string> commonFruits = new SortedSet<string>(fruits);
            commonFruits.IntersectWith(tropicalFruits);

            Console.WriteLine("\nCommon Fruits (Intersection):");
            foreach (var fruit in commonFruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
