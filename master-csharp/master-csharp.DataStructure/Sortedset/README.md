# SortedSet in C#

## Overview

A **SortedSet** in C# is a collection that stores **unique elements in sorted order**.  
It is part of the `System.Collections.Generic` namespace and provides fast operations for insertion, removal, and lookup while maintaining elements in order.

Unlike `HashSet`, which is unordered, `SortedSet` automatically sorts elements using a **comparer**.

---

# Definition

A SortedSet is a **set-based collection** that:

- Does not allow duplicate elements  
- Maintains elements in ascending order by default (or custom order via comparer)  
- Provides efficient searching and enumeration  

`SortedSet<T>` is generic and type-safe.

---

# How SortedSet Works Internally

1. **Underlying Data Structure**  
   - SortedSet is implemented using a **self-balancing binary search tree (usually a Red-Black Tree)**.  
   - Each node stores a value, left and right child references, and color metadata for balancing.  

2. **Insertion**  
   - New elements are inserted based on comparison with existing nodes.  
   - Tree rotations may occur to maintain balanced height (O(log n) complexity).  

3. **Deletion**  
   - Element is located via comparison and removed.  
   - Tree may rebalance to maintain optimal structure.  

4. **Lookup / Membership Testing**  
   - Search operation follows tree traversal based on comparisons.  
   - O(log n) average and worst-case complexity.  

5. **Enumeration**  
   - Iterating through a SortedSet yields elements in **sorted order**.  
   - Traversal uses in-order tree traversal.  

---

# Characteristics of SortedSet

- Stores **unique elements** only  
- Maintains elements in **sorted order**  
- Supports efficient lookup, insertion, and removal (O(log n))  
- Can use **custom comparers** for ordering  
- Supports set operations: union, intersection, difference  

---

# Advantages

- Always sorted automatically  
- Prevents duplicates  
- Efficient for searching, insertion, and deletion  
- Useful for algorithms that require ordered sets  
- Supports set algebra operations  

---

# Considerations

- Slower than HashSet for plain lookup (O(1) in HashSet vs O(log n) in SortedSet)  
- Extra memory required for tree nodes and balancing metadata  
- Custom comparers must provide consistent ordering  

---

# Use Cases

- Maintaining sorted collections with unique elements  
- Implementing ordered lookup tables  
- Performing set algebra (union, intersection, difference) efficiently  
- Priority-related algorithms (like scheduling by value)  
- Any scenario requiring both uniqueness and sorted order  

---

# Memory and Performance

- Each element stored as a tree node  
- Self-balancing ensures O(log n) for add/remove/search  
- Enumeration in sorted order is efficient using in-order traversal  
- Garbage Collector reclaims nodes when removed  

---

# Summary

- SortedSet is a unique, sorted collection in C#  
- Internally implemented as a balanced binary search tree (Red-Black Tree)  
- Maintains sorted order automatically  
- Part of `System.Collections.Generic` namespace  
- Ideal for ordered sets, sorted data, and set operations  

---

# Mental Model
