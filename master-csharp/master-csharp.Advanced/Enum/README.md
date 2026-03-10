# Enum in C#

## Definition
An Enum (Enumeration) in C# is a distinct value type that consists of a set of named constants.  
It provides a way to define and group related values under a single type, improving code readability and maintainability.

---

## Purpose
Enums are used to:

- Represent a fixed set of related values
- Make code more readable by using meaningful names instead of numeric values
- Reduce the chance of invalid values
- Improve maintainability and clarity

---

## How It Works
- Declared using the `enum` keyword.
- Each member has an underlying integral value (default is `int`).
- Can explicitly assign values to members.
- Can be used in variables, method parameters, and switch statements.

---

## Key Characteristics

- Value type derived from `System.Enum`
- Members are named constants
- Default underlying type is `int` (can specify byte, short, long, etc.)
- Supports comparisons and bitwise operations (with flags)
- Improves type safety

---

## Enum vs Constants

- Constants are separate and not grouped
- Enums group related values under one type
- Enums provide type safety
- Enums improve code readability

---

## Enum with Flags

- The `[Flags]` attribute allows an enum to be treated as a bit field.
- Members can be combined using bitwise operators (`|`, `&`).
- Useful for representing multiple options or settings simultaneously.

### Key Points for Flags Enums
- Each value should be a power of two (`1, 2, 4, 8…`) to allow combination.
- Use bitwise operations to combine, check, or remove flags.
- Improves flexibility for representing multiple choices in one variable.

---

## Benefits

- Clearer and more meaningful code
- Reduces magic numbers
- Improves maintainability
- Can represent multiple states simultaneously with Flags

---

## When to Use Enums

Use enums when:

- You have a fixed set of related values
- You want to improve code readability
- You want type-safe alternatives to numeric constants
- You need a clear way to represent states, options, or categories
- You want to combine multiple options with `[Flags]`

---

## Summary
An Enum in C# is a value type that defines a group of named constants.  
Using `[Flags]` allows combining multiple enum values for flexible and readable representation of multiple options or states.  
Enums enhance readability, maintainability, and type safety in your code.