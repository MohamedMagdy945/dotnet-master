using System;
using System.Collections.Generic;

namespace DelegateExamples
{
    // تعريف delegate
    delegate bool CheckNoDelegate(int number);

    class DelegateExpression
    {
        public static void Use(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };

            // 1. طريقة عادية (method reference)
            CheckNoDelegate checkDel1 = CheckEven;
            Filter(list, checkDel1);

            // 2. طريقة anonymous delegate
            CheckNoDelegate checkDel2 = delegate (int no) { return no % 3 == 0; };
            Filter(list, checkDel2);

            // 3. طريقة lambda expression (اختصار للأعلى)
            CheckNoDelegate checkDel3 = no => no % 2 != 0;
            Filter(list, checkDel3);

            // 4. استخدام lambda مباشرة مع الدالة (مثل LINQ)
            Filter(list, delegate (int x)
            { return x > 3; }

            );

            Filter(list, (x) => { return x > 3; });
            Filter(list, x => x > 3);
        }

        // دالة للتصفية
        static void Filter(List<int> numbers, CheckNoDelegate check)
        {
            foreach (var n in numbers)
            {
                if (check(n))
                {
                    Console.WriteLine(n);
                }
            }
        }

        // دالة عادية للفحص
        static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
    }
}