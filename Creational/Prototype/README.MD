# Prototype

Specify the kinds of objects to create using a prototypical instance,
and create new objects by copying this prototype. 

> (Design Patterns: Elements of Reusable Object-Oriented Software).

![](assets/img/Prototype.PNG)

**Participants**

- **Prototype** (Graphic)
  - Declares an interface for cloning itself.
- **ConcretePrototype** (Staff, WholeNote, HalfNote)
  - Implements an operation for cloning itself.
- **Client** (GraphicTool)
  - Creates a new object by asking a prototype to clone itself.

