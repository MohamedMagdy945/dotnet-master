

namespace master_csharp.App.Enum
{
    enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
public class EnumUsage
{
    public void Test()
    {
        master_csharp.App.Enum.DayOfWeek today = master_csharp.App.Enum.DayOfWeek.Wednesday;
        Console.WriteLine(today);       // Wednesday
        Console.WriteLine((int)today);  // 3
    }
}