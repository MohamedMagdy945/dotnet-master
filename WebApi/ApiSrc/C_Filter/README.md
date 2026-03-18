# ASP.NET Core Filters - Complete Guide

## What are Filters?

Filters in ASP.NET Core are components that run before or after certain stages in the MVC pipeline (Controller/Action execution).

They are used to handle cross-cutting concerns like:

* Logging
* Validation
* Authorization
* Exception handling

---

## Filter Pipeline (Execution Order)

```
Authorization Filters
        ↓
Resource Filters
        ↓
Action Filters
        ↓
Action Execution (Controller)
        ↓
Result Filters
        ↓
Response
```

---

## Types of Filters

### 1. Authorization Filters

* Run first
* Used for security checks

---

### 2. Resource Filters

* Run before model binding
* Used for caching or performance

---

### 3. Action Filters

* Run before and after controller action

```
OnActionExecuting → before action
OnActionExecuted → after action
```

---

### 4. Result Filters

* Run before and after result execution

---

### 5. Exception Filters

* Handle exceptions from controllers

---

## Creating Custom Filter

### Example: Action Filter

```
public class LogActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Before Action");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("After Action");
    }
}
```

---

## Registering Filters

### 1. Global

```
builder.Services.AddControllers(options =>
{
    options.Filters.Add<LogActionFilter>();
});
```

### 2. Controller Level

```
[ServiceFilter(typeof(LogActionFilter))]
public class ProductsController : Controller
{
}
```

### 3. Action Level

```
[ServiceFilter(typeof(LogActionFilter))]
public IActionResult Get()
{
    return Ok();
}
```

---

## Filter vs Middleware

| Feature         | Middleware  | Filters       |
| --------------- | ----------- | ------------- |
| Scope           | Global      | MVC only      |
| Runs Before MVC | Yes         | No            |
| Access          | HttpContext | ActionContext |

---

## Real Example Flow

```
Request
   |
   v
Middleware Pipeline
   |
   v
Filters (Authorization → Action → Result)
   |
   v
Controller
   |
   v
Response
```

---

## Common Use Cases

* Logging requests
* Custom validation
* Handling exceptions
* Modifying response

---

## Common Mistakes

* Using filters instead of middleware incorrectly
* Putting heavy logic inside filters

---

## Summary

Filters are:

* Part of MVC pipeline
* More specific than middleware
* Used for controller-level logic

---

## Pro Tip 🔥

Use middleware for global logic.
Use filters for controller/action-specific logic.
