# Queue in C#

## Overview

A **Queue** is a linear data structure that follows the **First-In-First-Out (FIFO)** principle.  
This means the first element added to the queue is the first one to be removed.  

Queues are part of the `System.Collections.Generic` namespace in C# (`Queue<T>`) and are widely used in scenarios requiring ordered processing.

---

# Definition

A Queue is a collection of elements that supports two main operations:

- **Enqueue**: Add an element to the end of the queue  
- **Dequeue**: Remove the element from the front of the queue  

Additional operations:

- **Peek**: View the element at the front without removing it  
- **Contains**: Check if an element exists in the queue  
- **Count**: Number of elements in the queue  

---

# How Queue Works Internally

1. **Underlying Storage**  
   - Queue uses a **circular array** internally.  
   - The array has a fixed capacity that grows dynamically as needed.  

2. **Enqueue Operation**  
   - Adds the element to the next available position at the end (tail) of the array.  
   - If the array is full, a new larger array is allocated and elements are copied.  

3. **Dequeue Operation**  
   - Removes the element at the front (head) of the queue.  
   - The head pointer moves to the next element.  
   - The removed element memory is eventually reclaimed by the Garbage Collector (GC).  

4. **Peek Operation**  
   - Returns the element at the head without removing it.  

5. **Circular Array**  
   - When the tail reaches the end of the array, it wraps around to the beginning if there is available space.  
   - This avoids unnecessary array shifts and improves efficiency.  

6. **Dynamic Resizing**  
   - When the number of elements exceeds capacity, a new larger array is created and existing elements are copied in order.  

---

# Characteristics of Queue

- FIFO ordering  
- Dynamic size (can grow automatically)  
- Provides O(1) time complexity for enqueue and dequeue operations  
- Supports sequential access from front to back  
- Can be implemented using arrays or linked nodes  

---

# Advantages

- Efficient for processing data in order  
- Simple and intuitive for task scheduling and buffering  
- Supports bulk processing scenarios  
- Memory-efficient when using circular array  

---

# Considerations

- Access to elements other than the front is not direct  
- Dynamic resizing may temporarily impact performance  
- Not suitable for random access operations  

---

# Use Cases

- Task scheduling (print jobs, process queues)  
- Messaging systems (FIFO message handling)  
- Breadth-First Search (BFS) algorithms in graphs  
- Producer-Consumer problems  
- Buffers for streaming data  

---

# Memory and Performance

- Queue stores elements in a contiguous memory circular array internally  
- Enqueue and Dequeue are generally O(1) operations  
- Dynamic resizing may temporarily impact performance  
- Garbage Collector reclaims memory for removed elements automatically  

---

# Summary

- Queue is a linear FIFO data structure in C#  
- Supports Enqueue, Dequeue, Peek, Contains, and Count operations  
- Internally uses a circular array with automatic resizing  
- Part of `System.Collections.Generic` namespace  
- Ideal for ordered processing and task scheduling  

---

# Mental Model
