using System;
using System.Collections.Generic;

namespace Linq_Simulation
{
    class Program
    {
        public static void Main(string[] args)
        {


            var MyDS = new CustomList<int>(new int[] { 4, 5, 6, 7, 2, 1, 21, 11, 15, 3, 4, 5 });

            var Filter = MyDS.Where(value => value > 4).Take(4);
            
            var EE = Filter.GetEnumerator();
            while (EE.MoveNext())
            {
                Console.Write($"{ EE.Current} ,"); // 5, 6 ,7 ,21 ,
            }       
            Console.WriteLine();
            var MyDS2 = new CustomList<string>(new string[] { "apple", "banana", "cherry", "date", "fig", "grape" });


            var Filter2 = MyDS2.Where(value => value.EndsWith("e")).Take(3);

            foreach (var item in Filter2)
            {
                Console.Write($"{item} ,"); // apple, date, grape
            }
        }
    }
    


}