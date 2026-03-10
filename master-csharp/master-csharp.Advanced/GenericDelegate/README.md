# Generic Delegate in C#

## Definition
A Generic Delegate in C# is a delegate that uses type parameters, allowing it to reference methods with different parameter and return types while maintaining type safety.  
It is a flexible way to define reusable method references without specifying concrete types upfront.

---

## Purpose
Generic delegates are used to:

- Pass methods as parameters with type flexibility
- Avoid creating multiple delegate types for different data types
- Ensure compile-time type safety
- Reuse delegate definitions across different types

---

## How It Works
- Declared using type parameters in angle brackets `<T>` (or multiple parameters like `<T1, T2>`).
- Methods assigned to the generic delegate must match the delegate’s parameter types and return type.
- When the delegate is used, the actual types are specified.

---

## Key Characteristics

- Type-safe
- Reusable for different data types
- Can work with methods having different input and output types
- Supports multiple type parameters
- Can be combined with lambda expressions or named methods

---

## Generic vs Regular Delegate

| Generic Delegate | Regular Delegate |
|-----------------|----------------|
| Can work with multiple types | Tied to specific types |
| Reusable and flexible | Requires separate declaration for each type |
| Type-safe at compile time | Type-safe but less flexible |
| Supports type parameters | Fixed parameters and return type |

---

## Built-in Generic Delegates

C# provides predefined generic delegates:

- `Action<T>` → Represents a method that does not return a value.
- `Func<T, TResult>` → Represents a method that returns a value.
- `Predicate<T>` → Represents a method that returns a boolean.

---

## Benefits

- Reduces the need for multiple delegate definitions
- Improves code reusability
- Ensures type safety
- Supports flexible programming patterns like callbacks and events

---

## When to Use Generic Delegates

Use generic delegates when:

- You want to pass methods as parameters with varying types
- You need a reusable delegate for multiple types
- You want type-safe callbacks or event handling
- You are designing flexible, reusable libraries or components

---

## Summary
A Generic Delegate in C# allows methods to be referenced with flexible, type-safe signatures.  
It enhances reusability, supports multiple types, and reduces code duplication in delegate-based programming.