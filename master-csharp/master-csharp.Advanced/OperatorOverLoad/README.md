# Operator Overloading in C#

## Definition
Operator Overloading in C# is a feature that allows you to redefine or customize the behavior of operators (`+`, `-`, `*`, `==`, etc.) for user-defined classes and structs.  
It enables objects of a class to interact using standard operators in a meaningful way.

---

## Purpose
The main purpose of operator overloading is to:

- Make custom classes behave like built-in types
- Provide intuitive syntax for operations on objects
- Improve code readability
- Support mathematical, logical, or relational operations on objects

---

## How It Works
- Defined inside a class or struct using the `operator` keyword.
- Must be declared as `public` and `static`.
- Operands must include at least one user-defined type.
- Returns the result of the operation, typically a new object or value.

---

## Key Characteristics

- Only certain operators can be overloaded.
- Unary and binary operators are supported.
- Assignment operators (like `=`) cannot be directly overloaded.
- Overloading must be consistent with the operator's conventional meaning.
- Improves expressiveness of custom types.

---

## Benefits

- Provides natural syntax for object operations
- Makes code more readable and maintainable
- Allows user-defined types to integrate seamlessly with standard operators
- Enables intuitive comparisons, arithmetic, or logical operations

---

## Operator Overloading vs Methods

- Methods require explicit calls: `obj.Add(other)`.
- Operator overloading allows: `obj + other`.
- Operator overloading improves readability for operations involving multiple objects.

---

## When to Use Operator Overloading

Use operator overloading when:

- You are creating a mathematical or complex data type
- You want objects to behave like primitive types
- You want clean and intuitive syntax for object operations
- You are implementing value types or domain-specific classes (e.g., fractions, vectors, matrices)

---

## Summary
Operator Overloading in C# is a feature that allows customizing the behavior of operators for user-defined types.  
It enhances readability, allows objects to behave naturally with standard operators, and improves the expressiveness of your code.