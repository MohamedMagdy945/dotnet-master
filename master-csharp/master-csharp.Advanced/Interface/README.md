# Interface in C#

## Definition
An Interface in C# is a reference type that defines a contract.  
It specifies a set of members (methods, properties, events, indexers) that a class or struct must implement.

An interface defines *what* should be done, not *how* it is done.

---

## Purpose
Interfaces are used to:

- Define contracts between components
- Achieve abstraction
- Support multiple inheritance
- Enable loose coupling
- Improve flexibility and scalability

---

## How It Works
- Declared using the `interface` keyword.
- Contains only member declarations (no implementation by default).
- A class or struct implements an interface using `:`.
- The implementing type must provide definitions for all interface members.

---

## Key Characteristics

- Cannot contain fields
- Members are public by default
- Cannot be instantiated directly
- A class can implement multiple interfaces
- Supports abstraction and polymorphism

---

## Interface vs Class

| Interface | Class |
|------------|--------|
| Defines a contract | Defines implementation |
| No instance creation | Can be instantiated |
| No constructors | Can have constructors |
| Supports multiple inheritance | Single inheritance only |
| Focuses on behavior | Focuses on structure + behavior |

---

## Interface vs Abstract Class

- Interface defines a contract only.
- Abstract class can contain both abstract and concrete members.
- A class can inherit from only one abstract class.
- A class can implement multiple interfaces.

---

## Benefits

- Promotes loose coupling
- Improves testability
- Supports clean architecture
- Enables dependency injection
- Encourages scalable system design

---

## When to Use Interfaces

Use interfaces when:

- Multiple classes share common behavior but are not closely related.
- You want to enforce a contract across different implementations.
- You need multiple inheritance behavior.
- You are designing flexible and extensible systems.

---

## Summary
An Interface in C# defines a contract that classes or structs must follow.  
It promotes abstraction, loose coupling, and scalability, and is essential for building flexible and maintainable software systems. 