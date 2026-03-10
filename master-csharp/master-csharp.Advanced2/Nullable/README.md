# Nullable and Non-Nullable Types in C#

C# has two main type categories:

1. **Reference Types** - e.g., `string`, `class`, `object`
2. **Value Types** - e.g., `int`, `bool`, `struct`

C# 8.0 introduced **nullable reference types (NRT)** to reduce `null`-related runtime errors. Value types have supported nullability since C# 2.0 with `Nullable<T>`.

---

## 1. Reference Types

Reference types can **point to objects** or **be null**.

### Non-Nullable Reference Type
- Cannot hold `null`
- Compiler warns if assigned `null` or left uninitialized (when NRT enabled)
- Default state when nullable context is enabled

### Nullable Reference Type
- Can hold `null`
- Marked with `?` after the type
- Compiler performs static analysis to prevent null reference exceptions

---

## 2. Value Types

Value types directly contain their data and **cannot be null by default**.

### Non-Nullable Value Type
- Always has a value
- Cannot be null
- Default is `default(T)` (e.g., `0` for `int`, `false` for `bool`)

### Nullable Value Type
- Can hold value or `null`
- Represented by `Nullable<T>` or `T?` syntax
- Introduced in C# 2.0
- Has `HasValue` and `Value` properties

---

## Key Differences

| Feature | Reference Types | Value Types |
|---------|----------------|-------------|
| **Non-nullable syntax** | `string` | `int` |
| **Nullable syntax** | `string?` | `int?` |
| **Default value** | `null` (with warnings) | `default(T)` |
| **Memory location** | Heap | Stack |
| **When introduced** | C# 8.0 (NRT) | C# 2.0 |
| **Underlying type** | `System.Object` | `System.ValueType` |

---

## Nullable Contexts

You can control nullable behavior at different levels:

### Project Level
```xml
<PropertyGroup>
  <Nullable>enable</Nullable>
</PropertyGroup>
```

### Directive Level
```csharp
#nullable enable
#nullable disable
#nullable restore
```

### Context States
- **enable**: All nullable features enabled
- **disable**: Legacy behavior (no warnings)
- **warnings**: Show warnings but allow nullable annotations
- **annotations**: Allow annotations but no warnings

---

## Null-Handling Operators

### Null-Conditional Operator (`?.`)
Safely access members without explicit null check

### Null-Coalescing Operator (`??`)
Provides default value when expression is null

### Null-Coalescing Assignment (`??=`)
Assigns value only if left operand is null

### Null-Forgiving Operator (`!`)
Suppresses null warnings when you know value isn't null

---

## Compiler Analysis

The compiler performs static flow analysis to track null state:

- **NotNull state**: Variable is known not to be null
- **MaybeNull state**: Variable might be null
- **Warnings**: Generated when dereferencing MaybeNull variables

---

## Common Patterns

### Constructor Initialization
Non-nullable reference types must be initialized in constructors

### Method Parameters
Can specify nullability for both parameters and return types

### Properties
Can mix nullable and non-nullable properties in same class

### Generics
Nullable annotations work with generic types

---

## Best Practices

1. **Enable nullable context** in all new projects
2. **Use non-nullable types** as the default choice
3. **Use nullable types** only when `null` is semantically valid
4. **Always check nullable values** before dereferencing
5. **Avoid the null-forgiving operator** unless absolutely necessary
6. **Initialize non-nullable properties** in constructors
7. **Use null-handling operators** for cleaner code

---

## Design Guidelines

### When to Use Non-Nullable
- Required parameters
- Mandatory properties
- Values that always exist
- Return values that always succeed

### When to Use Nullable
- Optional parameters
- Optional properties
- Values that may not exist
- Return values that may fail (e.g., Try-pattern)
- Database columns allowing NULL

---

## Summary

- **Non-nullable types** provide compile-time safety against null reference exceptions
- **Nullable types** explicitly express that null is allowed
- The `?` suffix makes any type nullable
- Enable nullable contexts to get full compiler protection
- Use null-handling operators for safe and concise code
- Design APIs with clear nullability intent

---

## Additional Resources

- [Microsoft Docs: Nullable reference types](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references)
- [Microsoft Docs: Nullable value types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types)
- [C# Language Design: Nullable reference types specification](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-8.0/nullable-reference-types.md)
```