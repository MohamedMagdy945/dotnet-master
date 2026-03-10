
using System.Drawing;

namespace master_csharp.Advanced2.Nullable
{
    struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"Point({X}, {Y})";
    }
}
class NullableUsage
{
    static void Use()
    {
        // ----------------------------
        // 1️⃣ Nullable Value Types
        // ----------------------------
        int? nullableInt = null;          // int? هو Nullable<int>
        Console.WriteLine($"nullableInt = {nullableInt}"); // null

        nullableInt = 42;
        Console.WriteLine($"nullableInt = {nullableInt}"); // 42

        // استخدام HasValue و Value
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"Value inside nullableInt: {nullableInt.Value}");
        }

        // Null-coalescing operator ??
        int normalInt = nullableInt ?? 0;  // إذا nullableInt null، نستخدم 0
        Console.WriteLine($"normalInt = {normalInt}");

        // ----------------------------
        // 2️⃣ Nullable Struct
        // ----------------------------
        Point? nullablePoint = null;       // Nullable<Point>
        Console.WriteLine($"nullablePoint = {nullablePoint}"); // null

        nullablePoint = new Point(5, 10);
        Console.WriteLine($"nullablePoint = {nullablePoint}"); // Point(5, 10)

        if (nullablePoint.HasValue)
        {
            Console.WriteLine($"X = {nullablePoint.Value.X}, Y = {nullablePoint.Value.Y}");
        }

        // Null-coalescing with structs
        Point defaultPoint = nullablePoint ?? new Point(0, 0);
        Console.WriteLine($"defaultPoint = {defaultPoint}");

        // ----------------------------
        // 3️⃣ Reference Types
        // ----------------------------
        string? nullableString = null;     // string? يسمح بقيمة null
        Console.WriteLine($"nullableString = {nullableString}");

        nullableString = "Hello, C#!";
        Console.WriteLine($"nullableString = {nullableString}");

        // Null-coalescing
        string message = nullableString ?? "Default Message";
        Console.WriteLine(message);

        // ----------------------------
        // 4️⃣ Differences
        // ----------------------------
        // Value types without nullable can't be null
        int regularInt = 0;
        // regularInt = null; // ❌ خطأ

        // Reference types without nullable can still be null in C# < 8.0
        string regularString = null; // ✅ ممكن في C# <8.0
    }
}