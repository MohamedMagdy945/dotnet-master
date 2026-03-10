# Stack in C#

## Overview

A **Stack** is a linear data structure that follows the **Last-In-First-Out (LIFO)** principle.  
This means the last element added to the stack is the first one to be removed.  

Stacks are part of the `System.Collections.Generic` namespace in C# (`Stack<T>`) and are widely used in programming for temporary storage and function call management.

---

# Definition

A Stack is a collection of elements that supports two main operations:

- **Push**: Add an element to the top of the stack  
- **Pop**: Remove the element from the top of the stack  

Additional operations:

- **Peek**: View the element at the top without removing it  
- **Contains**: Check if an element exists in the stack  
- **Count**: Number of elements in the stack  

---

# How Stack Works Internally

1. **Underlying Storage**  
   - Stack uses a **dynamic array** internally (or linked nodes in custom implementations).  
   - The array has a capacity that grows automatically as elements are added.  

2. **Push Operation**  
   - Adds the element to the position after the current top.  
   - If the backing array is full, a new larger array is allocated, and existing elements are copied.  

3. **Pop Operation**  
   - Removes the element at the current top of the stack.  
   - Decreases the top pointer/index.  
   - Memory is eventually reclaimed by the Garbage Collector (GC).  

4. **Peek Operation**  
   - Returns the element at the top without removing it.  

5. **Dynamic Resizing**  
   - When capacity is exceeded, the internal array doubles in size.  
   - Elements are copied to the new array automatically.  

---

# Characteristics of Stack

- LIFO ordering  
- Dynamic size (can grow automatically)  
- Provides O(1) time complexity for push and pop operations  
- Supports indexed access indirectly via Pop/Peek  
- Can be implemented using arrays or linked nodes  

---

# Advantages

- Very fast insertion and removal at the top  
- Simple and intuitive structure for temporary storage  
- Efficient memory usage for localized operations  
- Useful in recursive algorithms, undo mechanisms, and expression evaluation  

---

# Considerations

- Access to elements other than the top is not direct  
- Dynamic resizing may incur occasional memory copying  
- Not suitable for random access scenarios  

---

# Use Cases

- Function call stack management (recursion)  
- Undo/Redo operations in applications  
- Parsing expressions (e.g., infix, postfix, prefix)  
- Backtracking algorithms (e.g., maze solving, puzzles)  
- Temporary storage in algorithms  

---

# Memory and Performance

- Stack stores elements in a contiguous memory array internally  
- Push and Pop are generally O(1) operations  
- Dynamic resizing may temporarily impact performance  
- Garbage Collector reclaims memory for removed elements automatically  

---

# Summary

- Stack is a linear LIFO data structure in C#  
- Supports Push, Pop, Peek, Contains, and Count operations  
- Internally uses a dynamic array with automatic resizing  
- Part of `System.Collections.Generic` namespace  
- Ideal for temporary storage, recursion, and backtracking  

---

# Mental Model
