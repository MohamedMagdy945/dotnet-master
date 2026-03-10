# C# Compilation & Execution Guide

## Overview

This document explains how C# code is compiled and executed inside the .NET environment.

Topics covered:

- Compile Time
- Run Time
- CLR (Common Language Runtime)
- JIT Compiler
- DLL (Dynamic Link Library)
- EXE (Executable File)
- Full Execution Flow

---

# Compile Time

## Definition

Compile Time is the phase where C# source code is converted into Intermediate Language (IL).

This process is performed by the C# Compiler (Roslyn).

## What Happens During Compile Time?

- Syntax validation
- Type checking
- Reference resolution
- Metadata generation
- IL (Intermediate Language) generation
- Assembly creation (DLL or EXE)

If any compile-time error occurs, the build fails and no output file is generated.

## Examples of Compile-Time Errors

- Missing semicolon
- Undeclared variable
- Invalid type conversion
- Method not found

---

# Run Time

## Definition

Run Time is the phase when the compiled program is executed.

At this stage, the .NET runtime environment takes control.

## What Happens During Run Time?

1. The Assembly is loaded.
2. CLR starts execution.
3. JIT Compiler converts IL into Machine Code.
4. The program executes on the CPU.

## Examples of Run-Time Errors

- NullReferenceException
- DivideByZeroException
- IndexOutOfRangeException
- InvalidOperationException

These errors occur during execution, not compilation.

---

# CLR (Common Language Runtime)

CLR is the execution engine of .NET.

It is responsible for:

- Memory Management (Garbage Collection)
- Exception Handling
- Security
- Thread Management
- JIT Compilation

CLR ensures managed execution of .NET applications.

---

# JIT (Just-In-Time Compiler)

JIT is part of the CLR.

It converts IL (Intermediate Language) into native Machine Code at run time.

This allows .NET applications to be platform independent at compile time.

Flow:

IL → JIT → Machine Code → CPU Execution

---

# Assembly

An Assembly is the output produced after compilation.

An assembly contains:

- IL Code
- Metadata
- Manifest
- References

Assemblies are distributed as:

- DLL
- EXE

---

# DLL (Dynamic Link Library)

## Definition

A DLL is a compiled library that contains reusable code.

It cannot run independently.

## Common Use Cases

- Class Libraries
- Shared Services
- Plugins
- Business Logic Layers

## Characteristics

- Reusable
- Not directly executable
- Referenced by other projects

---

# EXE (Executable File)

## Definition

An EXE is a runnable application file.

It acts as the entry point of the application.

## Modern .NET Behavior

In modern .NET (Core / 5+):

- The EXE often acts as a host.
- The main application logic is inside a DLL.
- The EXE loads the runtime and starts execution.

Execution Model:

EXE → CLR → DLL → IL → JIT → Machine Code

---

# Full Execution Flow

C# Source Code  
↓  
Compile Time (C# Compiler)  
↓  
Intermediate Language (IL)  
↓  
Assembly (DLL / EXE)  
↓  
Run Time (CLR)  
↓  
JIT Compilation  
↓  
Machine Code  
↓  
Program Execution  

---

# Compile Time vs Run Time

| Feature | Compile Time | Run Time |
|----------|--------------|----------|
| When it occurs | Before execution | During execution |
| Responsible component | C# Compiler | CLR |
| Output | Assembly (DLL / EXE) | Machine Code |
| Error Type | Syntax & Type Errors | Exceptions |

---

# Key Takeaways

- C# does NOT compile directly to machine code.
- It first compiles to Intermediate Language (IL).
- CLR manages execution.
- JIT converts IL to native code at runtime.
- DLL is reusable but not directly executable.
- EXE is the application entry point.

---

# Final Mental Model

C# → IL → CLR → JIT → Machine Code → Execution

This architecture makes .NET:

- Managed
- Secure
- Cross-platform
- Efficient