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

## Chain of Responsibility Pattern:
* Gang of Four:
> - Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
> - Chains the receiving objects and passes the request along the chain until an object handles it.

> Passing on the responsibility of a task from one object to another, and so forth, until an object accepts the responsibility and completes it.

## Command Pattern:
* Gang of Four:

Encapsulates a request as an object, thereby letting us parameterize clients with different requests, queue or log request, and support undoable operation.

> Uses an object to store required information to perform an action at any point in time.

## Interpreter Pattern:
* Gang of Four:

Given a language, defines a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.

> A translator

## Mediator Pattern:
* Gang of Four:

> - Defines an object that encapsulates how a set of objects interact.
> - Promotes loose coupling by keeping objects from referring to each other explicitly, and lets us vary their interaction independently.

> Lets us control the communication between each object.

## Visitor Pattern:
* Gang of Four:

> - Represents an operation to be performed on the elements of an object structure.
> - Lets us define a new operation without changing the classes of the elements on which it operates.

> Lets us add and perform new functionality on objects without changing its structure which might cause problems.

## Prototype Pattern:
* Gang of Four:

Specifies the kinds of objects to create using a prototypical instance and creates new objects by copying this prototype.

> The goal of the prototype pattern is to create an object based on another object.

## Bridge Pattern:
* Gang of Four:

Decouple an abstraction from its implementation so that the two can vary independently.

> Used to separate an abstraction from its implementation so both are modified independently.

## Facade Pattern:
* Gang of Four:

> - Provides a unified interface to a set of interfaces in subsystem.
> - Defines a higher-level interface that makes the subsystem easier to use.

> Used to hide the complexities of the system and provides an interface to the client.

## Flyweight Pattern:
* Gang of Four:

Uses sharing to support large numbers of fine-grained objects efficiently.

> Eliminates the need of creating new object that already exist by sharing existing one.

## Proxy Pattern:
* Gang of Four:

Provides a surrogate or placeholder for another object to control access to it.

> Provides objects that refernce objects for their functionality.

## Memento Pattern:
* Gang of Four:

Without violating encapsulation, captures and externalizes an object's internal state so that the object can be restored to this state later.

> Used to track states of an object to go back and forth to.

## State Pattern:
* Gang of Four:

> - Allows an object to alter its behaviour when its internal state changes.
> - The object will appear to change its class.

> Allows an object to change what it does based on its current state.

## Strategy Pattern:
* Gang of Four:

> - Defines a family of algorithms, encapsulates each one, and makes them interchangeable.
> - Strategy lets the algorithm vary independently from clients that use it.

> Allows a client to choose an algorithm from a group of algorithms and gives it a simple way to access it.

## Template Method Pattern:
* Gang of Four:

> - Defines the skelton of an algorithm in an operation, deferring some steps to subclasses.
> - Lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

> Allows child classes to change some steps of an algorithm without changing the algorithm's structure.






