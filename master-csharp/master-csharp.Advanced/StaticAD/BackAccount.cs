using master_csharp.Advanced.StaticAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_csharp.Advanced.StaticAD
{
    class BankAccount
    {
        // ===============================
        // 1️⃣ Static Field (مشترك بين كل الكائنات)
        // ===============================
        public static int TotalAccounts = 0;

        // ===============================
        // 2️⃣ Instance Field (خاص بكل كائن)
        // ===============================
        public string Owner;
        public double Balance;

        // ===============================
        // 3️⃣ Static Constructor
        // ===============================
        static BankAccount()
        {
            Console.WriteLine("Static Constructor Called Once!");
            TotalAccounts = 0;
        }

        // ===============================
        // 4️⃣ Normal Constructor
        // ===============================
        public BankAccount(string owner, double balance)
        {
            Owner = owner;
            Balance = balance;
            TotalAccounts++; // كل مرة نعمل كائن يزيد العداد
        }

        // ===============================
        // 5️⃣ Instance Method
        // ===============================
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        // ===============================
        // 6️⃣ Static Method
        // ===============================
        public static void PrintTotalAccounts()
        {
            Console.WriteLine($"Total Accounts: {TotalAccounts}");
        }
    }

}
class StaticUsage
{
    public static void Use()
    {
        // استدعاء static method بدون new
        BankAccount.PrintTotalAccounts();

        var acc1 = new BankAccount("Mohamed", 1000);
        var acc2 = new BankAccount("Ali", 2000);

        acc1.Deposit(500);

        Console.WriteLine($"Acc1 Balance: {acc1.Balance}");
        Console.WriteLine($"Acc2 Balance: {acc2.Balance}");

        // استدعاء static field
        Console.WriteLine($"Total Accounts: {BankAccount.TotalAccounts}");
    }
}
