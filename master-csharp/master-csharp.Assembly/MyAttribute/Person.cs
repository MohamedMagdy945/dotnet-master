

using master_csharp.Assembly.MyAttribute;
using System.Reflection;

namespace master_csharp.Assembly.MyAttribute
{
    public class Person
    {
        [Info("Name of the person")]
        public string Name;

        [Info("Age of the person")]
        public int Age;
    }
}
class PersonUsage
{
    public static void Use()
    {
        // 10 objects
        Person[] people = new Person[10];
        for (int i = 0; i < people.Length; i++)
        {
            people[i] = new Person { Name = $"Person {i}", Age = 20 + i };
        }

        Console.WriteLine("---- Loop 1: Reflection لكل object ----");
        foreach (var p in people)
        {
            FieldInfo field = typeof(Person).GetField("Name");
            var attr = field.GetCustomAttribute<InfoAttribute>();
            Console.WriteLine($"{p.Name} -> {attr.Description}");
        }

    }
}