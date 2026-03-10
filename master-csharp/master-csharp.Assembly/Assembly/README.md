# Assembly in C#

## What is an Assembly?

An **Assembly** in C# is the smallest unit of deployment, versioning, and security in the .NET platform.  
It is a compiled output of a .NET project and contains Intermediate Language (IL) code, metadata, and a manifest.

Assemblies are produced after compiling source code using the .NET compiler.

---

## Assembly Structure

An assembly consists of:

- **Manifest**
  - Assembly name
  - Version
  - Culture
  - Public key (if signed)
  - Referenced assemblies
- **Metadata**
  - Type definitions
  - Members
  - Attributes
- **IL Code (Intermediate Language)**
- **Resources** (optional)

---

## Types of Assemblies

### 1. Private Assembly
- Used by a single application
- Stored inside the application directory

### 2. Shared Assembly
- Used by multiple applications
- Stored in the Global Assembly Cache (GAC)
- Must be strongly named

### 3. Satellite Assembly
- Contains localized resources
- Used for globalization and localization

---

## Assembly Files

Common output file types:

- `.dll` → Class Library
- `.exe` → Executable Application

---

## Assembly Manifest

The manifest contains:

- Assembly identity
- Version information
- File list
- Referenced assemblies
- Security permissions

It enables:

- Version control
- Dependency resolution
- Side-by-side execution

---

## Strong Name

A strong-named assembly includes:

- Assembly name
- Version number
- Culture
- Public key token
- Digital signature

Purpose:

- Ensure uniqueness
- Prevent naming conflicts
- Enable GAC deployment

---

## Global Assembly Cache (GAC)

- Central storage for shared assemblies
- Requires strong name
- Allows multiple versions of the same assembly
- Supports side-by-side execution

---

## Assembly Versioning

An assembly version consists of four numbers:

Major.Minor.Build.Revision

Used for:

- Compatibility control
- Update tracking
- Dependency management

---

## Assembly Loading

Assemblies can be loaded:

- At compile time (static reference)
- At runtime (dynamic loading)

The CLR is responsible for:

- Locating the assembly
- Verifying version
- Loading into memory
- Managing dependencies

---

## Assembly Metadata

Metadata describes:

- Types
- Methods
- Properties
- Events
- Attributes
- References

It enables:

- Reflection
- Type safety
- Language interoperability

---

## Reflection and Assembly

Reflection allows:

- Inspecting assembly metadata
- Discovering types at runtime
- Accessing members dynamically

---

## Security in Assemblies

Assemblies support:

- Strong naming
- Role-based security
- Code access security (legacy)

---

## Deployment

Assemblies can be deployed:

- Private deployment (copying files)
- Shared deployment (GAC)
- Self-contained deployment

---

## Summary

An Assembly in C# is:

- The compiled output of a .NET project
- The unit of deployment and versioning
- A container of IL, metadata, and manifest
- Managed and loaded by the CLR
- Essential for dependency management and runtime execution