# Clean Architecture .NET API

This project is a **Clean Architecture** template for a **.NET API**, with a clear separation between **Domain** and **Core** layers.

---

## Proposed Project Structure

```
/Domain
    /Entities
        User.cs
        Product.cs
        Order.cs
    /ValueObjects
        Email.cs
        Money.cs
        Address.cs
    /Aggregates
        OrderAggregate.cs
        UserAggregate.cs
    /DomainServices
        UserValidationService.cs
        PaymentDomainService.cs
    /Events
        UserCreatedEvent.cs
        OrderPaidEvent.cs

/Core
    /Interfaces
        IUserRepository.cs
        IUnitOfWork.cs
    /Specifications
        UserByEmailSpec.cs

/Application
    /DTOs
        UserDto.cs
    /Interfaces
        IUserService.cs
    /Commands
        CreateUserCommand.cs
    /CommandHandlers
        CreateUserCommandHandler.cs
    /Queries
        GetUserByIdQuery.cs
    /QueryHandlers
        GetUserByIdQueryHandler.cs

/Infrastructure
    /Persistence
        AppDbContext.cs
        UserRepository.cs
    /Services
        EmailService.cs
        PaymentGateway.cs

/API
    /Controllers
        UsersController.cs
    /Middlewares
        ExceptionMiddleware.cs
        LoggingMiddleware.cs

/Tests
    /UnitTests
        UserServiceTests.cs
    /IntegrationTests
        UsersControllerTests.cs
```

---

## Layer Explanation

### 1. Domain Layer

* Contains **Entities, Value Objects, Aggregates, Domain Services, Domain Events**
* Completely independent of any database or framework

### 2. Core Layer

* Contains **Interfaces and Contracts** used by other layers
* Example: IUserRepository, IUnitOfWork

### 3. Application Layer

* Contains **Use Cases, Handlers, DTOs**
* Depends on **Domain + Core**
* Example: CreateUserCommandHandler, GetUserByIdQueryHandler

### 4. Infrastructure Layer

* Contains **DB context, Repository implementations, External services**
* Example: UserRepository, EmailService

### 5. API Layer

* Contains **Controllers and Middleware**
* Depends only on **Application Layer**
* Example: UsersController, ExceptionMiddleware

### 6. Tests Layer

* Contains **Unit Tests and Integration Tests**
* Tests Domain, Application, and API layers

---

## Best Practices

1. **Dependency Inversion**: each layer depends only on the one above it.
2. **Use DTOs**: to reduce coupling between API and Application.
3. **CQRS & MediatR**: optional for separating Commands from Queries.
4. **FluentValidation**: for request validation.
5. **Rich Domain Model**: entities should include behavior, not just data.
6. **Centralized Middleware**: for exceptions and logging.
7. **Unit Test Coverage**: focus on Domain and Application layers.

---

## Example of a Rich Entity

```csharp
public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Email Email { get; private set; }

    public User(string name, Email email)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
    }

    public void ChangeEmail(Email newEmail)
    {
        Email = newEmail;
    }
}
```

---

## Example of a Command Handler

```csharp
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
{
    private readonly IUserRepository _userRepository;

    public CreateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        if (await _userRepository.ExistsEmailAsync(request.Email))
            throw new Exception("Email already exists");

        var user = new User(request.Name, new Email(request.Email));
        await _userRepository.AddAsync(user);
        return new UserDto(user.Id, user.Name, user.Email.Address);
    }
}
```

---

## Summary

* **Domain** is independent and robust.
* **Core** contains only definitions and interfaces.
* **Application** contains handlers and use cases.
* **Infrastructure** contains implementations.
* **API** is the presentation layer only.
* Each layer depends only on the layers above it.

---

**This structure makes the project easy to expand, test, and maintain.**
