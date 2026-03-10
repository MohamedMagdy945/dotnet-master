

namespace Linq.master.Partition
{
   
    // ==========================
    // PartitionDemo Class
    // ==========================
    public class PartitionDemo
    {
        private List<Employee> _employees = Employee.GetSampleEmployees();


        // --------------------------
        // Pagination: Get a specific page
        // --------------------------
        public IEnumerable<Employee> GetPage(int pageNumber, int pageSize)
        {
            return _employees
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

        // --------------------------
        // Skip & Take demo (without page numbers)
        // --------------------------
        public IEnumerable<Employee> SkipTakeDemo(int skipCount, int takeCount)
        {
            return _employees
                .Skip(skipCount)
                .Take(takeCount);
        }

        // --------------------------
        // Chunk demo: divide list into chunks
        // --------------------------
        public IEnumerable<Employee[]> ChunkDemo(int chunkSize)
        {
            // Requires .NET Core 3.0+ for Enumerable.Chunk
            return _employees
                .Chunk(chunkSize);
        }

        // --------------------------
        // Print methods
        // --------------------------
        public void PrintList(IEnumerable<Employee> list, string title)
        {
            Console.WriteLine(title);
            foreach (var e in list)
                Console.WriteLine(e);
            Console.WriteLine("-------------------------------\n");
        }

        public void PrintChunks(IEnumerable<Employee[]> chunks)
        {
            int chunkNum = 1;
            foreach (var chunk in chunks)
            {
                Console.WriteLine($"Chunk {chunkNum}:");
                foreach (var e in chunk)
                    Console.WriteLine(e);
                Console.WriteLine("-------------------------------\n");
                chunkNum++;
            }
        }
    }

 
    class PartitionExample
    {
        public static void Use()
        {
            PartitionDemo demo = new PartitionDemo();

            // --------------------------
            // Example 1: Pagination
            // --------------------------
            int pageSize = 3;
            var page1 = demo.GetPage(1, pageSize);
            var page2 = demo.GetPage(2, pageSize);
            var page3 = demo.GetPage(3, pageSize);

            demo.PrintList(page1, "Page 1");
            demo.PrintList(page2, "Page 2");
            demo.PrintList(page3, "Page 3");

            // --------------------------
            // Example 2: Skip & Take
            // --------------------------
            var skipTake = demo.SkipTakeDemo(skipCount: 2, takeCount: 4);
            demo.PrintList(skipTake, "Skip 2 & Take 4");

            // --------------------------
            // Example 3: Chunk
            // --------------------------
            var chunks = demo.ChunkDemo(chunkSize: 3);
            demo.PrintChunks(chunks);
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<Employee> GetSampleEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id=1, Name="Alice" },
                new Employee { Id=2, Name="Bob" },
                new Employee { Id=3, Name="Charlie" },
                new Employee { Id=4, Name="David" },
                new Employee { Id=5, Name="Eve" },
                new Employee { Id=6, Name="Frank" },
                new Employee { Id=7, Name="Grace" },
                new Employee { Id=8, Name="Hannah" },
                new Employee { Id=9, Name="Ian" }
            };
        }
        public override string ToString() => $"{Id} - {Name}";
    }

}