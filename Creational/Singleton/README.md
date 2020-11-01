# Singleton

Ensure a class only has one instance, and provide a global point of
access to it. 

> (Design Patterns: Elements of Reusable Object-Oriented Software).

![](assets/img/singleton.PNG)

**Participants**

- **Singleton**
  - Defines an Instance operation that lets clients access its unique instance. Instance is a class operation (that is, a class method in Smalltalk and a static member function in C++).
  - May be responsible for creating its own unique instance. 

**Implementation**

It has been considered a Logger implementation. Logging is a fundamental part of applications. Logs can inform us of many useful things such as; errors, warnings, stack traces, order of operations, events, and more. But how many instance are needed of a logger in an app?. Just one.

**Antipattern?**

https://stackoverflow.com/questions/137975/what-is-so-bad-about-singletons