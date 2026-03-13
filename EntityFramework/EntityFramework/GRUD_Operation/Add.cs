

using EntityFrameworkCore_DotNet.Data;
using EntityFrameworkCore_DotNet.Entities;

namespace EntityFrameworkCore_DotNet.GRUD_Operation
{
    internal class Add
    {
        public static void Run()
        {
            using var db = new AppDbContext();

            db.Employees.Add(new Employee
            {
                Name = "Maner",
                Salary = 555500
            });

            db.SaveChanges();
        }
    }
}
