
using Dapper;

namespace Dapper_DotNet
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DbContext context = new DbContext();

        public void Add(Employee emp)
        {
            using var connection = context.CreateConnection();

            string sql =
            "INSERT INTO Employees(Name,Salary) VALUES(@Name,@Salary)";

            connection.Execute(sql, emp);
        }

        public List<Employee> GetAll()
        {
            using var connection = context.CreateConnection();

            return connection.Query<Employee>(
                "SELECT * FROM Employees").ToList();
        }

        public Employee GetById(int id)
        {
            using var connection = context.CreateConnection();

            return connection.QueryFirstOrDefault<Employee>(
                "SELECT * FROM Employees WHERE Id=@Id",
                new { Id = id });
        }

        public void Update(Employee emp)
        {
            using var connection = context.CreateConnection();

            string sql =
            @"UPDATE Employees
              SET Name=@Name, Salary=@Salary
              WHERE Id=@Id";

            connection.Execute(sql, emp);
        }

        public void Delete(int id)
        {
            using var connection = context.CreateConnection();

            connection.Execute(
                "DELETE FROM Employees WHERE Id=@Id",
                new { Id = id });
        }
    }
}
