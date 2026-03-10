# File Input/Output (I/O) in C#

## Overview

File Input/Output (I/O) in C# allows programs to **read from and write to files** stored on disk.  
It is part of the `System.IO` namespace and supports both **text** and **binary** file operations.  

File I/O is essential for data persistence, logging, configuration, and communication with external systems.

---

# File I/O Concepts

1. **Streams**  
   - The core abstraction in C# for reading and writing data.  
   - A stream represents a sequence of bytes flowing from a source (input) or to a destination (output).  

2. **File Types**  
   - **Text Files**: store human-readable characters.  
   - **Binary Files**: store raw bytes, such as images or compiled data.  

3. **Encoding**  
   - For text files, character encoding (UTF-8, ASCII, Unicode) determines how characters are represented as bytes.  

4. **Buffered I/O**  
   - Data is temporarily stored in memory buffers for efficient reading and writing.  
   - Reduces direct disk access, improving performance.  

---

# How File I/O Works Internally

1. **File Streams**  
   - A `FileStream` object opens a connection to a file and provides read/write methods.  
   - Streams can be **synchronous** or **asynchronous**.  

2. **Reading Files**  
   - The OS reads bytes from the storage device into a memory buffer.  
   - The program can read sequentially (stream) or seek specific positions.  
   - Text readers convert bytes to characters using encoding.  

3. **Writing Files**  
   - The program writes bytes into a memory buffer.  
   - Buffered data is periodically flushed to disk.  
   - File locks may be used to prevent concurrent write conflicts.  

4. **File Modes and Access**  
   - **FileMode**: Create, Open, OpenOrCreate, Append, etc.  
   - **FileAccess**: Read, Write, ReadWrite  
   - **FileShare**: Allows multiple processes to read/write simultaneously or exclusively  

5. **Error Handling**  
   - File operations can fail due to missing files, permissions, or locks.  
   - Exception handling (`IOException`, `UnauthorizedAccessException`) is required.  

6. **Closing and Disposing**  
   - Streams must be closed or disposed to release system resources.  
   - `using` statements ensure deterministic disposal of resources.  

---

# Characteristics of File I/O

- Persistent storage: data survives program termination  
- Supports sequential and random access  
- Text or binary formats  
- Buffering improves performance  
- Requires proper resource management  

---

# Advantages

- Enables data persistence  
- Supports large datasets beyond memory limits  
- Standardized access using .NET streams and file APIs  
- Flexible: works with local files, network paths, and memory streams  

---

# Considerations

- Disk I/O is slower than memory operations  
- Concurrent access requires careful locking or sharing policies  
- Exceptions must be handled to prevent resource leaks  
- File encoding and format must be consistent for reading/writing  

---

# Use Cases

- Logging and auditing  
- Configuration storage  
- Data serialization and persistence  
- Reading/writing reports, CSV, JSON, or binary data  
- File-based communication between applications  

---

# Memory and Performance

- Streams use internal buffers for efficiency  
- Buffered I/O reduces disk access overhead  
- Asynchronous streams allow non-blocking I/O  
- Large files may require chunked reading/writing to avoid memory overflow  

---

# Summary

- File I/O in C# enables reading and writing files using streams  
- Supports text and binary operations with buffering for performance  
- Requires resource management and error handling  
- Part of `System.IO` namespace  
- Provides persistent storage and flexible access patterns  

---

# Mental Model
