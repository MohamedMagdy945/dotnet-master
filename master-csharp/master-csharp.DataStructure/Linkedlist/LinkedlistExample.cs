
namespace master_csharp.DataStructure.Linkedlist
{
     class LinkedlistExample
    {
        public static void Use()
        {
            LinkedList<string> students = new LinkedList<string>();

            // إضافة عناصر
            students.AddLast("Ali");
            students.AddLast("Sara");
            students.AddFirst("Omar");
            students.AddAfter(students.First, "Mona"); // بعد Omar
            students.AddBefore(students.Last, "Hassan"); // قبل Sara

            // الوصول للخصائص
            Console.WriteLine("First Student: " + students.First.Value);
            Console.WriteLine("Last Student: " + students.Last.Value);
            Console.WriteLine("Total Students: " + students.Count);

            // البحث عن عنصر
            var node = students.Find("Mona");
            if (node != null)
                Console.WriteLine("Found: " + node.Value);

            // إزالة عناصر
            students.Remove("Hassan");
            students.RemoveFirst();
            students.RemoveLast();

            // التكرار على العناصر
            Console.WriteLine("\nRemaining Students:");
            foreach (var s in students)
                Console.WriteLine(s);

            // استخدام العقد للتكرار
            Console.WriteLine("\nUsing LinkedListNode:");
            LinkedListNode<string> current = students.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            // نسخ LinkedList إلى Array
            string[] array = new string[students.Count];
            students.CopyTo(array, 0);
            Console.WriteLine("\nArray copy:");
            foreach (var s in array)
                Console.WriteLine(s);
        }
    }
}
