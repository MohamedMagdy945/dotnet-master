
namespace master_csharp.Assembly.GarbageCollector
{
    class GarbageCollectorExample
    {
        public static void Test()
        {
            Console.WriteLine("Before allocation:");
            Console.WriteLine(GC.GetTotalMemory(false));

            for (int i = 0; i < 1000000; i++)
            {
                var arr = new byte[1024]; // 1 KB
            }

            Console.WriteLine("After allocation:");
            Console.WriteLine(GC.GetTotalMemory(false));

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("After GC:");
            Console.WriteLine(GC.GetTotalMemory(true));
        }

    }
    class GarbageCollectorExample2
    {
       public static void Test()
        {
            ProcessHugeImages();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void ProcessHugeImages()
        {
            // big data load in memeory
        }
    }
}