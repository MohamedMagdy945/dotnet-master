# LinkedList in C#

## Overview

A LinkedList is a dynamic data structure in C# where elements (nodes) are connected through references (pointers).  
Unlike arrays or Lists, LinkedLists do not store elements in contiguous memory, which allows efficient insertions and deletions at any position.

LinkedLists are part of the `System.Collections.Generic` namespace and support type-safe operations using generics.

---

# Definition

A LinkedList is composed of **nodes**, where each node contains:

- **Data**: the value stored in the node  
- **Reference/Pointer(s)**: links to the next node (and optionally the previous node in doubly linked lists)  

LinkedLists allow sequential traversal from head to tail (or bidirectional in doubly linked lists).

---

# Types of LinkedLists

1. **Singly Linked List**  
   - Each node points to the next node only  
   - Traversal is forward only  

2. **Doubly Linked List**  
   - Each node has pointers to both previous and next nodes  
   - Allows forward and backward traversal  

3. **Circular Linked List**  
   - Last node points back to the first node  
   - Can be singly or doubly linked  

C# `LinkedList<T>` is a **doubly linked circular list** internally.

---

# How a LinkedList Works Internally

1. **Node Structure**  
   - Each node stores the element value and references to its neighbor nodes.  

2. **Head and Tail**  
   - The list maintains references to the first node (head) and last node (tail).  

3. **Insertion**  
   - Adding a node involves creating a new node and updating the next/previous references of neighboring nodes.  
   - No shifting of elements is required (unlike arrays).  

4. **Deletion**  
   - Removing a node updates the references of the adjacent nodes.  
   - Node memory becomes unreachable and is reclaimed by the Garbage Collector (GC).  

5. **Traversal**  
   - Start from the head and follow the `Next` references to visit nodes sequentially.  
   - In a doubly linked list, traversal can go backward using `Previous` references.  

6. **Dynamic Growth**  
   - Nodes are allocated individually in memory, so the list can grow without resizing a contiguous array.  

---

# Characteristics of LinkedList

- Dynamic sizing: grows as nodes are added  
- Efficient insertion and deletion anywhere in the list  
- Sequential access (O(n) for index-based access)  
- Supports bidirectional traversal in doubly linked lists  
- Does not require contiguous memory  

---

# Advantages of LinkedList

- Fast insertion and deletion at any position  
- No array resizing or memory copying required  
- Efficient for implementing queues, stacks, and other dynamic structures  

---

# Considerations

- Access by index is slower (O(n)) compared to arrays or Lists  
- More memory overhead due to storing pointers/references  
- Traversal requires following links sequentially  

---

# Use Cases

- Dynamic data storage where frequent insertions/deletions occur  
- Implementation of stacks, queues, deques  
- Real-time applications requiring predictable insert/delete performance  
- Maintaining ordered data without fixed-size arrays  

---

# Memory and Performance

- Each node is allocated separately on the managed heap  
- References to neighbor nodes allow efficient insertions and deletions  
- Garbage Collector handles memory reclamation when nodes are removed  
- Less cache-friendly than arrays due to non-contiguous storage  

---

# Summary

- LinkedList is a dynamic, sequential data structure in C#  
- Consists of nodes with data and references  
- Supports efficient insertions and deletions  
- Part of `System.Collections.Generic` namespace  
- Sequential access is O(n), insertion/deletion is O(1) if the node reference is known  

---

# Mental Model
