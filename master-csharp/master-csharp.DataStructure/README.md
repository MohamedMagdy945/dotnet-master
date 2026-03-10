# Data Structures in C#

## Overview

Data structures are a fundamental concept in computer science and software development.  
In C#, data structures provide organized ways to store, manage, and access data efficiently.  

Understanding data structures is essential for algorithm design, memory optimization, and high-performance applications.

---

# What Is a Data Structure?

A data structure is a specialized format for organizing, storing, and managing data in memory or storage.  
It defines:

- How data is stored  
- How data is accessed  
- How data is modified  
- The relationships between data elements  

Choosing the right data structure affects performance, memory usage, and scalability.

---

# Types of Data Structures in C#

Data structures in C# can be classified into two major categories:

## 1. Linear Data Structures

Elements are arranged sequentially.  
Each element has a unique predecessor and successor (except the first and last).

Examples include:

- Arrays  
- Lists  
- Linked Lists  
- Stacks  
- Queues  

Linear structures are easy to implement and traverse but may have limitations in dynamic resizing or insertion.

---

## 2. Non-Linear Data Structures

Elements are not arranged sequentially.  
They may have hierarchical or networked relationships.

Examples include:

- Trees  
- Graphs  
- Heaps  

Non-linear structures are used for complex relationships, searching, and optimization problems.

---

# Common Data Structures in C#

## Arrays

- Fixed-size collection  
- Contiguous memory allocation  
- Efficient index-based access  
- Limited dynamic operations  

## Lists

- Dynamic-sized collection  
- Provides insertion, deletion, and traversal  
- Backed by arrays or linked lists internally  

## Linked Lists

- Sequence of nodes containing data and reference to next node  
- Supports dynamic insertion and deletion  
- Can be singly, doubly, or circularly linked  

## Stack

- LIFO (Last-In-First-Out) structure  
- Operations: push, pop, peek  
- Useful for undo operations, recursion management, and parsing  

## Queue

- FIFO (First-In-First-Out) structure  
- Operations: enqueue, dequeue, peek  
- Used in scheduling, messaging, and buffering  

## Hash-Based Structures

- HashSet, Dictionary  
- Use key-value pairs for fast lookup  
- Efficient for searching, insertion, and deletion  

## Trees

- Hierarchical structure with root, nodes, and leaves  
- Binary Trees, Binary Search Trees, AVL Trees, Heaps  
- Used for searching, sorting, and hierarchical data representation  

## Graphs

- Collection of nodes connected by edges  
- Represent relationships or networks  
- Can be directed, undirected, weighted, or unweighted  

---

# Choosing a Data Structure

Factors to consider:

- Type of operations (search, insert, delete, update)  
- Frequency of operations  
- Memory constraints  
- Performance requirements  
- Complexity of implementation  

---

# Memory Considerations

- Linear structures may use contiguous memory (arrays)  
- Linked structures use pointers or references  
- Hash structures require extra memory for hash tables  
- Non-linear structures may consume additional memory for hierarchy and references  

Efficient memory management is critical in high-performance and large-scale applications.

---

# Importance in C#

Data structures in C# are essential for:

- Algorithm implementation  
- System performance optimization  
- Resource management  
- Solving complex computational problems  
- Building robust and scalable applications  

C# provides built-in support through collections, generics, and specialized data structures.

---

# Summary

- Data structures organize and manage data efficiently.  
- Linear structures include arrays, lists, stacks, and queues.  
- Non-linear structures include trees, graphs, and heaps.  
- Choosing the right structure impacts performance and memory usage.  
- C# offers rich support for implementing and managing data structures effectively.  

---

# Mental Model
