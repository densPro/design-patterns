# Abstract Factory

**P**rovide an interface for creating families of related or dependent
objects without specifying their concrete classes. 

> (Design Patterns: Elements of Reusable Object-Oriented Software).

![abstract-factory-structure](assets/img/abstract-factory-structure.PNG)

**Participants**

- **AbstractFactory** (WidgetFactory)
  - Declares an interface for operations that create abstract product objects.
- **ConcreteFactory** (MotifWidgetFactory, PMWidgetFactory)
  - Implements the operations to create concrete product objects.
- **AbstractProduct** (Window, ScrollBar)
  - Declares an interface for a type of product object.
- **ConcreteProduct** (MotifWindow, MotifScrollBar)
  - Defines a product object to be created by the corresponding concrete factory. o implements the AbstractProduct interface.
- **Client**
  - Uses only interfaces declared by AbstractFactory and AbstractProduct classes. 

