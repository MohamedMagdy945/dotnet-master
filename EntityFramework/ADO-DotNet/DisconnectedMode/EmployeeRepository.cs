using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO_DotNet.DisconnectedMode
{
    public class EmployeeRepository
    {
        private readonly string connectionString =
            "Server=.;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private readonly SqlDataAdapter adapter;
        private readonly DataSet ds;

        public EmployeeRepository()
        {
            ds = new DataSet();

            adapter = new SqlDataAdapter("SELECT * FROM Employees", connectionString);

            // SqlCommandBuilder لإنشاء أوامر Insert / Update / Delete تلقائيًا
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            // Fill DataSet
            adapter.Fill(ds, "Employees");

            DataTable table = ds.Tables["Employees"];

            // Assign Primary Key
            table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };

            // ضبط عمود Id للـ AutoIncrement
            DataColumn idColumn = table.Columns["Id"];
            idColumn.ReadOnly = true;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = -1; // لتجنب تعارض مع الـ DB identity
            idColumn.AutoIncrementStep = -1;
        }

        public void ShowEmployees()
        {
            DataTable table = ds.Tables["Employees"];

            if (table.Rows.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"{row["Id"]} - {row["Name"]} - {row["Salary"]}");
            }
        }

        public void AddEmployee(Employee emp)
        {
            DataTable table = ds.Tables["Employees"];
            DataRow row = table.NewRow();

            row["Name"] = emp.Name;
            row["Salary"] = emp.Salary;

            table.Rows.Add(row);

            // تحديث قاعدة البيانات
            adapter.Update(ds, "Employees");

            Console.WriteLine("Employee added successfully.");
        }

        public void UpdateEmployee(Employee emp)
        {
            DataTable table = ds.Tables["Employees"];
            DataRow row = table.Rows.Find(emp.Id);

            if (row != null)
            {
                row["Name"] = emp.Name;
                row["Salary"] = emp.Salary;

                adapter.Update(ds, "Employees");

                Console.WriteLine("Employee updated successfully.");
            }
            else
            {
                Console.WriteLine($"Employee with Id={emp.Id} not found!");
            }
        }

        public void DeleteEmployee(int id)
        {
            DataTable table = ds.Tables["Employees"];
            DataRow row = table.Rows.Find(id);

            if (row != null)
            {
                row.Delete();
                adapter.Update(ds, "Employees");

                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Employee with Id={id} not found!");
            }
        }
    }
}