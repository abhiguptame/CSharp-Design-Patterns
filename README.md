# C# Design Patterns

## The Gang of Four:
### => 1) Erich Gamma
### => 2) Richard Helm
### => 3) Ralph Johnson
### => 4) John Vlissides

## Design Pattern Categories:
### => 1) Creational: Object creation mechanisms
### => 2) Structural: Class and object composition
### => 3) Behavioural: Communication between objects

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
### => 1) Repository pattern
### => 2) Unit of Work pattern

## Design Pattern Benefits:
### => Produce high-level solutions
### => Ignore implementation details
### => Write understandable, testable, and maintainable solutions

## Factory Method Pattern:
### => Gang of Four:
Define an interface for creating an object, but let subclass decide which class to instantiate. This lets a class defer instantiation to subclass.

## Abstract Factory Pattern:
### => Gang of Four:
Providing an interface for creating families of related or dependent objects without specifying their concrete classes.
Ultimately a factory for other factories.

## Singleton Pattern:
### => Gang of Four
Ensures a class has only one instance, and provides a global point of access to it.

## Decorator/Wrapper Pattern:
### => Gang of Four:
Attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

=> Using composition to limit inheritance and simplify object relationships to make more manageable.

## Iterator Pattern:
### => Gang of Four:
Provide a way to access the elements of an aggregate object sequentially without exposing its undelying representation.

=> Provides a way to access and iterate through collections in the same way, regardless of type.



