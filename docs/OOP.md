Object Oriented Programming
========

The Pillars of OOP
------
* Abstraction
* Inheritance
* Polymorphism
* Encapsulation

Abstraction
-----
Abstraction lets you hide the implementation details and only expose relevant parts of the code. 

Encapsulation
----
Encapsulation lets you interact with a single unit of code.

Inheritance
----
Inheritance allows you to reuse, redefine, extend or modify the behavior of parent class.

Polymorphism
----
Polymorphism lets you call the same function with different implementation based on the object.


Types of Inheritance
----
* Single Inheritance - One class can derive from a base class
* Multiple Inheritance - One class can inherit from multiple classes (not permitted in C#)
* Multilevel Inheritance - When a class in grandchildren of another class
* Interface Inheritance - When a class implements an Interface

Notes
---
* Structs does not support inheritance, but they can implement many interfaces.
* Classes can only inherit from one class, but can implement many interfaces. 
* If you don't specify a class, System.Object is assumed.
* In case a class and interface are used to derive from, the class go first.

Modifiers
----
| Name | Applies To | Description |
|---|---|---|
|public|Any types or members|Visible to any other code.|
|protected| Any member of a type or any nested type| Visible only to any derived type.|
|internal|Any types or members | Visible only within its containing assembly. |
|private| Any member of a type or any nested type| Visible only inside the type to which it belongs.
|protected internal| Any member of a type or any nested type|Visible to any code in the assembly or inside a derived class.|
|private protected |  Any member of a type or any nested type|Access is allowed only to the derived types that are within the same assembly. New in C# 7.2|

Other Modifiers
---
|Name| Applies To | Description |
|---|---|---|
| new | Function members| Hides an inherited member with the same signature. |
| static | All members | It does not operate on a specific instance.|
| virtual | Function members | The member can be overriden by a derived class.|
| abstract | Function members | This member has to be overriden by a derived class. |
| override | Function members | The member overrides the inherited or abstract method.|
| sealed | Classes, methods & properties | For classes you cannot inherit from. The member overrides, but cannot be overriden by any derived class. |

Notes
---
* Internal is the default modifier it is not specified.

Class
---
[modifiers] class ClassName : ParentClass, InterfaceImplements { <br />
<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;//Constructor <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ClassName() : base() { <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;} <br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [modifiers] [Type or class] PropertyName;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [modifiers] [Return type or class] FunctionName() {<br />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}<br />
}





Dependency Inversion Principle
---
1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
2. Abstractions should not depend on details. Details should depend on abstractions.