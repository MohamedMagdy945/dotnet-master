# Attributes in C#

## Overview

Attributes in C# provide a way to add declarative metadata to program elements.  
They describe information about classes, methods, properties, parameters, assemblies, and more, without changing the program logic directly.  

Attributes can be inspected at runtime using Reflection or interpreted by frameworks and the compiler.

---

# What Is an Attribute?

An Attribute is a special class that stores metadata about program elements.  
It allows developers and frameworks to define additional behavior declaratively rather than imperatively.  

Attributes do not execute code themselves; they provide information that can be used at compile-time or run-time.

---

# Importance of Attributes

Attributes are widely used in .NET for:

- ASP.NET Core routing and APIs  
- Serialization control  
- Validation frameworks  
- Dependency injection  
- Testing frameworks  
- Security and authorization  

They allow developers to separate concerns, make code cleaner, and enable declarative programming.

---

# How Attributes Work

1. Attributes are declared on code elements.  
2. During compilation, metadata is embedded into the assembly.  
3. At runtime, Reflection can inspect the metadata.  
4. Frameworks interpret the metadata and apply behavior accordingly.  

Attributes themselves do not change behavior unless interpreted by code or frameworks.

---

# Types of Attributes

## Built-in Attributes

Provided by the .NET framework to control compilation, runtime behavior, serialization, security, interoperability, and diagnostics.

## Custom Attributes

Developers can create custom attributes by inheriting from the base `Attribute` class.  
Custom attributes allow flexible and extensible architectures tailored to application-specific needs.

---

# Attribute Targets

Attributes can be applied to various program elements:

- Assembly  
- Module  
- Class  
- Struct  
- Interface  
- Enum  
- Method  
- Property  
- Field  
- Parameter  
- Return value  

Rules can be defined to restrict which targets are valid.

---

# Attribute Metadata

Attributes can contain:

- Positional parameters  
- Named parameters  
- Configuration values  

This structured metadata becomes part of the compiled assembly and can be read at runtime.

---

# Attribute Usage Rules

- Can restrict where an attribute can be applied  
- Can allow multiple uses of the same attribute  
- Can allow inheritance by derived classes  

These rules help maintain consistent and safe usage.

---

# Compile-Time vs Run-Time Influence

### Compile-Time

Some attributes influence compiler behavior:

- Suppress warnings  
- Mark obsolete APIs  
- Control code generation or serialization  

### Run-Time

Most attributes are inspected using Reflection:

- Determine behavior dynamically  
- Enable framework features like routing, validation, and authorization  
- Provide configuration information  

---

# Reflection and Attributes

Reflection is commonly used to:

- Detect the presence of an attribute  
- Read attribute configuration  
- Dynamically apply behavior  

This combination enables plugin systems, dependency injection frameworks, ORMs, and validation engines.

---

# Performance Considerations

- Attributes themselves are lightweight.  
- Reflection to read attributes at runtime can affect performance.  
- Best practices include caching reflection results and limiting unnecessary scans.

---

# Advantages

- Declarative configuration instead of imperative code  
- Clean separation of concerns  
- Extensible and reusable architecture  
- Integrates seamlessly with .NET frameworks  

---

# Limitations

- Attributes require reflection to influence runtime behavior  
- Overuse can reduce readability  
- Do not enforce behavior automatically  

---

# Summary

Attributes in C#:

- Provide metadata about code elements  
- Are embedded in assemblies at compile time  
- Can be read at runtime via Reflection  
- Enable declarative programming and framework integration  
- Do not execute logic themselves but enable other systems to do so  

---

# Mental Model
