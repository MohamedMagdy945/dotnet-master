# Garbage Collector, Managed & Unmanaged Memory in C#

## Overview

Memory management in .NET is handled automatically through the Garbage Collector (GC).  
Understanding managed and unmanaged memory is essential for writing efficient and reliable applications.

This document explains:

- Managed Memory
- Unmanaged Memory
- Garbage Collector (GC)
- Generational Collection
- Memory Lifecycle in .NET

---

# Managed Memory

## Definition

Managed memory is memory that is controlled and monitored by the Common Language Runtime (CLR).

When objects are created in C#, they are allocated inside the Managed Heap, and the CLR is responsible for tracking and cleaning them.

## Characteristics

- Automatically allocated
- Automatically released
- Stored in the Managed Heap
- Monitored by the Garbage Collector
- Safe from direct memory corruption

## Benefits

- No manual memory deallocation
- Reduced risk of memory leaks
- Protection against invalid memory access
- Automatic memory compaction

Managed memory is used for most objects created in .NET applications.

---

# Unmanaged Memory

## Definition

Unmanaged memory is memory that is NOT controlled by the Garbage Collector.

It is typically used when interacting with:

- Operating system resources
- File handles
- Network sockets
- Database connections
- Native libraries
- Interoperability scenarios (P/Invoke)

## Characteristics

- Not tracked by the GC
- Must be released manually
- Can cause memory leaks if not properly handled
- Often wrapped using managed abstractions

Unmanaged resources require explicit cleanup through proper design patterns.

---

# Garbage Collector (GC)

## Definition

The Garbage Collector is the automatic memory management system inside the CLR.

Its responsibility is to reclaim memory occupied by objects that are no longer reachable by the application.

GC prevents:

- Memory leaks (in managed memory)
- Fragmentation (through compaction)
- Manual memory management errors

---

# How Garbage Collection Works

The GC follows a process based on reachability analysis.

## Root References

The GC starts from root references such as:

- Static fields
- Active method parameters
- Local variables
- CPU registers

Any object reachable from these roots is considered alive.

Objects not reachable are considered eligible for collection.

---

# Collection Phases

## Mark Phase

The GC identifies all reachable (alive) objects.

## Sweep Phase

Unreachable objects are removed and their memory is reclaimed.

## Compaction Phase

Remaining objects are reorganized to reduce memory fragmentation and improve allocation efficiency.

---

# Generational Garbage Collection

.NET uses a generational model based on the observation that most objects are short-lived.

There are three generations:

## Generation 0

- Newly allocated objects
- Short-lived objects
- Collected frequently

## Generation 1

- Objects that survived one collection
- Medium-lived objects

## Generation 2

- Long-lived objects
- Collected less frequently
- Larger and more stable objects

This model improves performance by focusing collection efforts where they are most effective.

---

# Large Object Heap (LOH)

Objects exceeding a certain size threshold are stored in a separate area called the Large Object Heap.

Characteristics:

- Designed for large allocations
- Collected less frequently
- Can impact performance if overused

---

# Managed vs Unmanaged Memory

| Feature | Managed Memory | Unmanaged Memory |
|----------|----------------|-----------------|
| Controlled by | CLR | Developer / OS |
| Cleaned by | Garbage Collector | Manual cleanup |
| Safety | High | Risk of leaks |
| Typical usage | Application objects | System resources |

---

# Memory Lifecycle in .NET

1. Object is allocated in the Managed Heap.
2. Application uses the object.
3. If the object becomes unreachable, it becomes eligible for collection.
4. GC reclaims memory during a collection cycle.
5. Memory is reused for future allocations.

Unmanaged resources must be released explicitly to avoid resource leaks.

---

# Key Concepts

- GC manages managed memory only.
- Unmanaged resources require explicit release.
- Generational collection improves performance.
- Reachability determines object lifetime.
- Memory compaction reduces fragmentation.

---

# Conclusion

The .NET memory model provides automatic and optimized memory management through the Garbage Collector.

Managed memory ensures safety and simplicity.  
Unmanaged memory provides low-level control but requires careful handling.

A clear understanding of both is essential for building scalable and high-performance applications.