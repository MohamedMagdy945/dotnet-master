# EF Core Loading Strategies

This document explains the different **data loading strategies in Entity Framework Core**.  
Loading defines **how related data is retrieved from the database when querying entities**.

---

# 1. What is Data Loading?

Data loading refers to **how EF Core retrieves related entities from the database** when working with relationships.

For example, when retrieving an entity that has related data (such as a parent entity with child entities), EF Core needs a strategy to determine **when and how the related data should be loaded**.

EF Core provides multiple loading strategies to balance between **performance, memory usage, and database queries**.

---

# 2. Types of Loading in EF Core

EF Core provides three main loading strategies:

- Eager Loading
- Lazy Loading
- Explicit Loading

Each strategy determines **when related data is retrieved from the database**.

---

# 3. Eager Loading

Eager loading retrieves the **main entity and all required related entities in a single query**.

### Characteristics

- Related data is loaded **immediately with the main query**.
- Usually results in **JOIN operations** in SQL.
- Reduces the number of database round-trips.
- Best used when you **know in advance that related data is required**.

### Advantages

- Fewer database queries.
- Better performance when related data is always needed.

### Disadvantages

- May retrieve unnecessary data if relationships are large.
- Can produce complex queries when loading many relationships.

---

# 4. Lazy Loading

Lazy loading delays loading related data **until it is actually accessed in code**.

### Characteristics

- The main entity is loaded first.
- Related data is automatically retrieved **when the navigation property is accessed**.
- Generates **additional queries when data is accessed**.

### Advantages

- Only loads related data when needed.
- Reduces initial query complexity.

### Disadvantages

- Can cause **many database queries** (N+1 query problem).
- May reduce performance in large loops or heavy queries.

---

# 5. Explicit Loading

Explicit loading gives the developer **manual control over when related data is loaded**.

### Characteristics

- The main entity is loaded first.
- Related data is retrieved **only when explicitly requested by the developer**.
- Allows selective loading of relationships.

### Advantages

- Provides full control over when data is loaded.
- Helps avoid unnecessary queries.

### Disadvantages

- Requires additional logic in the code.
- May increase complexity if many relationships are involved.

---

# 6. Comparison of Loading Strategies

| Strategy | When Data Loads | Query Behavior | Use Case |
|--------|----------------|---------------|----------|
| Eager Loading | Immediately with main query | Usually a single complex query | When related data is always required |
| Lazy Loading | When property is accessed | Multiple queries | When related data might not always be needed |
| Explicit Loading | When developer requests it | Separate controlled queries | When precise control over data loading is required |

---

# 7. Choosing the Right Strategy

Selecting the appropriate loading strategy depends on:

- Application performance requirements
- Amount of related data
- Frequency of data access
- Query complexity

General guidelines:

- Use **Eager Loading** when related data is always required.
- Use **Lazy Loading** when related data may not always be accessed.
- Use **Explicit Loading** when you need precise control over loading behavior.

---

# 8. Performance Considerations

Data loading strategies can significantly affect application performance.

Common concerns include:

- Excessive database queries
- Large result sets
- Complex joins
- Memory usage

Proper selection of a loading strategy helps ensure **efficient database interaction and optimized performance**.

---

# Conclusion

EF Core provides multiple strategies for loading related data, allowing developers to balance between **performance, flexibility, and control**.

Understanding the differences between **Eager, Lazy, and Explicit Loading** is essential for building efficient and scalable applications.