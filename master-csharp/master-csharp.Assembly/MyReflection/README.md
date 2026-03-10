# Reflection in C#

## Introduction
Reflection in C# is a runtime feature that allows a program to inspect metadata, discover types, and interact with objects dynamically during execution. It enables examining assemblies, types, and their members even if they were not explicitly referenced at compile time.

Reflection is provided mainly through the `System.Reflection` namespace.

---

## What is Metadata
Metadata is information about types defined inside an assembly, including:
- Type name
- Namespace
- Base type
- Implemented interfaces
- Methods
- Properties
- Fields
- Events
- Attributes
- Access modifiers

Reflection reads and works with this metadata at runtime.

---

## Assemblies
An assembly is the compiled output of a .NET project (.dll or .exe).  
Reflection typically starts with an assembly.

Through assemblies you can:
- Load external libraries at runtime
- Enumerate available types
- Inspect referenced assemblies
- Build plugin-based systems

Assemblies contain all metadata required for reflection.

---

## The Type Class
The Type class represents metadata about:
- Class
- Struct
- Interface
- Enum
- Delegate

Using Type you can:
- Discover methods
- Discover properties
- Discover fields
- Discover constructors
- Discover events
- Check inheritance
- Detect interfaces
- Determine if the type is abstract, sealed, static
- Detect if it is generic

Type is the central object in reflection.

---

## MemberInfo
MemberInfo is the base abstraction for all type members.

Derived types include:
- MethodInfo
- PropertyInfo
- FieldInfo
- EventInfo
- ConstructorInfo

Each member contains metadata such as:
- Name
- DeclaringType
- Accessibility
- Custom attributes

---

## BindingFlags
BindingFlags control which members reflection should retrieve.

They define:
- Public or NonPublic
- Instance or Static
- DeclaredOnly or inherited
- FlattenHierarchy

Without correct BindingFlags, some members may not appear.

---

## Methods (MethodInfo)
MethodInfo provides metadata about methods.

Capabilities:
- Inspect method name
- Inspect parameters
- Inspect return type
- Detect generic methods
- Determine if virtual or abstract
- Dynamically invoke methods

Method invocation through reflection happens at runtime and is slower than direct calls.

---

## Properties (PropertyInfo)
PropertyInfo provides:
- Property name
- Property type
- Getter and setter information
- Accessibility
- Associated attributes

Properties internally wrap getter and setter methods.

---

## Fields (FieldInfo)
FieldInfo allows:
- Accessing field metadata
- Detecting readonly fields
- Detecting static fields
- Reading constant values
- Accessing private fields (with permissions)

---

## Constructors (ConstructorInfo)
ConstructorInfo allows:
- Discovering constructors
- Inspecting parameters
- Creating objects dynamically

This is widely used in Dependency Injection frameworks.

---

## Events (EventInfo)
EventInfo allows:
- Inspecting event handler type
- Accessing add/remove methods
- Discovering event metadata

Used in UI frameworks and dynamic systems.

---

## Custom Attributes
Attributes are metadata classes derived from System.Attribute.

Reflection allows:
- Checking if an attribute exists
- Reading attribute properties
- Driving behavior based on metadata

Common usage scenarios:
- Validation systems
- ORMs
- Serialization frameworks
- Authorization systems

---

## Creating Objects Dynamically
Reflection allows instantiating objects when:
- Type is only known at runtime
- Implementing plugin architectures
- Building generic frameworks
- Working with factories

---

## Invoking Members Dynamically
Reflection can:
- Invoke methods
- Get property values
- Set property values
- Modify field values

This enables flexible runtime behavior but reduces performance and type safety.

---

## Generics and Reflection
Reflection supports:
- Detecting if a type is generic
- Getting generic type definitions
- Getting generic arguments
- Constructing closed generic types at runtime

Important in:
- Generic repositories
- Advanced frameworks
- Runtime type construction

---

## Reflection Emit
System.Reflection.Emit allows:
- Generating IL at runtime
- Creating dynamic assemblies
- Building types dynamically
- Creating dynamic methods

Used in:
- Dynamic proxy libraries
- Performance-optimized frameworks
- Advanced runtime systems

---

## Performance Considerations
Reflection is slower than direct access because:
- Runtime metadata lookup
- Security checks
- Boxing and unboxing
- Late binding invocation

To improve performance:
- Cache Type instances
- Cache MethodInfo/PropertyInfo
- Avoid repeated reflection calls
- Use compiled expressions when possible

---

## Security Considerations
Reflection can:
- Access private members
- Break encapsulation
- Modify internal state

It should be used carefully in secure or enterprise systems.

---

## Advantages
- High flexibility
- Runtime adaptability
- Essential for framework development
- Enables metadata-driven programming

---

## Disadvantages
- Slower performance
- Reduced compile-time safety
- Harder debugging
- Breaks encapsulation principles
- More complex code

---

## When Not To Use Reflection
Avoid reflection when:
- Simple polymorphism is enough
- Performance is critical
- Strong compile-time safety is required
- Business logic does not require runtime type inspection

---

## Summary
Reflection in C# is a powerful runtime mechanism that allows programs to inspect and manipulate metadata and objects dynamically. It is essential for building advanced libraries, frameworks, dependency injection systems, ORMs, and plugin architectures.

However, it should be used carefully due to performance costs and maintainability concerns.