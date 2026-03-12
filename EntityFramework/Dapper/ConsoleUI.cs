
namespace Dapper_DotNet
{
    public class ConsoleUI
    {
        static IEmployeeRepository repo = new EmployeeRepository();

        public static void Run()
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("1 Add");
                Console.WriteLine("2 Show");
                Console.WriteLine("3 Update");
                Console.WriteLine("4 Delete");
                Console.WriteLine("5 Exit");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Employee emp = new Employee();

                    Console.Write("Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Salary: ");
                    emp.Salary = int.Parse(Console.ReadLine());

                    repo.Add(emp);
                }

                else if (choice == 2)
                {
                    var employees = repo.GetAll();

                    foreach (var e in employees)
                        Console.WriteLine($"{e.Id} {e.Name} {e.Salary}");
                }

                else if (choice == 3)
                {
                    Employee emp = new Employee();

                    Console.Write("Id: ");
                    emp.Id = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Salary: ");
                    emp.Salary = int.Parse(Console.ReadLine());

                    repo.Update(emp);
                }

                else if (choice == 4)
                {
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());

                    repo.Delete(id);
                }
            }
        }
    }
}