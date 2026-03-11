

namespace ADO_DotNet.DisconnectedMode
{
    internal class DisConnectedModeApp
    {
        public static void Run()
        {
            EmployeeRepository repo = new EmployeeRepository();
            int choice = 0 ;
            while (choice != 5)
            {
                Console.WriteLine("1- Show Employees");
                Console.WriteLine("2- Add Employee");
                Console.WriteLine("3- Update Employee");
                Console.WriteLine("4- Delete Employee");
                Console.WriteLine("5- To exit Employee");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    repo.ShowEmployees();
                }
                else if (choice == 2)
                {
                    Employee emp = new Employee();

                    Console.Write("Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Salary: ");
                    emp.Salary = int.Parse(Console.ReadLine());

                    repo.AddEmployee(emp);

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

                }
                else if (choice == 4)
                {
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());

                    repo.DeleteEmployee(id);

                }
            }
        }
    }
}
