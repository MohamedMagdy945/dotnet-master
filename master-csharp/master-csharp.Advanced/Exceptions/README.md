# Exception Handling in C#

## Definition
An Exception in C# is a runtime error that disrupts the normal flow of program execution.  
Exception Handling is a mechanism used to detect, handle, and respond to these runtime errors in a controlled way.

---

## Purpose
Exception handling is used to:

- Prevent program crashes
- Handle unexpected runtime errors
- Maintain application stability
- Provide meaningful error messages
- Separate error-handling logic from normal code

---

## How It Works
C# uses structured exception handling with the following keywords:

- `try` → Contains code that may cause an exception.
- `catch` → Handles the exception.
- `finally` → Executes code regardless of whether an exception occurs.
- `throw` → Used to explicitly throw an exception.

When an error occurs inside a `try` block, execution immediately transfers to the matching `catch` block.

---

## Exception Hierarchy
All exceptions in C# derive from:

`System.Exception`

Common exception types include:

- Arithmetic-related exceptions
- Null reference exceptions
- Invalid operation exceptions
- Index out-of-range exceptions
- Format exceptions

---

## Types of Exceptions

### System Exceptions
Built-in exceptions provided by the .NET runtime.

### Application Exceptions
Custom exceptions defined by the developer.

---

## Multiple Catch Blocks
You can define multiple `catch` blocks to handle different exception types separately.  
The most specific exceptions should be caught before general ones.

---

## Finally Block
The `finally` block always executes, whether an exception occurs or not.  
It is commonly used for:

- Closing files
- Releasing resources
- Cleaning up operations

---

## Custom Exceptions
Developers can create custom exception classes by inheriting from `System.Exception`.  
This is useful for handling domain-specific errors.

---

## Exception vs Error Code

| Exception Handling | Error Code Handling |
|--------------------|--------------------|
| Structured and clean | Requires manual checks |
| Separates logic from errors | Mixes logic with error handling |
| Propagates automatically | Must be manually passed |
| More readable and maintainable | Less structured |

---

## Best Practices

- Catch specific exceptions instead of general ones.
- Avoid empty catch blocks.
- Use finally to release resources.
- Do not use exceptions for normal program flow.
- Provide meaningful error messages.

---

## When to Use Exception Handling

Use exception handling when:

- Performing file or database operations
- Working with user input
- Handling network operations
- Dealing with unpredictable runtime behavior

---

## Summary
Exception Handling in C# provides a structured way to detect and manage runtime errors.  
It improves program stability, enhances maintainability, and ensures controlled error management in applications.