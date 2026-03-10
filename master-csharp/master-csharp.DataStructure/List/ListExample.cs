

namespace master_csharp.DataStructure.List
{
    class ListExample
    {
        public static void Use()
        {
            // 1. إنشاء List بأنواع مختلفة
            List<int> numbers = new List<int>() { 10, 20, 30 };
            List<string> names = new List<string>() { "Ali", "Sara", "Omar" };

            // 2. إضافة عناصر
            numbers.Add(40);                       // إضافة عنصر واحد
            numbers.AddRange(new int[] { 50, 60 }); // إضافة مجموعة عناصر

            names.Add("Mona");
            names.AddRange(new List<string> { "Hassan", "Laila" });

            // 3. إدراج عناصر في موقع محدد
            numbers.Insert(1, 15);                  // إدراج 15 في الموقع 1
            names.InsertRange(2, new string[] { "Nour", "Khaled" }); // إدراج مجموعة

            // 4. الوصول إلى العناصر باستخدام Indexer
            Console.WriteLine("First number: " + numbers[0]);
            numbers[0] = 5; // تعديل
            Console.WriteLine("Modified first number: " + numbers[0]);

            // 5. إزالة العناصر
            numbers.Remove(30);           // إزالة أول ظهور للعنصر 30
            numbers.RemoveAt(2);          // إزالة العنصر في الموقع 2
            numbers.RemoveAll(x => x > 50); // إزالة كل العناصر الأكبر من 50
                                            // names.Clear();             // Uncomment لإفراغ القائمة بالكامل

            // 6. البحث عن عناصر
            Console.WriteLine("\nContains 20? " + numbers.Contains(20));
            Console.WriteLine("IndexOf 20: " + numbers.IndexOf(20));
            Console.WriteLine("Exists > 10? " + numbers.Exists(x => x > 10));
            int firstOver10 = numbers.Find(x => x > 10);
            Console.WriteLine("First number > 10: " + firstOver10);

            // 7. ترتيب العناصر
            numbers.Sort();                       // ترتيب تصاعدي
            numbers.Reverse();                    // عكس الترتيب
            numbers.Sort((a, b) => b - a);        // ترتيب تنازلي باستخدام Lambda

            names.Sort();                         // ترتيب الأسماء أبجدياً

            // 8. التحويل بين Array و List
            int[] numArray = numbers.ToArray();    // تحويل إلى مصفوفة
            List<int> numCopy = new List<int>(numArray); // إنشاء نسخة

            // 9. الوصول للخصائص
            Console.WriteLine("\nNumbers Count: " + numbers.Count);
            Console.WriteLine("Numbers Capacity: " + numbers.Capacity);

            // 10. التكرار على العناصر
            Console.WriteLine("\nNumbers:");
            foreach (var n in numbers)
                Console.WriteLine(n);

            Console.WriteLine("\nNames:");
            for (int i = 0; i < names.Count; i++)
                Console.WriteLine(names[i]);

            Console.WriteLine("\nUsing ForEach lambda:");
            names.ForEach(name => Console.WriteLine(name));

            // 11. نسخة كاملة واستخدامها
            List<string> namesCopy = new List<string>(names);
            Console.WriteLine("\nCopied Names List:");
            namesCopy.ForEach(Console.WriteLine);
        }
        
    }
}
