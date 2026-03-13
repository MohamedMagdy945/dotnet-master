using EntityFrameworkCore_DotNet.Data;
using EntityFrameworkCore_DotNet.Entities;

namespace EntityFrameworkCore_DotNet.GRUD_Operation
{
    internal class Update
    {
        public static void Run()
        {
            using var db = new AppDbContext();

            var s = db.Employees.FirstOrDefault(e => e.Name == "Manar");
            s.Salary = 2225;

            db.SaveChanges();
        }
    }
}
