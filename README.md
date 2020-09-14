# C# Design Patterns

## The Gang of Four:
1. Erich Gamma
2. Richard Helm
3. Ralph Johnson
4. John Vlissides

## Design Pattern Categories:
1. Creational: Object creation mechanisms
2. Structural: Class and object composition
3. Behavioural: Communication between objects

| Creational | Structural | Behavioural |
|------------|------------|-------------|
| **Abstract Factory**  | Adapter | Chain of Responsibility |
| Builder | Bridge | Command |
| **Factory Method** | Composite | Interpreter |
| Object Pool | **Decorator** | **Iterator** |
| Prototype | Facade | Mediator |
| **Singleton** | Flyweight | Memento |
|| Proxy | **Observer** |
||| State |
||| Strategy |
||| Template Method |
||| Visitor |

## Non Gang of Four Pattern Used in .NET:
1. Repository pattern
2. Unit of Work pattern

## Design Pattern Benefits:
* Produce high-level solutions
* Ignore implementation details
* Write understandable, testable, and maintainable solutions

## Factory Method Pattern:
* Gang of Four:
Define an interface for creating an object, but let subclass decide which class to instantiate. This lets a class defer instantiation to subclass.

## Abstract Factory Pattern:
* Gang of Four:
Providing an interface for creating families of related or dependent objects without specifying their concrete classes.
> Ultimately a factory for other factories.

## Singleton Pattern:
* Gang of Four
Ensures a class has only one instance, and provides a global point of access to it.

## Decorator/Wrapper Pattern:
* Gang of Four:
Attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

> Using composition to limit inheritance and simplify object relationships to make more manageable.

## Iterator Pattern:
* Gang of Four:
Provide a way to access the elements of an aggregate object sequentially without exposing its undelying representation.

> Provides a way to access and iterate through collections in the same way, regardless of type.

## Observer Pattern:
* Gang of Four:
Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

> Change in one object causes a change or action in another.

## Repository Pattern:
* MSDB
A repository separates the business logic from the interactions with the underlying data source.

> Using a repository allows us to create an abstractions between an application and its data layer.

## Unit of Work Pattern:
* Martin Fowler's:
Maintains a list of objects affected by a business transaction and coordinates the writing out of changes and the resolution of concurrency problems.

## Builder Pattern:
* Gang of Four:
Separates the construction of a complex object from its representation so that the same construction process can create different representations.

> A pattern that lets us separate and reuse a specific process to build something.

## Adapter Pattern:
* Gang of Four:
Converts the interface of a class into another interface that clients expect.

> Makes incompatible interfaces comptible by making it possible to have them work together.

## Composite Pattern:
* Gang of Four:
> - Composes objects into tree structures to represent part-whole hierarchies.
> - Lets clients trat individual objects and compositions of objects uniformly.

> All about treating a group of objects and a single object as the same, while they can be different.

## Chain of Responsibility:
* Gang of Four:
> - Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
> - Chains the receiving objects and passes the request along the chain until an object handles it.

> Passing on the responsibility of a task from one object to another, and so forth, until an object accepts the responsibility and completes it.

