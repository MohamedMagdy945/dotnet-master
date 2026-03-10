# Static in C#

The `static` keyword in C# defines members or types that belong to the **type itself** rather than to a specific instance of that type.

Static members are shared across all instances and can be accessed without creating an object.

---

## 1. Static Class

A static class:

- Cannot be instantiated.
- Cannot contain instance members.
- Contains only static members.
- Is implicitly sealed (cannot be inherited).
- Is typically used for utility or helper functionality.

---

## 2. Static Fields

A static field:

- Belongs to the type.
- Has only one copy in memory.
- Is shared across all instances of the type.
- Lives for the lifetime of the application domain.

All objects of the same type access the same static field.

---

## 3. Static Methods

A static method:

- Belongs to the type, not to instances.
- Can be called without creating an object.
- Cannot directly access instance members.
- Can only access other static members.

Static methods are commonly used for utility logic or operations that do not depend on object state.

---

## 4. Static Properties

A static property:

- Belongs to the type.
- Provides controlled access to static fields.
- Is shared across all instances.

Like static fields, only one copy exists.

---

## 5. Static Constructor

A static constructor:

- Initializes static members.
- Executes automatically.
- Runs only once.
- Is triggered before the first access to the type.
- Cannot have parameters or access modifiers.

It guarantees type-level initialization.

---

## 6. Static vs Instance Members

| Feature              | Static Member        | Instance Member        |
|----------------------|----------------------|------------------------|
| Belongs to           | Type                 | Object                 |
| Memory Allocation    | Single shared copy   | Per object             |
| Requires Object      | No                   | Yes                    |
| Access to Instance   | Not allowed          | Allowed                |
| Lifetime             | Application lifetime | Object lifetime        |

---

## 7. Memory Behavior

- Static members exist once per type.
- Stored in the type's metadata area managed by the CLR.
- Created when the type is loaded.
- Remain in memory until the application domain is unloaded.

Static data behaves like global state within that type.

---

## 8. Static and Thread Safety

Because static data is shared globally:

- Multiple threads may access it simultaneously.
- Mutable static data can cause race conditions.
- Synchronization mechanisms may be required.

Static state must be carefully managed in multi-threaded applications.

---

## 9. Static in Generics

Each closed generic type has its own separate static members.

Static data is not shared between different generic type arguments.

---

## 10. When to Use Static

Use static when:

- No instance-specific state is required.
- Logic is utility-based.
- Shared counters or configuration are needed.
- Behavior conceptually belongs to the type itself.

---

## 11. When NOT to Use Static

Avoid static when:

- Dependency injection is required.
- Polymorphism is needed.
- Unit testing and mocking are important.
- State should vary per object.
- Global state would increase coupling.

Static introduces tight coupling and global state, which can reduce flexibility.

---

## Summary

The `static` keyword defines members that belong to the type itself rather than instances.

Key characteristics:

- Single shared copy
- Type-level access
- Application lifetime scope
- No direct access to instance members
- Useful for global utilities and shared state

Use static carefully to maintain clean architecture and avoid global state issues.