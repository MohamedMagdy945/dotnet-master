
namespace Linq.master.Sort
{

    // ==========================
    // SortDemo Class
    // ==========================
    public class SortDemo
    {

        // --------------------------
        // Example 1: OrderBy ascending
        // --------------------------
        List<Employee> _employees = Employee.LoadEmployee(); 
        public void ExampleOrderBy()
        {
            var sorted = _employees.OrderBy(e => e.Name);
            Console.WriteLine("Example 1: OrderBy Name Ascending");
            foreach (var e in sorted)
                Console.WriteLine(e);
            Console.WriteLine();
        }

        // --------------------------
        // Example 2: OrderByDescending
        // --------------------------
        public void ExampleOrderByDescending()
        {
            var sorted = _employees.OrderByDescending(e => e.Salary);
            Console.WriteLine("Example 2: OrderBy Salary Descending");
            foreach (var e in sorted)
                Console.WriteLine(e);
            Console.WriteLine();
        }

        // --------------------------
        // Example 3: OrderBy + ThenBy
        // --------------------------
        public void ExampleThenBy()
        {
            var sorted = _employees
                .OrderBy(e => e.Department)
                .ThenBy(e => e.Name);
            Console.WriteLine("Example 3: OrderBy Department, ThenBy Name");
            foreach (var e in sorted)
                Console.WriteLine(e);
            Console.WriteLine();
        }

        // --------------------------
        // Example 4: OrderBy with IComparer
        // --------------------------
        public void ExampleWithComparer()
        {
            var sorted = _employees.OrderBy(e => e.Department, new DepartmentComparer());
            Console.WriteLine("Example 4: OrderBy Department Descending using IComparer");
            foreach (var e in sorted)
                Console.WriteLine(e);
            Console.WriteLine();
        }

        // --------------------------
        // Example 6: Query Syntax
        // --------------------------
        public void ExampleQuerySyntax()
        {
            var sorted = from e in _employees
                            orderby e.Department, e.Name
                            select e;
            Console.WriteLine("Example 6: Query Syntax OrderBy Department then Name");
            foreach (var e in sorted)
                Console.WriteLine(e);
            Console.WriteLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public static List<Employee> LoadEmployee()
        {
            return new List<Employee>
            {
                new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 6000 },
                new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 5000 },
                new Employee { Id = 5, Name = "Eve", Department = "IT", Salary = 7000 },
                new Employee { Id = 2, Name = "Bob", Department = "Finance", Salary = 4500 },
                new Employee { Id = 4, Name = "David", Department = "HR", Salary = 5500 }
            };
        }
        public override string ToString()
        {
            return $"{Id} - {Name} - {Department} - {Salary}";
        }
    }
}
    public class DepartmentComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            // ترتيب تنازلي للأحرف الأبجدية
            return string.Compare(y, x, StringComparison.OrdinalIgnoreCase);
        }
    }
}
