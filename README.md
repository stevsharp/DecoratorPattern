# Decorator Pattern

This repository provides a comprehensive example of the Decorator Design Pattern in C#. The Decorator Pattern is a structural pattern that allows behavior to be 

added to individual objects, dynamically, without affecting the behavior of other objects from the same class.


## Introduction

The Decorator Pattern is used to extend the functionalities of objects in a flexible and reusable way. This pattern is particularly useful when you want to add responsibilities to individual objects without creating a subclass for each possible combination of functionalities.

## Use Case

In this repository, we demonstrate the Decorator Pattern through a simple use case. Suppose we have a base component that needs to be extended with additional functionalities. Instead of creating multiple subclasses, we can use decorators to achieve the desired behavior.

## Components

The main components of the Decorator Pattern implementation are:

1. **Component Interface**: Defines the interface for objects that can have responsibilities added to them dynamically.
2. **Concrete Component**: Implements the component interface and represents the object to which additional responsibilities can be attached.
3. **Decorator**: Implements the component interface and holds a reference to a component object. It defines an interface that conforms to the component's interface but also provides additional behaviors.
4. **Concrete Decorators**: Extends the functionality of the component by adding new behaviors.

## How to Run

To run the example code provided in this repository, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/stevsharp/DecoratorPattern.git
    cd DecoratorPattern
    ```

2. Open the project in your preferred C# IDE (e.g., Visual Studio).

3. Build the solution.

4. Run the application.

## Examples

Here is a simple example illustrating how to use the Decorator Pattern in C#:

```csharp
// Base Component
public interface IComponent
{
    void Operation();
}

// Concrete Component
public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent operation");
    }
}

// Base Decorator
public abstract class Decorator : IComponent
{
    protected IComponent _component;

    public Decorator(IComponent component)
    {
        _component = component;
    }

    public virtual void Operation()
    {
        _component.Operation();
    }
}

// Concrete Decorator A
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA operation");
    }
}

// Concrete Decorator B
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component) { }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorB operation");
    }
}

// Main class to run the example
class Program
{
    static void Main(string[] args)
    {
        IComponent component = new ConcreteComponent();
        IComponent decoratorA = new ConcreteDecoratorA(component);
        IComponent decoratorB = new ConcreteDecoratorB(decoratorA);

        decoratorB.Operation();
    }
}
