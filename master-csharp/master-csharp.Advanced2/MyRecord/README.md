# Record in C#

## What is a Record?

A `record` in C# is a reference type designed primarily for **immutable data modeling**.  
It provides built-in functionality for:

- Value-based equality
- Concise syntax
- Immutability support
- Non-destructive mutation
- Built-in deconstruction
- Compiler-generated members

Records were introduced in **C# 9.0** and are commonly used in data transfer objects (DTOs), domain models, and functional-style programming.

---

## Why Records?

Traditional classes in C# use **reference-based equality**, meaning two objects are equal only if they reference the same memory location.

Records use **value-based equality**, meaning two instances are considered equal if their values are equal.

This makes records ideal for:

- Immutable data
- Messaging systems
- Event sourcing
- API contracts
- Pattern matching scenarios

---

## Record vs Class

| Feature | Class | Record |
|----------|--------|---------|
| Equality | Reference-based | Value-based |
| Immutability | Manual | Built-in support |
| ToString() | Manual override | Auto-generated |
| Deconstruct() | Manual | Auto-generated |
| With-expression | Not supported | Supported |
| Intended Usage | Behavior + State | Data modeling |

---

## Value-Based Equality

Records override:

- `Equals()`
- `GetHashCode()`
- `==` operator
- `!=` operator

Equality is determined by comparing all properties defined in the primary constructor.

---

## Immutability

Records are typically immutable.

Properties declared in the primary constructor are:
- `init` only
- Settable only during initialization

This ensures that once created, the object state does not change.

---

## Non-Destructive Mutation

Records support `with` expressions.

This allows creating a new copy of an object with modified values, without changing the original instance.

This pattern supports functional programming principles.

---

## Types of Records

### 1. Positional Record
Defined using a primary constructor.
Best for concise data modeling.

### 2. Nominal Record
Defined like a class with properties inside the body.

### 3. Record Struct (C# 10+)
Value-type version of a record.
Stored on stack (when possible).
Still supports value-based equality.

---

## Compiler-Generated Members

For records, the compiler automatically generates:

- `Equals()`
- `GetHashCode()`
- `ToString()`
- `Deconstruct()`
- Copy constructor
- `with` support
- Equality operators

---

## Records and Inheritance

Records support inheritance.

However:
- Equality includes runtime type.
- Derived records extend value comparison logic.
- `sealed` can be used to prevent inheritance.

---

## Records and Pattern Matching

Records work naturally with:

- Positional patterns
- Property patterns
- Switch expressions

They are optimized for pattern matching scenarios.

---

## When to Use Record

Use records when:

- Modeling pure data
- Needing immutability
- Comparing objects by value
- Building DTOs
- Working with functional programming style

---

## When NOT to Use Record

Avoid records when:

- Object identity matters
- The type represents behavior-heavy logic
- You need mutable state
- Performance-sensitive reference tracking is required

---

## Memory Behavior

Records are reference types by default (like classes).

`record struct` is a value type.

Memory allocation:
- Record → Heap
- Record struct → Stack (when applicable)

---

## Summary

A record in C# is a specialized reference type optimized for:

- Immutable data
- Value-based equality
- Functional-style programming
- Concise and expressive modeling

It reduces boilerplate code and improves clarity when representing data-centric objects.

---

## Recommended Use Cases

- API Models
- Domain Events
- Configuration Objects
- Read Models
- Message Contracts
- Immutable State Containers

---

## Version Requirements

- C# 9.0 → `record`
- C# 10.0 → `record struct`

Requires:
- .NET 5+ (for C# 9)
- .NET 6+ (for C# 10 features)

---

## Final Note

Records are not a replacement for classes.

They are a specialized tool for modeling data in a clean, safe, and expressive way.

Choose between `class`, `struct`, and `record` based on:
- Mutability requirements
- Equality semantics
- Memory behavior
- Domain modeling needs