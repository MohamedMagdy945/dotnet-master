using EntityFrameworkCore_DotNet.Data;

namespace EntityFrameworkCore_DotNet.LoadingStrategies
{
    internal class LazyLoading
    {
        public static void Run()
        {
            using (var context = new AppDbContext())
            {
                var employees = context.Employees.ToList();

                foreach (var emp in employees)
                {
                    Console.WriteLine(emp.Name);
                    Console.WriteLine(emp.Section.Name);
                }
            }

        }
    }
}
