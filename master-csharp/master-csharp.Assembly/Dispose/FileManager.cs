using master_csharp.Assembly.Dispose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_csharp.Assembly.Dispose
{
   
    // Class اللي بتتعامل مع موارد Unmanaged (مثلاً FileHandle)
    public class FileManager : IDisposable
    {
        private FileStream _fileStream;  // Managed object بيحتوي على Unmanaged resource
        private bool _disposed = false;  // Flag لتجنب استدعاء Dispose أكتر من مرة

        public FileManager(string fileName)
        {
            _fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            Console.WriteLine("FileManager: File opened");
        }

        // Public Dispose method
        public void Dispose()
        {
            Dispose(true);             // ندي الـ Dispose signal
            GC.SuppressFinalize(this); // لمنع Finalizer من التشغيل
        }

        // Protected Dispose method
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;     // لو Already disposed متعملش حاجة

            if (disposing)
            {
                // هنا ننضف Managed resources
                if (_fileStream != null)
                {
                    _fileStream.Close();
                    _fileStream = null;
                    Console.WriteLine("FileManager: Managed resources disposed");
                    //_fileStream?.Dispose();
                }
            }

            // هنا ننضف Unmanaged resources (لو موجودة)
            // مثال: Native handles, COM objects
            Console.WriteLine("FileManager: Unmanaged resources cleaned if any");

            _disposed = true;
        }

        // Destructor / Finalizer
        ~FileManager()
        {
            Dispose(false);  // لو Finalizer اتنادى يبقى Manage resources ممكن يكونوا اتنضفوا بالفعل
            Console.WriteLine("FileManager: Destructor called");
        }
    }

}
class DisposeUsage
{
    public static void Use()
    {
        // استخدام with Dispose (Using statement)
        using (var fm = new FileManager("test.txt"))
        {
            Console.WriteLine("Using FileManager...");
        } // هنا Dispose هيتنادى تلقائي

        Console.WriteLine("---------------------");

        // استخدام بدون Using
        var fm2 = new FileManager("test2.txt");
        fm2.Dispose(); // لازم نناديه يدويًا

        Console.WriteLine("End of program, waiting for GC...");

        // نجبر GC Finalizer للتوضيح
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Program finished");
    }
}
