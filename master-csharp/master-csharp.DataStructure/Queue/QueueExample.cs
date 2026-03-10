

namespace master_csharp.DataStructure.Queue
{
    class QueueExample
    {
        public static void Use()
        {
            Queue<string> tasks = new Queue<string>();

            // 1. إضافة عناصر
            tasks.Enqueue("Task 1");
            tasks.Enqueue("Task 2");
            tasks.Enqueue("Task 3");


            // 2. عرض أول عنصر بدون إزالة
            Console.WriteLine("\nNext task: " + tasks.Peek());

            // 3. إزالة أول عنصر
            string completed = tasks.Dequeue();
            Console.WriteLine("Completed: " + completed);

            // 4. التكرار بعد إزالة عنصر
            Console.WriteLine("\nRemaining tasks:");
            foreach (var task in tasks)
                Console.WriteLine(task);

            // 5. التحقق من وجود عنصر
            Console.WriteLine("\nContains 'Task 2'? " + tasks.Contains("Task 2"));

            // 6. نسخ إلى مصفوفة
            string[] tasksArray = tasks.ToArray();
            Console.WriteLine("\nTasks copied to array:");
            foreach (var t in tasksArray)
                Console.WriteLine(t);

            // 7. Count
            Console.WriteLine("\nTotal tasks in queue: " + tasks.Count);
        }
    }
}
