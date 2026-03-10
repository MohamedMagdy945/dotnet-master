using master_csharp.Threading.MyTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_csharp.Threading.MyTask
{
    class TaskExample
    {
       
        //========================
        // 1. Simple Task
        //========================
        public void SimpleTask()
        {
            Task t = Task.Run(() =>
            {
                Console.WriteLine("Simple Task running on ThreadPool thread.");
                Thread.Sleep(500);
            });

            t.Wait(); // Wait until task completes
        }

        //========================
        // 2. Task with Return Value
        //========================
        public async Task TaskWithReturnAsync()
        {
            Task<int> t = Task.Run(() =>
            {
                int sum = 0;
                for (int i = 1; i <= 5; i++)
                {
                    sum += i;
                    Console.WriteLine($"Adding {i}, sum = {sum}");
                    Thread.Sleep(300);
                }
                return sum;
            });

            int result = await t;
            Console.WriteLine("Task result = " + result);
        }

        //========================
        // 3. Async / Await Task
        //========================
        public async Task AsyncAwaitExample()
        {
            Console.WriteLine("Starting Async Task...");
            int value = await ComputeAsync();
            Console.WriteLine("Async result = " + value);
        }

        private async Task<int> ComputeAsync()
        {
            await Task.Delay(1000); // Simulate work
            return 42;
        }

        //========================
        // 4. Task Continuation
        //========================
        public async Task ContinuationExampleAsync()
        {
            Task t1 = Task.Run(() => Console.WriteLine("First Task running..."));
            Task t2 = t1.ContinueWith(prev => Console.WriteLine("Continuation Task running..."));
            await t2;
        }

        //========================
        // 5. Task Cancellation
        //========================
        public void CancellationExample()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task cancelled!");
                        return;
                    }
                    Console.WriteLine("Running " + i);
                    Thread.Sleep(500);
                }
            }, token);

            // Cancel after 1.5 seconds
            Task.Delay(1500).Wait();
            cts.Cancel();

            t.Wait();
        }

        //========================
        // 6. Parallel Tasks
        //========================
        public async Task ParallelTasksAsync()
        {
            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Task 1: " + i);
                    Thread.Sleep(400);
                }
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Task 2: " + i);
                    Thread.Sleep(400);
                }
            });

            await Task.WhenAll(t1, t2);
            Console.WriteLine("Both parallel tasks finished");
        }
    }
}

class TaskUsage
{
    public static async Task Use()
    {
        TaskExample demo = new TaskExample();

        demo.SimpleTask();
        await demo.TaskWithReturnAsync();
        await demo.AsyncAwaitExample();
        await demo.ContinuationExampleAsync();
        demo.CancellationExample();
        await demo.ParallelTasksAsync();
    }
}