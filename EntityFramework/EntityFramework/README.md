# Entity Framework Core Guide

This repository explains the main concepts of Entity Framework Core.

Contents

# Introduction

Entity Framework Core is an ORM for .NET.

ORM means Object Relational Mapping.

It maps database tables to C# classes.

Benefits

- Write queries using LINQ
- No need to write SQL manually
- Automatic migrations

# Installation

Install packages

Microsoft.EntityFrameworkCore  
Microsoft.EntityFrameworkCore.SqlServer  
Microsoft.EntityFrameworkCore.Tools

Command

dotnet add package Microsoft.EntityFrameworkCore

# DbContext

DbContext represents the session with the database.

Responsibilities

- Manage database connection
- Track entity changes
- Save changes to database

# DbSet

DbSet represents a database table.

Example

public DbSet<Student> Students { get; set; }

# Models

Models represent tables in the database.

Example

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

# Migrations

Migrations update the database schema.

Commands

add-migration Init

update-database

# CRUD Operations

Create

db.Students.Add(student)

Read

db.Students.ToList()

Update

student.Name = "Ali"

Delete

db.Students.Remove(student)

# Relationships

Types

- One to One
- One to Many
- Many to Many

# LINQ Queries

Example

var students = db.Students
    .Where(s => s.Age > 20)
    .ToList();

# Change Tracking

EF tracks entity changes automatically.

Disable tracking

AsNoTracking()

# Transactions

Transactions ensure multiple operations succeed or fail together.

# Async Queries

Use async methods

ToListAsync  
FirstOrDefaultAsync

# Configuration

Configure entities using Fluent API or Data Annotations.

# Performance Tips

- Use AsNoTracking for read queries
- Use pagination
- Avoid loading unnecessary datas