using Microsoft.Data.SqlClient;


namespace ADO_DotNet.ConnectedMode
{
    public class EmployeeRepository
    {
        string connectionString =
            "Server=.;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Name, Salary FROM Employees", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee emp = new Employee();

                    emp.Id = (int)reader["Id"];
                    emp.Name = reader["Name"].ToString();
                    emp.Salary = (int)reader["Salary"];

                    employees.Add(emp);
                }

                reader.Close();
            }

            return employees;
        }

        public void AddEmployee(Employee emp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Employees(Name,Salary) VALUES(@name,@salary)", conn);

                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@salary", emp.Salary);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Employees SET Name=@name, Salary=@salary WHERE Id=@id", conn);

                cmd.Parameters.AddWithValue("@id", emp.Id);
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@salary", emp.Salary);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Employees WHERE Id=@id", conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
