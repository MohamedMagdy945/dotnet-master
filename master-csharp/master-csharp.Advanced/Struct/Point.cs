

using master_csharp.App.Struct;

namespace master_csharp.App.Struct
{
    public struct Point
    {
        public int X;
        public int Y;

        // Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method
        public void Display()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }
}
class StructUsage
{
    public static void Test()
    {
        Point p1 = new Point(5, 10);

        Point p2 = p1; // copy all value type 

        p2.X = 20; // not affect at p1


        p1.Display(); // (5, 10) // same value
        p2.Display(); // (20, 10) // new value
    }
}
