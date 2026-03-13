using EntityFrameworkCore_DotNet.Data;
using EntityFrameworkCore_DotNet.Entities;

namespace EntityFrameworkCore_DotNet.GRUD_Operation
{
    internal class Delete
    {
        public static void Run()
        {
            using var db = new AppDbContext();

            var s = db.Employees.FirstOrDefault(e => e.Id == 2);
            Console.WriteLine($"what {s}");
            db.Employees.Remove(s);

            db.SaveChanges();
        }
    }
}
