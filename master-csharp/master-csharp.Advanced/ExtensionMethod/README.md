# Extension Methods in C#

## Definition
An Extension Method in C# is a static method that allows you to "add" new methods to existing types without modifying the original type, creating a subclass, or recompiling the original type.

It provides a way to extend the functionality of classes, structs, or interfaces in a clean and reusable way.

---

## Purpose
Extension methods are used to:

- Add functionality to existing types
- Improve code readability and maintainability
- Enable fluent syntax and chaining
- Avoid modifying source code of original classes

---

## How It Works
- Defined as a static method in a static class.
- The first parameter specifies the type being extended and is preceded by the `this` keyword.
- The method can be called using instance method syntax on the extended type.

---

## Key Characteristics

- Declared in static classes
- First parameter uses `this` keyword to indicate the target type
- Does not modify the original type
- Can extend multiple types with different methods
- Supports method chaining for fluent syntax

---

## Extension Method vs Regular Method

| Extension Method | Regular Method |
|-----------------|----------------|
| Appears as if it is part of the original type | Defined inside the class or type itself |
| Defined outside the type | Defined inside the type |
| Static method with `this` keyword | Normal instance or static method |
| Useful for adding behavior to types you cannot modify | Modifies the original type directly |

---

## Benefits

- Enables clean, reusable code
- Adds functionality to external or sealed types
- Improves readability with natural syntax
- Supports LINQ-style queries and fluent programming

---

## When to Use Extension Methods

Use extension methods when:

- You want to add methods to existing types without inheritance
- You need to extend sealed or third-party classes
- You want to simplify repetitive operations
- You want to improve readability and expressiveness of your code

---

## Summary
Extension Methods in C# allow developers to add methods to existing types in a clean, reusable, and type-safe manner.  
They enhance readability, support fluent programming, and enable extending functionality without modifying original types.