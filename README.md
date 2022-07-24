# SolidPrinciples

For better understanding please see my youtube video - https://youtu.be/Xm9fezWpHPg

In this video, we will discuss about SOLID principles in C#, we will see all concept of SOLID here.
SOLID principles are the design principles that enable us to manage most of the software design problems. 
SOLID is a acronym for five design principles.

✅ S: Single Responsibility Principle (SRP)

SRP says that each class, module, or function in your program should only do one job.

WHY SRP?
Easy Testing
Parallel Development
Loose Coupling

✅ O: Open closed Principle (OCP)
OCP says that classes, methods, modules etc. are open for extension, but closed for modification.

WHY OCP?
End up testing the entire functionality
QA team need to test the entire flow
Costly process

✅ L: Liskov substitution Principle (LSP)
if we can successfully replace the object/instance of a parent class with the object/instance of the child class, without affecting the behavior of the base class, then it is said to be in Liskov Substitution Principle.

✅ I: Interface Segregation Principle (ISP)
ISP says clients should not be forced to implement interfaces they don’t use. So instead of huge interfaces, it is better to create multiple small ones so that they are utilized in the best possible way.

✅ D: Dependency Inversion Principle (DIP)
DIP Says High-level modules should not depend on low-level modules. Instead, both should depend on abstractions (interfaces).
WHY DIP?
Loose Coupling
With the help of Dependency Injection we can achieve better and easy Dependency Inversion Principle.
In Asp.net we were using Unity block for Dependency Injection but in .NET core 3.1 we have inbuilt Dependency Injection. We will see detail about Dependency Injection in upcoming videos
