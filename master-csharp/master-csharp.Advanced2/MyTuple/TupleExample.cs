
namespace master_csharp.Advanced2.MyTuple
{

    class TupleExample
    {
        static (int sum, int multiply) Calculate(int a, int b)
        {
            return (a + b, a * b);
        }


        // Tuple as parameter
        static void PrintPerson((string Name, int Age) person)
        {
            Console.WriteLine("=== Tuple As Parameter ===");
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        // Practical example
        static (bool found, int index) FindNumber(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return (true, i);
            }

            return (false, -1);
        }
    
        public static void Use()
        {
            // =========================================
            // 1️⃣ Create Tuple
            // =========================================
            var person = (Name: "Mohamed", Age: 25);

            Console.WriteLine("=== Basic Tuple ===");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine();


            // =========================================
            // 2️⃣ Deconstruction
            // =========================================
            var (name, age) = person;

            Console.WriteLine("=== Deconstruction ===");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine();


            // =========================================
            // 3️⃣ Return Multiple Values from Method
            // =========================================
            var result = Calculate(5, 3);

            Console.WriteLine("=== Return From Method ===");
            Console.WriteLine($"Sum: {result.sum}");
            Console.WriteLine($"Multiply: {result.multiply}");
            Console.WriteLine();


            // Direct deconstruction
            var (sum, multiply) = Calculate(10, 2);

            Console.WriteLine("=== Direct Deconstruction From Method ===");
            Console.WriteLine(sum);
            Console.WriteLine(multiply);
            Console.WriteLine();


            // =========================================
            // 4️⃣ Tuple as Parameter
            // =========================================
            PrintPerson(("Ali", 30));
            Console.WriteLine();


            // =========================================
            // 5️⃣ Comparison
            // =========================================
            var t1 = (1, 2);
            var t2 = (1, 3);

            Console.WriteLine("=== Comparison ===");
            Console.WriteLine(t1 == t2); // False
            Console.WriteLine();


            // =========================================
            // 6️⃣ Nested Tuple
            // =========================================
            var student = (Id: 1, Info: (Name: "Omar", Grade: 95));

            Console.WriteLine("=== Nested Tuple ===");
            Console.WriteLine(student.Info.Name);
            Console.WriteLine(student.Info.Grade);
            Console.WriteLine();


            // =========================================
            // 7️⃣ Real Practical Example
            // =========================================
            int[] numbers = { 5, 10, 15, 20 };

            var (found, index) = FindNumber(numbers, 15);

            Console.WriteLine("=== Practical Example ===");

            if (found)
                Console.WriteLine($"Found at index {index}");
            else
                Console.WriteLine("Not found");
        }

    }
}
