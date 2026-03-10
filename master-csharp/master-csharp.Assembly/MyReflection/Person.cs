using master_csharp.Assembly.MyReflection;
using System;
using System.Reflection;


namespace master_csharp.Assembly.MyReflection
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }
}


class ReflectoinUsage
{
    public static void Use()
    {
        Type type = typeof(Person); // Get type information

        Console.WriteLine("Properties:");
        foreach (var prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name + " : " + prop.PropertyType);
        }

        Console.WriteLine("\nMethods:");
        foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            Console.WriteLine(method.Name);
        }
    }
}