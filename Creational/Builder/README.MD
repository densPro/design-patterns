# Builder

**S**eparate the construction of a complex object from its representation
so that the same construction process can create different representations. 

> (Design Patterns: Elements of Reusable Object-Oriented Software).

![structure](assets/img/structure.PNG)

##### Participants 

- **Builder** (TextConverter)
  - Specifies an abstract interface for creating parts of a Product object.
- **ConcreteBuilder** (ASCIIConverter, TeXConverter, TextWidgetConverter)
  - Constructs and assembles parts of the product by implementing the Builder interface.
  - Defines and keeps track of the representation it creates.
  - Provides an interface for retrieving the product (e.g., GetASCIIText, GetTextWidget).
- **Director** (RTFReader)
  - Constructs an object using the Builder interface.
- **Product** (ASCIIText, TeXText, TextWidget)
  - Represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled.
  - Includes classes that define the constituent parts, including interfaces for assembling the parts into the final result. 

