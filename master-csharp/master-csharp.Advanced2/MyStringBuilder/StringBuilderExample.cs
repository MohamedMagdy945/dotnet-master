

using System.Text;

namespace master_csharp.Advanced2.MyStringBuilder
{
    internal class StringBuilderExample
    {
        public static void Use()
        {
            // إنشاء StringBuilder بسعة مبدئية
            StringBuilder sb = new StringBuilder("Hello", 50);

            Console.WriteLine($"Initial: {sb}");
            Console.WriteLine($"Capacity: {sb.Capacity}");
            Console.WriteLine($"Length: {sb.Length}");

            // 1️⃣ Append
            sb.Append(" World");
            Console.WriteLine($"After Append: {sb}");

            // 2️⃣ AppendLine
            sb.AppendLine();
            sb.AppendLine("This is a new line.");
            Console.WriteLine("After AppendLine:");
            Console.WriteLine(sb);

            // 3️⃣ Insert
            sb.Insert(0, "Start: ");
            Console.WriteLine($"After Insert: {sb}");

            // 4️⃣ Replace
            sb.Replace("World", "C#");
            Console.WriteLine($"After Replace: {sb}");

            // 5️⃣ Remove
            sb.Remove(0, 7); // حذف أول 7 أحرف
            Console.WriteLine($"After Remove: {sb}");

            // 6️⃣ Clear
            sb.Clear();
            Console.WriteLine($"After Clear: '{sb}'");

            // 7️⃣ Loop example (الاستخدام الحقيقي)
            StringBuilder numbers = new StringBuilder();

            for (int i = 1; i <= 5; i++)
            {
                numbers.Append(i).Append(", ");
            }

            Console.WriteLine($"Numbers: {numbers}");

            // تحويله إلى string
            string finalString = numbers.ToString();
            Console.WriteLine($"Final String: {finalString}");
        }
    }
}
