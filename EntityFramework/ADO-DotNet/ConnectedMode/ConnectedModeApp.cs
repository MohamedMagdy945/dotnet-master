

namespace ADO_DotNet.ConnectedMode
{
    internal class ConnectedModeApp
    {
        public static void Run()
        {
            EmployeeRepository repo = new EmployeeRepository();
            ConsoleKeyInfo key = new ConsoleKeyInfo(); ;
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("1- Add Employee");
                Console.WriteLine("2- Show Employees");
                Console.WriteLine("3- Update Employee");
                Console.WriteLine("4- Delete Employee");
                Console.WriteLine("5- To exit Employee");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Employee emp = new Employee();

                    Console.Write("Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Salary: ");
                    emp.Salary = int.Parse(Console.ReadLine());

                    repo.AddEmployee(emp);

                    Console.WriteLine("Added Succussfully");
                }

                else if (choice == 2)
                {
                    List<Employee> employees = repo.GetEmployees();

                    foreach (var e in employees)
                    {
                        Console.WriteLine($"{e.Id} - {e.Name} - {e.Salary}");
                    }
                }

                else if (choice == 3)
                {
                    Employee emp = new Employee();

                    Console.Write("Id: ");
                    emp.Id = int.Parse(Console.ReadLine());

                    Console.Write("New Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("New Salary: ");
                    emp.Salary = int.Parse(Console.ReadLine());

                    repo.UpdateEmployee(emp);
                    Console.WriteLine("Updated Succussfully");

                }

                else if (choice == 4)
                {
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());

                    repo.DeleteEmployee(id);
                    Console.WriteLine("Deleted Succussfully");
                }

                Console.WriteLine();
            }
        }
    }
}
