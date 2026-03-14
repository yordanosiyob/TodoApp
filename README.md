# TDD Ticket Booking System

A ticket booking application developed using Test-Driven Development (TDD) in C# and .NET.

## About
This project was built following the Red-Green-Refactor cycle, writing tests before 
implementation to ensure reliable and maintainable code.

## Features
- Book and manage tickets
- Bookings saved to a SQL database
- Full test coverage using xUnit
- Decoupled dependencies using mocking

## Tech Stack
- C# / .NET
- xUnit
- SQL
- Visual Studio

## TDD Approach
Each feature was developed following the TDD cycle:
1. Red – Write a failing test
2. Green – Write minimal code to pass the test
3. Refactor – Clean up the code while keeping tests green

## How to run
1. Clone the repository
2. Open the solution in Visual Studio
3. Set up the database using the provided SQL script
4. Run tests: dotnet test
5. Run the application: dotnet run
