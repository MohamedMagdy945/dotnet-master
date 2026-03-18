using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiSrc.C_Filter
{
    public class MyAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // مثال: منع access لو مش authenticated
            if (!context.HttpContext.User.Identity?.IsAuthenticated ?? true)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }

    // 2️⃣ Resource Filter
    public class MyResourceFilter : IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("Before Resource Execution");
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("After Resource Execution");
        }
    }

    // 3️⃣ Action Filter
    public class MyActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Before Action Execution");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("After Action Execution");
        }
    }

    // 4️⃣ Result Filter
    public class MyResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("Before Result Execution");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("After Result Execution");
        }
    }

    // 5️⃣ Exception Filter
    public class MyExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            Console.WriteLine("Exception Caught: " + context.Exception.Message);
            context.Result = new ContentResult
            {
                Content = "An error occurred: " + context.Exception.Message
            };
            context.ExceptionHandled = true;
        }

    }
}
