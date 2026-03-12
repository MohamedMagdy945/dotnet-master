
namespace Dapper_DotNet
{
    public interface IEmployeeRepository
    {
        void Add(Employee emp);

        List<Employee> GetAll();

        Employee GetById(int id);

        void Update(Employee emp);

        void Delete(int id);
    }
}

