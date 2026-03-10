

using master_csharp.App.Enum;

namespace master_csharp.App.Enum
{
    [Flags]
    enum Permission
    {
        Read = 1,
        Write = 2,
        Execute = 4
    }
}
public class EnumUsage3
{
    public void Test()
    {

        Permission p = Permission.Read | Permission.Write;
        Console.WriteLine(p); // Read, Write
    }
}
