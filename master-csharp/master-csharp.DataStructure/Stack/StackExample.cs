
namespace master_csharp.DataStructure.Stack
{
    class StackExample
    {
        public static void Use()
        {
            Stack<string> books = new Stack<string>();

            // 1. إضافة عناصر
            books.Push("Book 1");
            books.Push("Book 2");
            books.Push("Book 3");

            Console.WriteLine("All books in stack (top to bottom):");
            foreach (var b in books)
                Console.WriteLine(b);

            // 2. عرض العنصر العلوي بدون إزالة
            Console.WriteLine("\nTop book: " + books.Peek());

            // 3. إزالة العنصر العلوي
            string removed = books.Pop();
            Console.WriteLine("Removed: " + removed);

            // 4. التكرار بعد إزالة عنصر
            Console.WriteLine("\nRemaining books:");
            foreach (var b in books)
                Console.WriteLine(b);

            // 5. التحقق من وجود عنصر
            Console.WriteLine("\nContains 'Book 2'? " + books.Contains("Book 2"));

            // 6. نسخ إلى مصفوفة
            string[] booksArray = books.ToArray();
            Console.WriteLine("\nBooks copied to array:");
            foreach (var b in booksArray)
                Console.WriteLine(b);

            // 7. Count
            Console.WriteLine("\nTotal books in stack: " + books.Count);
        }
    }
}
