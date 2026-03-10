# Struct in C#

## Definition
A Struct in C# is a value type that is used to encapsulate small groups of related variables, such as properties, fields, and methods.  
Structs are typically used for lightweight objects that do not require reference semantics.

---

## Purpose
Structs are used to:

- Represent simple data structures
- Group related data together
- Improve performance by avoiding heap allocation for small objects
- Provide value-type semantics (copied by value)

---

## How It Works
- Declared using the `struct` keyword.
- Can contain fields, properties, methods, constructors, and events.
- Inherits from `System.ValueType` implicitly.
- Cannot have a default parameterless constructor (before C# 10).
- Stored on the stack (typically), unlike classes which are reference types stored on the heap.

---

## Key Characteristics

- Value type (copied by value)
- Cannot inherit from other structs or classes (except `System.ValueType`)
- Can implement interfaces
- Lightweight and efficient for small objects
- Supports constructors, methods, properties, and operators

---

## Struct vs Class

| Struct | Class |
|--------|-------|
| Value type | Reference type |
| Stored on stack (usually) | Stored on heap |
| Copied by value | Copied by reference |
| Cannot have inheritance | Supports inheritance |
| Good for small, immutable data | Good for complex objects |

---

## Benefits

- Efficient memory usage for small objects
- Avoids overhead of garbage collection for short-lived objects
- Supports encapsulation and methods like classes
- Ideal for representing lightweight data types like points, colors, or coordinates

---

## When to Use Structs

Use structs when:

- You have small, logically grouped data
- The object is immutable or short-lived
- You want value-type semantics
- You do not need inheritance from another type

---

## Summary
A Struct in C# is a value type that encapsulates related data and behavior in a lightweight, efficient way.  
It is suitable for small data structures where performance and value-type behavior are important.