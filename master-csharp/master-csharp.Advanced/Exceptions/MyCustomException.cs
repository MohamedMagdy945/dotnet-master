
using master_csharp.App.Exceptions;

namespace master_csharp.App.Exceptions
{

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)
        {
        }
    }
}
public class ExceptionUsage
{
    public void Test()
    {
        throw new MyCustomException("exception occure");
    }
}