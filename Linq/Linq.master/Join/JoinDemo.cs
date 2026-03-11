using System.Reflection;
using System.Reflection.Metadata;

namespace Linq.master.Join
{
    internal class JoinDemo
    {
        // -----------------------
        // Join
        // -----------------------

        public void JoinEmployeesOrders()
        {
            
            var employees = Employee.GetEmployees();
            var orders = Order.GetOrders();

            /*
                Alice - Laptop - 2000
                Alice - Mouse - 50
                Bob - Keyboard - 100
            */
            var result = employees.Join(
                orders,
                e => e.Id,
                o => o.EmployeeId,
                (emp, order) => new
                {
                    emp.Name,
                    order.Product,
                    order.Price
                });

            var result2 = from e in employees
                         join o in orders
                         on e.Id equals o.EmployeeId
                         select new { e.Name, o.Product, o.Price };


            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Product} - {item.Price}");
            }

            Console.WriteLine("--------------------");
        }

        // -----------------------
        // GroupJoin
        // -----------------------
        public void GroupJoinEmployeesOrders()
        {
            var employees = Employee.GetEmployees();
            var orders = Order.GetOrders();

            /* 
               Employee: Alice
               Laptop - 2000
               Mouse - 50
               --------------------
               Employee: Bob
               Keyboard - 100
               --------------------
               Employee: Charlie
               --------------------
            */

            var result = employees.GroupJoin(
                orders,
                e => e.Id,
                o => o.EmployeeId,
                (emp, empOrders) => new
                {
                    Employee = emp,
                    Orders = empOrders
                });


            var result2 = from e in employees
                          join o in orders
                          on e.Id equals o.EmployeeId into empOrders
                          select new
                          {
                              Employee = e,
                              Orders = empOrders
                          };

            foreach (var item in result)
            {
                Console.WriteLine($"Employee: {item.Employee.Name}");

                foreach (var order in item.Orders)
                {
                    Console.WriteLine($"   {order.Product} - {order.Price}");
                }

                Console.WriteLine("--------------------");
            }
        }
    }

    // -----------------------
    // Employee
    // -----------------------
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee{ Id=1, Name="Alice"},
                new Employee{ Id=2, Name="Bob"},
                new Employee{ Id=3, Name="Charlie"}
            };
        }

        public override string ToString()
            => $"{Id} - {Name}";
    }

    // -----------------------
    // Order
    // -----------------------
    public class Order
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Product { get; set; }
        public int Price { get; set; }

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order{ Id=1, EmployeeId=1, Product="Laptop", Price=2000 },
                new Order{ Id=2, EmployeeId=1, Product="Mouse", Price=50 },
                new Order{ Id=3, EmployeeId=2, Product="Keyboard", Price=100 }
            };
        }

        public override string ToString()
            => $"{Id} - {Product} - {Price}";
    }
}