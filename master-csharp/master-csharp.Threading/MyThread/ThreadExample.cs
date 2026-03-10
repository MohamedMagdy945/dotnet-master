

using master_csharp.Threading.MyThread;

namespace master_csharp.Threading.MyThread
{

    public class ThreadDemo
    {
        private readonly object _lockObj = new object();

        //========================
        // 1. Basic Thread
        //========================
        public void RunThread()
        {
            Thread t = new Thread(PrintNumbers);
            t.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(500);
            }
        }

        public void PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Child Thread: " + i);
                Thread.Sleep(500);
            }
        }


        public void PrintNumbersTask()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Child Task: " + i);
                Task.Delay(500).Wait();
            }
        }

        //========================
        // 3. lock Example
        //========================
        private int _counter = 0;
        public void IncrementWithLock()
        {
            lock (_lockObj)
            {
                _counter++;
                Console.WriteLine("Lock Counter: " + _counter);
            }
        }

        //========================
        // 4. Monitor Example
        //========================
        public void IncrementWithMonitor()
        {
            Monitor.Enter(_lockObj);
            try
            {
                _counter++;
                Console.WriteLine("Monitor Counter: " + _counter);
            }
            finally
            {
                Monitor.Exit(_lockObj);
            }
        }

        //========================
        // 5. Mutex Example (cross-process)
        //========================
        public void RunMutexExample()
        {
            using (Mutex mutex = new Mutex(false, "MyUniqueAppMutex"))
            {
                Console.WriteLine("Trying to acquire mutex...");
                if (!mutex.WaitOne(0, false))
                {
                    Console.WriteLine("Another instance is already running!");
                    return;
                }

                Console.WriteLine("Mutex acquired. Running critical section...");
                Console.WriteLine("Press Enter to release mutex.");
                Console.ReadLine();

                mutex.ReleaseMutex();
            }
        }

        //========================
        // 6. ThreadPool Example
        //========================
        public void RunThreadPool()
        {
            ThreadPool.QueueUserWorkItem(PrintThreadPoolNumbers);
            Console.WriteLine("ThreadPool task queued.");
        }

        private void PrintThreadPoolNumbers(object state)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ThreadPool Thread: " + i);
                Thread.Sleep(500);
            }
        }
    }
}
class ThraedUsage
{
    public static void Use()
    {
        ThreadDemo demo = new ThreadDemo();

        // 1. Thread
        demo.RunThread();


        // 3. Lock
        demo.IncrementWithLock();

        // 4. Monitor
        demo.IncrementWithMonitor();

        // 5. Mutex
        demo.RunMutexExample();

        // 6. ThreadPool
        demo.RunThreadPool();

        Console.ReadLine(); // To keep console open
    }
}