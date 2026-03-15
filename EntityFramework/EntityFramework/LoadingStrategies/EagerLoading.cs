using EntityFrameworkCore_DotNet.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_DotNet.LoadingStrategies
{
    internal class EagerLoading
    {
        public static void Run()
        {
            using (var context = new AppDbContext())
            {
                var employees = context.Employees
                    .Include(e => e.Section)
                    .ToList();

                foreach (var emp in employees)
                {
                    Console.WriteLine(emp.Name);
                    Console.WriteLine(emp.Section.Name);
                }
            }
        }
    }
}
