

using EntityFrameworkCore_DotNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameworkCore_DotNet.DbContextDependencyInjection
{

    public class App
    {
        public static void Run()
        {
            var options = new DbContextOptionsBuilder();

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            using (var context = serviceProvider.GetService<AppDbContext>())
            {
                foreach (var emp in context!.Employees)
                {
                    Console.WriteLine($"Id : {emp.Id} - Name {emp.Name}  -  Salary : {emp.Salary}");
                }
            }

        }
    }

}