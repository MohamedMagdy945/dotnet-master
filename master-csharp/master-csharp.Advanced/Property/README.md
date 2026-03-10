# Property in C#

## Definition
A Property in C# is a class member that provides a flexible mechanism to read, write, or compute the value of a private field. It is used to control access to data while maintaining encapsulation.

## Purpose
The main purpose of a property is to protect internal data and control how it is accessed or modified. Instead of exposing fields directly, properties allow validation, logic, or restrictions when getting or setting values.

## How It Works
A property contains accessors:
- `get` → returns the value.
- `set` → assigns a value.

When a property is accessed, the appropriate accessor is automatically executed.

## Key Characteristics
- Provides controlled access to fields.
- Supports encapsulation.
- Can be read-only, write-only, or read-write.
- Can include validation logic.
- Looks like a variable when used, but behaves like a method internally.

## Types of Properties

### 1. Read-Write Property
Allows both reading and modifying the value.

### 2. Read-Only Property
Contains only a `get` accessor. The value can be read but not modified externally.

### 3. Write-Only Property
Contains only a `set` accessor. The value can be assigned but not read externally.

### 4. Auto-Implemented Property
Allows defining a property without explicitly declaring a backing field. The compiler automatically creates it.

### 5. Computed Property
Returns a calculated value instead of storing data directly.

## Property vs Field
- A field directly stores data.
- A property controls access to that data.
- A field exposes internal structure.
- A property maintains encapsulation and flexibility.

## Benefits
- Data protection.
- Ability to add validation.
- Better maintainability.
- Allows internal implementation changes without affecting external code.

## When to Use Property
Use a property when:
- You need controlled access to class data.
- You want to validate input before assigning values.
- You want to expose data safely from a class.

## Summary
A Property in C# is a safe and structured way to access class data. It improves encapsulation, allows validation, and provides flexibility in managing internal state.