# LINQ Glossary – C# Advanced Topics

This document covers **all important terms and concepts in LINQ**.  
It is intended as a **reference for developers** who want to master querying in C#.

---

## Table of Contents

1. [LINQ](#linq)  
2. [Deferred Execution](#deferred-execution)  
3. [Immediate Execution](#immediate-execution)  
4. [Query Syntax](#query-syntax)  
5. [Method Syntax](#method-syntax)  
6. [Extension Methods](#extension-methods)  
7. [Projection](#projection)  
8. [Filtering](#filtering)  
9. [Sorting](#sorting)  
10. [Grouping](#grouping)  
11. [Joining](#joining)  
12. [Aggregation](#aggregation)  
13. [PLINQ](#plinq)  
14. [Expression Trees](#expression-trees)  
15. [Custom LINQ Operators](#custom-linq-operators)  
16. [Enumerable vs IQueryable](#enumerable-vs-iqueryable)  
17. [Chaining Queries](#chaining-queries)  
18. [Lazy Evaluation](#lazy-evaluation)  
19. [Materialization](#materialization)  
20. [Best Practices](#best-practices)  

---

## LINQ

**Language Integrated Query (LINQ)** – a set of features in C# to **query and manipulate data** in a **consistent and type-safe way**.  
It can be applied to **collections, databases, XML, and more**.

---

## Deferred Execution

Queries are **not executed when defined**, but **when enumerated**.  
Examples: `foreach`, `ToList()`, `ToArray()`.  

Advantages: better performance, up-to-date results, and efficient pipelines.

---

## Immediate Execution

Queries that **execute immediately** when called.  
Examples: `ToList()`, `ToArray()`, `Count()`, `First()`.  

Used when results are needed right away.

---

## Query Syntax

SQL-like syntax in C# for defining LINQ queries.

---

## Method Syntax

Also called **fluent syntax**, uses **extension methods and lambda expressions**.

---

## Extension Methods

Methods that **extend existing types** without modifying them.  
LINQ relies heavily on extension methods like `Where`, `Select`, `OrderBy`.

---

## Projection

Transforming elements of a collection into a new form.  
Example: selecting specific properties or creating new objects.

---

## Filtering

Selecting elements that satisfy a **predicate condition**.  
Common method: `Where`.

---

## Sorting

Ordering elements based on **keys**.  
Methods: `OrderBy`, `OrderByDescending`, `ThenBy`, `ThenByDescending`.

---

## Grouping

Grouping elements by a **key**.  
Method: `GroupBy`.

---

## Joining

Combining two collections based on **matching keys**.  
Methods: `Join`, `GroupJoin`.

---

## Aggregation

Performing **summary operations** on collections.  
Examples: `Count`, `Sum`, `Average`, `Min`, `Max`.

---

## PLINQ

**Parallel LINQ** – executes queries **in parallel** to leverage multiple CPU cores.  
Useful for **CPU-bound collections**.

---

## Expression Trees

Representation of code as **data structures**.  
Used by LINQ providers (like EF) to **translate queries** into SQL or other query languages.

---

## Custom LINQ Operators

You can **create your own query operators** using extension methods for **domain-specific queries**.

---

## Enumerable vs IQueryable

- **Enumerable**: LINQ to Objects, executed in memory.  
- **IQueryable**: LINQ to external sources (EF, SQL), executed in provider (like SQL translation).

---

## Chaining Queries

Multiple LINQ operations can be **chained together**, forming a **query pipeline**.

---

## Lazy Evaluation

Data is **processed only when needed**; avoids unnecessary computation.

---

## Materialization

When a deferred query is **executed and results are stored in memory**, e.g., `ToList()` or `ToArray()`.

---

## Best Practices

- Use deferred execution when possible.  
- Filter early and efficiently.  
- Avoid multiple enumerations of the same query.  
- Understand how LINQ translates queries when using EF.  
- Use PLINQ carefully – consider thread-safety and ordering.  

---

## Resources

- [Microsoft Docs - LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)  
- [C# In Depth by Jon Skeet](https://csharpindepth.com/)  
- [LINQ 101 Samples](https://learn.microsoft.com/en-us/samples/dotnet/try-samples/101-linq-samples/)  

---

⭐ This glossary is intended as a **quick reference** for advanced C# developers.