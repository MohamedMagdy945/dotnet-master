using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.master.Generation
{
    internal class GenerationDemo
    {
        public static void Use()
        {
          
            var numbers = Enumerable.Range(1, 10);

            Console.WriteLine("Numbers:");
            foreach (var n in numbers)
                Console.WriteLine(n);


            var repeated = Enumerable.Repeat("Hello", 5);

            Console.WriteLine("\nRepeated Strings:");
            foreach (var s in repeated)
                Console.WriteLine(s);

            // -----------------------
            // (Cartesian product)
            // -----------------------
            var letters = new[] { 'A', 'B', 'C' };
            var combinations = numbers.SelectMany(
                n => letters,
                (n, l) => $"{n}{l}"
            );

            Console.WriteLine("\nNumber-Letter Combinations:");
            foreach (var c in combinations)
                Console.WriteLine(c);
        }
    }
}
