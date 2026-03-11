

namespace IQueryable
{
    internal class QueryableDemo
    {
        public static void Run()
        {
            // Sample data
            List<Employee> employees = Employee.GetEmployees();

            Console.WriteLine("=== IEnumerable Example ===");

            // IEnumerable: execution happens in-memory
            IEnumerable<Employee> ieResult = employees
                .Where(e =>
                {
                    return e.Salary > 5000;
                })
                .OrderBy(e => e.Name); // Deferred execution still works

            Console.WriteLine("IEnumerable query defined, not executed yet");

            // Execution happens here
            foreach (var e in ieResult)
                Console.WriteLine(e);

            Console.WriteLine("\n=== IQueryable Example ===");

            // IQueryable: using AsQueryable to simulate EF
            IQueryable<Employee> iqEmployees = employees.AsQueryable();

            IQueryable<Employee> iqResult = iqEmployees
                .Where(e => e.Salary > 5000) 
                .OrderBy(e => e.Name);

            Console.WriteLine("IQueryable query defined, not executed yet");

            // Execution happens here
            foreach (var e in iqResult)
                Console.WriteLine(e);

            Console.WriteLine("\n=== Key Differences ===");
            Console.WriteLine("- IEnumerable: works element by element in-memory, always executes the delegate directly");
            Console.WriteLine("- IQueryable: builds Expression Tree first, can translate to SQL in EF, deferred execution until materialization");
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
            public static List<Employee> GetEmployees()
            {
                return new List<Employee>
                {
                    new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 5000 },
                    new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 6000 },
                    new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 5500 },
                    new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 7000 },
                    new Employee { Id = 5, Name = "Eve", Department = "HR", Salary = 4800 }
                };
            }
            public override string ToString() => $"{Id} - {Name} - {Department} - {Salary}";
        }
    }
}
