# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This is a .NET 9.0 C# tutorial/learning project set up as a console application. The project uses top-level statements in Program.cs and includes Docker support for containerized execution.

## Key Technology Stack

- **Framework**: .NET 9.0
- **Language**: C# with nullable reference types enabled
- **Project Type**: Console application (Exe)
- **Container**: Docker with Linux target OS

## Common Commands

### Build and Run
```bash
# Build the solution
dotnet build

# Run the application
dotnet run --project TutorialCSharp/TutorialCSharp.csproj

# Clean build artifacts
dotnet clean
```

### Docker Commands
```bash
# Build and run with Docker Compose
docker compose up --build

# Build Docker image directly
docker build -t tutorialcsharp -f TutorialCSharp/Dockerfile .

# Run Docker container
docker run tutorialcsharp
```

### Restore Dependencies
```bash
dotnet restore
```

## Project Structure

- **TutorialCSharp.sln**: Solution file containing the main project
- **TutorialCSharp/**: Main project directory
  - **Program.cs**: Entry point using top-level statements
  - **TutorialCSharp.csproj**: Project configuration (.NET 9.0, nullable enabled, implicit usings)
  - **Dockerfile**: Multi-stage Docker build (base → build → publish → final)
- **compose.yaml**: Docker Compose configuration at solution level

## Important Configuration Notes

- **Implicit Usings**: Enabled - common namespaces are automatically imported
- **Nullable Reference Types**: Enabled - null safety is enforced at compile time
- **Docker**: Multi-stage build optimized for .NET 9.0 with Linux runtime