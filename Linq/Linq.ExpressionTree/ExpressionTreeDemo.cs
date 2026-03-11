using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ExpressionTree
{
    internal class ExpressionTreeDemo
    {
        public static void Run()
        {
            var employees = Employee.employees;
            Console.WriteLine("=== 1. Basic Expression Tree ===");

            Expression<Func<Employee, bool>> expr = e => e.Salary > 5500;
            Console.WriteLine(expr);

            // Inspect Expression Tree
            var binary = (BinaryExpression)expr.Body;
            Console.WriteLine($"Left: {binary.Left}, NodeType: {binary.NodeType}, Right: {binary.Right}");

            // Compile and Execute
            var func = expr.Compile();
            var filtered = employees.Where(func);
            Console.WriteLine("Filtered Employees (Salary > 5500):");
            foreach (var e in filtered) Console.WriteLine(e);

            Console.WriteLine("\n=== 2. Dynamic Expression Tree ===");

            // Dynamic: Salary > 6000
            var param = Expression.Parameter(typeof(Employee), "e");
            var salaryProp = Expression.Property(param, "Salary");
            var constant = Expression.Constant(6000.0);
            var comparison = Expression.GreaterThan(salaryProp, constant);
            var lambda = Expression.Lambda<Func<Employee, bool>>(comparison, param);

            var dynamicFunc = lambda.Compile();
            var dynamicFiltered = employees.Where(dynamicFunc);
            Console.WriteLine("Filtered Employees (Salary > 6000):");
            foreach (var e in dynamicFiltered) Console.WriteLine(e);

            Console.WriteLine("\n=== 3. Complex Expression Tree ===");

            // Dynamic: Salary > 5500 AND Name starts with 'B'
            var nameProp = Expression.Property(param, "Name");
            var startsWithMethod = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
            var nameCheck = Expression.Call(nameProp, startsWithMethod, Expression.Constant("B"));
            var combined = Expression.AndAlso(comparison, nameCheck); // Salary > 6000 && Name.StartsWith("B")
            var complexLambda = Expression.Lambda<Func<Employee, bool>>(combined, param);

            var complexFunc = complexLambda.Compile();
            var complexFiltered = employees.Where(complexFunc);
            Console.WriteLine("Filtered Employees (Salary > 6000 AND Name starts with 'B'):");
            foreach (var e in complexFiltered) Console.WriteLine(e);
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 5000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 6000 },
            new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 5500 },
            new Employee { Id = 4, Name = "David", Department = "Finance", Salary = 7000 }
        };

        public override string ToString() => $"{Id} - {Name} - {Department} - {Salary}";
    }
}
