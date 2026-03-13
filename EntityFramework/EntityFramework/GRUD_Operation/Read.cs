using EntityFrameworkCore_DotNet.Data;
using EntityFrameworkCore_DotNet.Entities;

namespace EntityFrameworkCore_DotNet.GRUD_Operation
{
    internal class Read
    {
        public static void Run()
        {
            using var db = new AppDbContext();

            var employees = db.Employees.ToList();

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary}");
            }
        }
    }
}
