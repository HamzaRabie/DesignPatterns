# Design Patterns in C#

A collection of commonly used software design patterns implemented in C# with simple and practical examples.

The goal of this repository is to deeply understand:
- Why each pattern exists
- The problem it solves
- When to use it
- Advantages and disadvantages
- Real-world software architecture usage

---

# Implemented Patterns

## Creational Design Patterns

### Singleton
Ensures that only one instance of a class exists and provides a global access point to it.

#### Concepts Covered
- Lazy initialization
- Thread safety
- Global shared state

---

### Simple Factory
Creates objects without exposing creation logic to the client.

#### Concepts Covered
- Encapsulation of object creation
- Reducing object creation complexity

---

### Factory Method
Defines a method for creating objects while allowing subclasses to decide which object to create.

#### Concepts Covered
- Polymorphic object creation
- Open/Closed Principle
- Delegating creation responsibility

---

### Abstract Factory
Creates families of related objects without specifying concrete classes.

#### Concepts Covered
- Related object groups
- Product families
- Dependency abstraction

---

### Builder
Separates object construction from object representation.

#### Concepts Covered
- Step-by-step object creation
- Fluent APIs
- Complex object configuration

---

# Structural Design Patterns

### Adapter
Allows incompatible interfaces to work together.

#### Concepts Covered
- Interface conversion
- Legacy system integration
- Third-party service adaptation

---

### Decorator
Adds behavior dynamically to objects without modifying their original class.

#### Concepts Covered
- Runtime behavior extension
- Composition over inheritance
- Wrapping objects dynamically

---

### Facade
Provides a simplified interface to a complex subsystem.

#### Concepts Covered
- Hiding system complexity
- Simplified APIs
- Reducing coupling

---

# Behavioral Design Patterns

### Observer
Defines a one-to-many dependency so multiple objects are automatically notified when state changes.

#### Concepts Covered
- Event-driven programming
- Publish/Subscribe systems
- Loose coupling

---

### Strategy
Encapsulates interchangeable algorithms into separate classes.

#### Concepts Covered
- Runtime algorithm selection
- Replacing large if/else statements
- Behavior abstraction

---

### Mediator
Centralizes communication between objects to reduce direct dependencies.

#### Concepts Covered
- Decoupled communication
- Centralized coordination
- Object interaction management

---

# Technologies Used

- C#
- .NET
- Object-Oriented Programming (OOP)
- SOLID Principles

---

# Design Principles Practiced

- Composition Over Inheritance
- Open/Closed Principle
- Single Responsibility Principle
- Dependency Inversion Principle
- Encapsulation
- Loose Coupling

