
namespace master_csharp.App.Interface
{
    class Employee : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }
}
