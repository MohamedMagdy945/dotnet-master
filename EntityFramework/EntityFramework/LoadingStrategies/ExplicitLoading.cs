using EntityFrameworkCore_DotNet.Data;

namespace EntityFrameworkCore_DotNet.LoadingStrategies
{
    internal class ExplicitLoading
    {
        public static void Run()
        {
            using var context = new AppDbContext();
            var emp = context.Employees.FirstOrDefault(e => e.Id == 1);

            context.Entry(emp)
                .Collection(emp => emp.Comments)
                .Load();

            context.Entry(emp)
              .Reference(emp => emp.Section)
              .Load();

        }
    }
}
