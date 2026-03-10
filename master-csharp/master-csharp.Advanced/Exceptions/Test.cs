using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_csharp.App.Exceptions
{
    internal class Test 
    {
        public void execption()
        {
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("cannot divide by zero");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine( "finally in all pathes");
            }
        }
    }
}
