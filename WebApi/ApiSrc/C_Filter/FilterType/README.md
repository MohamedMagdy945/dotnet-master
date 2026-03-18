# ASP.NET Core Filters - Complete Guide

## Overview

This README explains all types of filters in ASP.NET Core MVC, including built-in and custom filters. It also shows the execution pipeline visually.

---

## 1. Types of Filters

| Filter Type          | Built-in Examples                        | Custom Example                                 | Execution Stage                            |
| -------------------- | ---------------------------------------- | ---------------------------------------------- | ------------------------------------------ |
| Authorization Filter | `[Authorize]`, `[AllowAnonymous]`        | `MyAuthorizationFilter : IAuthorizationFilter` | Before Resource, Action, Exception, Result |
| Resource Filter      | `[ResponseCache]`                        | `MyResourceFilter : IResourceFilter`           | Before/After Model Binding                 |
| Action Filter        | `[ValidateAntiForgeryToken]`             | `MyActionFilter : IActionFilter`               | Before/After Action Execution              |
| Result Filter        | `[Produces]`, `[ProducesResponseType]`   | `MyResultFilter : IResultFilter`               | Before/After Result Execution              |
| Exception Filter     | `[ApiController]` automatic 400 handling | `MyExceptionFilter : IExceptionFilter`         | During Action Execution                    |

---

## 2. Custom Filters Examples

### 2.1 Authorization Filter

```csharp
public class MyAuthorizationFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (!context.HttpContext.User.Identity?.IsAuthenticated ?? true)
        {
            context.Result = new UnauthorizedResult();
        }
    }
}
```

### 2.2 Resource Filter

```csharp
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
```

### 2.3 Action Filter

```csharp
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
```

### 2.4 Result Filter

```csharp
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
```

### 2.5 Exception Filter

```csharp
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
```

---

## 3. Applying Filters on Controller

```csharp
[ApiController]
[Route("[controller]")]
[ServiceFilter(typeof(MyAuthorizationFilter))]
[ServiceFilter(typeof(MyResourceFilter))]
[ServiceFilter(typeof(MyActionFilter))]
[ServiceFilter(typeof(MyResultFilter))]
[ServiceFilter(typeof(MyExceptionFilter))]
public class ProductsController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        if (id <= 0)
            throw new Exception("Invalid product id!");

        return Ok(new { Id = id, Name = "Product " + id });
    }
}
```

---

## 4. Built-in Filters Examples

### Authorization Filter

```csharp
[Authorize(Roles = "Admin")]
public IActionResult AdminOnly() => Ok("Only admins");
```

### Resource Filter (ResponseCache)

```csharp
[ResponseCache(Duration = 60)]
public IActionResult GetProducts() => Ok(new[] { "Product1", "Product2" });
```

### Action Filter (Anti-Forgery)

```csharp
[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult CreateProduct(Product model) => Ok(model);
```

### Result Filter (Produces / ResponseType)

```csharp
[Produces("application/json")]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status404NotFound)]
public IActionResult GetProduct(int id) => Ok(new { Id = id });
```

### Exception Filter (ApiController automatic 400)

```csharp
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromBody] Product model)
    {
        return Ok(model); // 400 if ModelState invalid automatically
    }
}
```

---

## 5. MVC Filters Pipeline Diagram

![MVC Filters Pipeline](https://i.imgur.com/4R0VJjE.png)

**Execution Order:**

```text
Authorization → Resource → Action → Exception → Result → Response
```

---

**End of README**
