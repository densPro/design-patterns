# Builder

**S**eparate the construction of a complex object from its representation
so that the same construction process can create different representations. 

> (Design Patterns: Elements of Reusable Object-Oriented Software).

![structure](assets/img/structure.PNG)

##### Participants 

- **Builder**
  - Specifies an abstract interface for creating parts of a Product object.
- **ConcreteBuilder**
  - Constructs and assembles parts of the product by implementing the Builder interface.
  - Defines and keeps track of the representation it creates.
  - Provides an interface for retrieving the product (e.g., GetASCIIText, GetTextWidget).
- **Director**
  - Constructs an object using the Builder interface.
- **Product**
  - Represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled.
  - Includes classes that define the constituent parts, including interfaces for assembling the parts into the final result. 

**Implementation**

It has been considered a business case of fast-food restaurant where a typical combo could be a burger or fried chicken with French fries, toy and a cold drink. 