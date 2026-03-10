# HashSet in C#

## Overview

A `HashSet` in C# is a collection that stores **unique elements** with no particular order.  
It is part of the `System.Collections.Generic` namespace and provides fast lookup, insertion, and deletion operations.

HashSet is optimized for scenarios where uniqueness and membership testing are more important than order.

---

# Definition

A HashSet is a **set-based collection** that:

- Does not allow duplicate elements  
- Provides efficient methods for checking element existence  
- Uses hashing internally to organize elements  

HashSet is generic (`HashSet<T>`) and ensures type safety.

---

# How HashSet Works Internally

1. **Hashing**  
   - Each element is passed through a **hash function** to compute a hash code.  
   - The hash code determines the **bucket** where the element is stored internally.  

2. **Buckets and Slots**  
   - HashSet maintains an array of buckets.  
   - Each bucket contains slots for elements with the same hash code (to handle collisions).  

3. **Adding Elements**  
   - Compute the hash code of the element.  
   - Check the corresponding bucket for duplicates.  
   - If not present, insert the element into the bucket.  

4. **Checking Membership**  
   - Compute the hash code of the element.  
   - Look in the corresponding bucket.  
   - Compare elements using equality check (`Equals`) to confirm presence.  

5. **Removing Elements**  
   - Compute the hash code to locate the bucket.  
   - Remove the element from the bucket if it exists.  

6. **Handling Collisions**  
   - Multiple elements with the same hash code are stored in the same bucket.  
   - Equality checks (`Equals`) are used to differentiate them.  

7. **Resizing**  
   - When the load factor (number of elements relative to bucket count) exceeds a threshold, the internal array of buckets is resized.  
   - All elements are rehashed to new buckets.

---

# Characteristics of HashSet

- Stores **unique elements only**  
- Unordered collection  
- Optimized for **fast membership checks**  
- Uses hashing for storage and retrieval  
- Generic type-safe collection  

---

# Advantages

- O(1) average time complexity for add, remove, and contains operations  
- Automatically prevents duplicates  
- Efficient for lookup-heavy scenarios  
- Can perform set operations: union, intersection, difference  

---

# Considerations

- No guaranteed order of elements  
- Performance depends on quality of hash function  
- Slight memory overhead due to internal buckets  
- Equality (`Equals`) and hash code (`GetHashCode`) implementations are crucial for correctness  

---

# Use Cases

- Removing duplicates from a collection  
- Fast membership testing  
- Implementing sets in algorithms (union, intersection, difference)  
- Lookup-heavy applications  

---

# Memory and Performance

- Each element stored in a bucket based on its hash code  
- Collision resolution handled internally (usually chaining)  
- Efficient even for large datasets if hash codes are well distributed  
- Garbage Collector reclaims memory when HashSet is no longer referenced  

---

# Summary

- HashSet is an unordered, unique collection in C#  
- Internally uses hashing to store and retrieve elements efficiently  
- Supports fast insertion, deletion, and membership testing  
- Part of `System.Collections.Generic` namespace  
- Ideal for scenarios where uniqueness and quick lookup are required  

---

# Mental Model
