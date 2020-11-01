# Factory - Factory Method

Define an interface for creating an object, but let subclasses decide
which class to instantiate. Factory Method lets a class defer instantiation 
Design Patterns: Elements of Reusable Object-Oriented Software to subclasses. 


> (Design Patterns: Elements of Reusable Object-Oriented Software).

![](assets/img/factory-structure.PNG)**Participants**

- **Product**
  - Defines the interface of objects the factory method creates. 
- **ConcreteProduct**
  - Implements the Product interface.
- **Creator**
  - Declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object. 
  -  May call the factory method to create a Product object.
- **ConcreteCreator**
  - Overrides the factory method to return an instance of a ConcreteProduct. 

**Implementation**

Transportation company that can deliver products by earth or sea.