using master_csharp.Advanced2.MyRecord;

namespace master_csharp.Advanced2.MyRecord
{
    record Point(int X, int Y);
    public record Person(string FirstName, string LastName)
    {
        // يمكنك إضافة methods
        public string FullName => $"{FirstName} {LastName}";

        // يمكن override للـ ToString
        public override string ToString() => FullName;
    }

    // Record struct (value type) - C# 10+
    public readonly record struct Point3D(int X, int Y , int Z)
    {
        // مثال method
        public double DistanceFromOrigin() => Math.Sqrt(X * X + Y * Y + Z * Z);
    }
}
class RecordUsage()
{

    public static void Use()
    {
        // ===== Record Class =====
        var p1 = new Person("Mohamed", "Ahmed");
        var p2 = new Person("Mohamed", "Ahmed");

        Console.WriteLine(p1);               // Mohamed Ahmed
        Console.WriteLine(p1 == p2);         // True (value-based equality)
        Console.WriteLine(p1.Equals(p2));    // True

        // Copy with modification
        var p3 = p1 with { LastName = "Saeed" };
        Console.WriteLine(p3);               // Mohamed Saeed

        // Deconstruction
        var (first, last) = p1;
        Console.WriteLine(first);            // Mohamed
        Console.WriteLine(last);             // Ahmed

        // ===== Record Struct =====
        var pt1 = new Point3D(3, 4 , 5);
        var pt2 = new Point3D(3, 4 , 5);

        Console.WriteLine(pt1 == pt2);       // True
        Console.WriteLine(pt1.DistanceFromOrigin()); // 5

        // Copy with modification (struct)
        var pt3 = pt1 with { X = 6 };
        Console.WriteLine(pt3);              // Point { X = 6, Y = 4 }

        // Deconstruction
        var (x, y , z) = pt3;
        Console.WriteLine($"x={x}, y={y} , z={z}");  // x=6, y=4, z=5
    }

}