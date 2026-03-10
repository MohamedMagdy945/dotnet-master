using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.master.Defferd_Execution
{
    internal  class DefferdDemo
    {
        public static void Use()
        {
            List<int> numbers = new List<int> { 1 , 2 , 3, 4, 5 ,6 ,7 , 8,9};
            IEnumerable<int> evenNumber = numbers.Where(x => x % 2 == 0);

            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            // 2 6 8 10 12
            foreach (int number in evenNumber)
            {
                Console.Write(number + " ");
            }
        }
    }
}
