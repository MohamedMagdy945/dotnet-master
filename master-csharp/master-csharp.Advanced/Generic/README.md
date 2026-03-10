# Generics in C#

## Definition
Generics in C# allow you to define classes, methods, interfaces, and delegates with a placeholder for the data type.  
This enables writing reusable, type-safe, and flexible code without committing to a specific data type.

Generics use type parameters, commonly represented by `T`.

---

## Purpose
Generics are used to:

- Create reusable components
- Ensure type safety at compile time
- Eliminate casting
- Improve performance
- Reduce code duplication

---

## How It Works
- A type parameter is defined using angle brackets `<T>`.
- The actual data type is specified when the generic type is used.
- The compiler replaces the placeholder with the actual type at compile time.

---

## Key Characteristics

- Type-safe
- No runtime casting required
- Better performance than using `object`
- Works with classes, methods, interfaces, and delegates
- Supports constraints on type parameters

---

## Generic Type Parameter

`T` is the most common name, but any valid identifier can be used.  
Multiple type parameters are also supported (e.g., `<TKey, TValue>`).

---

## Generic Constraints

Constraints restrict the types that can be used as type arguments.

Common constraints include:

- `where T : class`
- `where T : struct`
- `where T : new()`
- `where T : BaseClass`
- `where T : InterfaceName`

Constraints improve safety and allow access to specific members.

---

## Generics vs Non-Generics

| Generics | Non-Generics |
|-----------|-------------|
| Type-safe | Requires casting |
| Compile-time checking | Runtime errors possible |
| Better performance | Boxing/unboxing overhead |
| Reusable | Often duplicated code |

---

## Benefits

- Reusability
- Strong type checking
- Improved performance
- Cleaner and more maintainable code
- Reduced duplication

---

## When to Use Generics

Use generics when:

- You need reusable data structures
- You want type safety
- You want to avoid boxing and unboxing
- You are designing libraries or frameworks
- You need flexible and scalable components

---

## Summary
Generics in C# provide a powerful way to write flexible, reusable, and type-safe code.  
They improve performance, reduce duplication, and enhance maintainability by allowing types to be specified at compile time.