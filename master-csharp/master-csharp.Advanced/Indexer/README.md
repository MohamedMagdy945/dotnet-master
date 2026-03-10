# Indexer in C#

## Definition
An Indexer in C# is a special member of a class that allows an object to be accessed like an array using square brackets `[]`. It provides a way to use indexing syntax with custom classes.

## Purpose
The main purpose of an indexer is to make a class behave like a collection. It simplifies data access and improves code readability when working with grouped or sequential data.

## How It Works
An indexer is defined using the `this` keyword followed by parameters inside square brackets. It contains accessor blocks (`get` and optionally `set`) that define how data is retrieved and assigned.

When an object is accessed using square brackets, the indexer automatically calls the corresponding `get` or `set` accessor.

## Key Characteristics
- Uses the `this` keyword.
- Must have at least one parameter.
- Can include `get` and/or `set` accessors.
- Can be overloaded with different parameter types.
- Does not have a name (always uses `this`).
- Makes the object behave similarly to an array.

## Benefits
- Cleaner and more intuitive syntax.
- Encapsulates internal data structure.
- Provides controlled access to class data.
- Useful when building custom data structures.

## Indexer vs Method
A method requires a function call syntax using parentheses, while an indexer uses array-like square bracket syntax.  
An indexer improves readability when accessing elements by index or key.

## When to Use Indexer
Use an indexer when:
- Your class represents a collection of elements.
- You want array-like access to internal data.
- You are designing data structures such as lists, stacks, queues, or dictionaries.

## Summary
An Indexer in C# is a powerful feature that allows objects to be indexed like arrays. It enhances readability, supports encapsulation, and is commonly used in collection-based class designs.