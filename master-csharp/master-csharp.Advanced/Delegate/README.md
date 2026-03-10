# Delegate in C#

## Definition
A Delegate in C# is a type that represents a reference to a method.  
It allows methods to be assigned to variables, passed as parameters, and invoked dynamically in a type-safe manner.

A delegate acts as a contract that defines a method signature, including return type and parameters.

---

## Purpose
Delegates are used to:

- Pass methods as parameters
- Implement callback mechanisms
- Support event handling
- Enable loose coupling between components
- Allow dynamic method execution

---

## How It Works
A delegate defines a method signature.  
Any method assigned to that delegate must match:

- The same return type
- The same parameter types
- The same parameter order

Once assigned, the delegate can invoke the referenced method.

---

## Key Characteristics

- Type-safe
- Object-oriented alternative to function pointers
- Can reference static or instance methods
- Supports multicast (can reference multiple methods)
- Can be combined and removed dynamically

---

## Multicast Delegates
Delegates in C# can reference more than one method at the same time.  
When invoked, all referenced methods are executed in order.

---

## Built-in Generic Delegates

C# provides predefined delegate types:

- Action → Represents a method that does not return a value.
- Func → Represents a method that returns a value.
- Predicate → Represents a method that returns a boolean value.

---

## Delegate vs Method

- A method defines behavior.
- A delegate references behavior.
- A method performs execution.
- A delegate enables flexible invocation of methods.

---

## Delegate vs Interface

- Delegates are used to pass methods.
- Interfaces are used to define contracts for classes.
- Delegates focus on behavior passing.
- Interfaces focus on structure and capability definition.

---

## When to Use Delegates

Use delegates when:

- You need to pass functionality as a parameter.
- You design event-driven systems.
- You want dynamic behavior selection.
- You implement callback logic.

---

## Summary
A Delegate in C# is a powerful feature that enables methods to be treated as first-class objects.  
It enhances flexibility, supports event-driven programming, and promotes loosely coupled design.