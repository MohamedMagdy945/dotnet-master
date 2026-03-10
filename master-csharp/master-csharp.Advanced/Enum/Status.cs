
using master_csharp.App.Enum;

namespace master_csharp.App.Enum
{
    enum Status
    {
        Pending = 1,
        Approved = 5,
        Rejected = 10
    }
}
public class EnumUsage2
{
    public void Test()
    {

        Status orderStatus = Status.Approved;
        Console.WriteLine(orderStatus);      // Approved
        Console.WriteLine((int)orderStatus); // 5
    }
}