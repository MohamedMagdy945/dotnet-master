# Theoretical Guide to JWT in .NET

This document provides a theoretical explanation of each step required to create and use JWT in ASP.NET Core, without any code examples.

## 1. Install Required Package

* Install the official JWT library in the .NET project to provide the necessary functions to generate and validate JWTs.

## 2. JWT Configuration Settings

* Define the issuer of the token (Issuer).
* Define the audience allowed to use the token (Audience).
* Specify the secret key used for signing the token (SecretKey).
* Set the token expiration duration (TokenExpiryMinutes).

## 3. User Claims Model

* Define the basic information about the user to include in the token, such as user ID, email, and role.

## 4. JWT Generation Service

* Access the application settings to read the secret key and token expiration.
* Specify the appropriate encryption method (e.g., HMACSHA256).
* Create a set of claims for the user, including ID, email, role, and a unique token identifier.
* Generate the JWT using the settings and claims.
* Convert the token into a string that can be sent to the client.

## 5. Register JWT Service

* Register the JWT service in the application's dependency injection system, so it can be used wherever token generation is needed.

## 6. Controller for User Authentication

* Receive login data from the user.
* Validate the user's credentials.
* Create claims for the authenticated user.
* Generate a JWT for the user and send it as a response.

## 7. JWT Middleware Setup

* Enable authentication in the application.
* Define validation policies such as verifying the issuer, audience, token lifetime, and signing key.
* Configure additional options such as clock skew adjustments.

## 8. Protecting Endpoints

* Use authorization mechanisms to protect API endpoints.
* Specify the roles or permissions required to access each endpoint.

## 9. Best Practices

* Keep access tokens short-lived for security.
* Use long-lived refresh tokens to renew access tokens without requiring the user to log in again.
* Do not store the secret key in source code; use secrets management or environment variables.
* Always verify roles and permissions for protected endpoints.

## 10. Reference

* For detailed official guidance, refer to Microsoft documentation: [JWT Authentication Documentation](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/jwt?view=aspnetcore-9.0)



This README explains how to create JWT (JSON Web Tokens) in ASP.NET Core step by step with detailed explanations for each line.

## 1. Install Required Package

```bash
dotnet add package System.IdentityModel.Tokens.Jwt
```

* This package is required to generate and validate JWTs.

## 2. Configure `appsettings.json`

```json
{
  "JwtSettings": {
    "Issuer": "MyApp",            // The issuer of the token
    "Audience": "MyAppUsers",     // The allowed audience for the token
    "SecretKey": "ThisIsASuperSecretKey12345!", // Encryption key
    "TokenExpiryMinutes": 15        // Token expiration time in minutes
  }
}
```

* Defines the settings required for token creation and validation.

## 3. Define `UserClaims` Model

```csharp
public class UserClaims
{
    public string UserId { get; set; }   // User identifier (subject)
    public string Email { get; set; }    // User email
    public string Role { get; set; }     // User role for authorization
}
```

* Represents the user information to be included in the JWT.

## 4. Create JWT Service

```csharp
public class JwtService
{
    private readonly IConfiguration _config;  // Access application settings

    public JwtService(IConfiguration config) => _config = config;

    public string GenerateToken(UserClaims user)
    {
        var jwtSettings = _config.GetSection("JwtSettings");
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]));
        var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.UserId),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(double.Parse(jwtSettings["TokenExpiryMinutes"])),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
```

* Generates a JWT using user claims, expiration, and signing credentials.

## 5. Register Service in `Program.cs`

```csharp
builder.Services.AddSingleton<JwtService>();
```

* Registers `JwtService` with Dependency Injection for use across the application.

## 6. Create `AuthController`

```csharp
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;

    public AuthController(JwtService jwtService) => _jwtService = jwtService;

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if(request.Username == "admin" && request.Password == "1234")
        {
            var userClaims = new UserClaims
            {
                UserId = "1",
                Email = "admin@myapp.com",
                Role = "Admin"
            };

            var token = _jwtService.GenerateToken(userClaims);
            return Ok(new { AccessToken = token });
        }
        return Unauthorized();
    }
}
```

* Handles login requests and generates a JWT for authenticated users.

## 7. Configure JWT Authentication Middleware

```csharp
builder.Services.AddAuthentication()
    .AddJwtBearer(options => {
        options.TokenValidationParameters = new TokenValidationParameters {
            ValidateIssuer = true,                        
            ValidateAudience = true,                    
            ValidateLifetime = true,                    
            ValidateIssuerSigningKey = true,            
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"])),
            ClockSkew = TimeSpan.Zero                    
        };
    });
```

* Configures the middleware to validate tokens in incoming requests.

## 8. Protect Endpoints

```csharp
[HttpGet("admin")]
[Authorize(Roles = "Admin")]
public IActionResult AdminOnly() => Ok("Welcome Admin!");
```

* Restricts access to users with the `Admin` role.

## 9. Reference

* [Microsoft JWT Authentication Documentation](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/jwt?view=aspnetcore-9.0)
