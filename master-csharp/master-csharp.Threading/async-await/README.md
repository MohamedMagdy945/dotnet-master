## 13. Async and Await in C#

### 13.1 What is Async/Await?
**`async`** and **`await`** are keywords in C# used for **asynchronous programming**. They allow methods to perform operations without blocking the main thread, making applications more responsive, especially for **I/O-bound operations** like file access, network calls, or database queries.

- **`async`**: Marks a method as asynchronous. It allows the use of `await` inside the method.
- **`await`**: Pauses execution of the method until the awaited **Task** completes, without blocking the thread.

---

### 13.2 How Async/Await Works
1. When an async method is called, it starts execution up to the first `await`.
2. At the `await`, the method yields control back to the caller.
3. The awaiting **Task** runs in the background.
4. When the Task completes, execution resumes from the `await` point.

**Key Points:**
- Async methods always return `Task`, `Task<TResult>`, or `void` (rare, only for event handlers).
- Async/await does not create new threads automatically; it uses **Tasks and the ThreadPool**.
- Improves responsiveness of UI applications by not blocking the main thread.

---

### 13.3 Benefits of Async/Await
- **Non-blocking**: Main thread is free for other operations.
- **Simpler code**: Easier to read and maintain than callbacks or raw threads.
- **Better exception handling**: Exceptions inside async methods can be caught using try/catch.
- **Integration with Tasks**: Works seamlessly with `Task` and `Task<TResult>`.

---

### 13.4 Async/Await vs Thread
| Feature           | Thread                          | Async/Await                     |
|------------------|---------------------------------|--------------------------------|
| Blocking          | May block calling thread        | Non-blocking                    |
| Return Value      | Cannot return directly           | Can return Task<TResult>        |
| Thread Usage      | May create new thread            | Uses existing ThreadPool threads |
| Exception Handling| Must handle manually             | Automatic propagation           |
| Use Case          | CPU-bound work                   | I/O-bound or network-bound work |

---

### 13.5 Best Practices
1. Use async/await for **I/O-bound operations**.
2. Avoid `async void` except for event handlers.
3. Use **ConfigureAwait(false)** in libraries to avoid capturing the synchronization context unnecessarily.
4. Combine with **CancellationToken** to support task cancellation.
5. Avoid blocking calls (`Task.Wait()` or `Task.Result`) in async methods – use `await`.

---

### 13.6 Summary
`async` and `await` simplify asynchronous programming in C#, allowing methods to **run without blocking threads**, handle exceptions cleanly, and integrate naturally with the **Task Parallel Library**. When combined with Tasks and proper synchronization, async/await is a powerful tool for responsive and high-performance applications.
