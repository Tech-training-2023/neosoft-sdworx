# What is .Net?
.NET is the free, open-source, cross-platform framework for building modern apps and powerful cloud services. With .Net one can build, test, debug and deploy.

## What can you do with .Net ?
You can make many types of apps:
1. Web - Build web apps and services for macOS, Windows, Linux, and Docker.
2. Mobile and desktop - Use a single codebase to build native apps for Windows, macOS, iOS, and Android.
3. Cloud - Build scalable and resilient cloud-native apps that run on all major cloud providers.
4. Microservices - Create independently deployable microservices that run on Docker containers.
5. ML & AI, IoT, Windows, Game development, Front End Web, Backend APIs and many more ......

## Why .Net?
* Free and open source - .NET is a free and open-source project, developed and maintained on GitHub, the home for millions of developers who want to build great things together.
* Fast and cross-platform - .NET performs faster than any other popular framework, according to TechEmpower. You can write, run, and build on multiple platforms, including Windows, Linux, and macOS.
* Modern and productive - .NET helps you build apps for web, mobile, desktop, cloud, and more. With its large supportive ecosystem and powerful tooling, .NET is the most productive platform for developers.
* NuGet Package Manager - NuGet is the package manager for .NET. It enables developers to share compiled binaries with each other. NuGet.org offers many popular packages from the community.
* Allows backward compatibility most of the time.

## .NET history
- In 2002, Microsoft released .NET Framework, a development platform for creating Windows apps. Today .NET Framework is at version 4.8 and remains fully supported by Microsoft.

- In 2014, Microsoft introduced .NET Core as a cross-platform, open-source successor to .NET Framework. This new implementation of .NET kept the name .NET Core through version 3.1. The next version after .NET Core 3.1 was named .NET 5.

- New .NET versions continue to be released annually, each a major version number higher. They include significant new features and often enable new scenarios.
## What is implementations of .Net?
Implementations of .NET include .NET Framework, .NET 5+ (and .NET Core), UWP and Mono. These are multiple variants of .NET, each supporting a different type of app. The reason for multiple variants is part historical, part technical.
- Most of the .Net variants have sort of similar components which are:
1. **Runtime/Common Language Runtime** : backbone/engine to run any .net program
2. **Class libraries** : predefined libraries (packages) to help to create applications. Logic to these libraries are pre-written by experts from Microsoft or outside and ready to consume.
* **.NET Framework** 
    - .NET Framework is the original .NET implementation that has existed since 2002. 
    - deprecated in favor of .NET 6+, but still very common in legacy code.
    - still supported with bugfixes and security fixes.
    - final version 4.8 released 2019, supporting C# 7.3.
    - gets updates from Windows Update
    - CLR common language runtime (Virtual Execution System/VES)
        - a virtual machine that runs intermediate language
        - JIT just in time compiler
        - gets assembly, compiles to machine code on the fly
        - memory management / garbage collection
        - exception handling
        - thread management
    - FCL framework class library (Standard Libraries)
    - Base Class Library, later knowned as .Net Standard
* **Mono**
    - from 2004, open source, cross-platform (Unix)
        - originally reverse-engineered from .net framework
        - but only some frameworks were implemented
    - 3rd party at first, adopted by microsoft from 2016
    - Mono runtime (VES)
    - more support for AOT compilation (alternative to JIT), but JIT too
    - used by Xamarin for mobile
        - runtimes for iOS, Android, Mac
    - used by Unity for games

* **.NET Core**
    - from 2016, redesigned and architecturally simplified successor to .NET Framework
    - open source, cross-platform, better support for DevOps, command-line,containerization support
    - gets updates from manual installs / NuGet
    - .NET Framework frameworks were gradually ported to or redesigned for Core
            (like EF Core, EF 6, ASP.NET Core, WinForms, WPF), finished though
    - final version 3.1 released 2019
            (or, latest version is just .NET 6, depending on perspective)
    - CoreCLR (VES)
        - the CLR for Core
        - has a JIT as well, RyuJIT
        - all the features of the CLR
    - CoreFX (Standard Libraries)
* **.NET**
    - the latest version of .NET Core, rebranded to encourage more migration from .NET Framework, now that it's a lot more complete than it used to be.
    - latest version 8  released Nov 2023, supporting C# 12.0. Version 9 to be released on Nov 2024.

* **UWP**
    - for windows 10/xbox apps
    - uses .NET Native AOT compiler & runtime (VES)
    - CoreFx (Standard Libraries), same as .NET Core/5
## C# Program Structure
- [Namespaces](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace) - logical grouping of related types to avoid namespace conflict, helps in project/app packaging and versioning 
    - Types - class, struct, interface, delegates, enums, records
        - Type members - variables, fields, methods, events, properties etc....

- *File scoped namespace* declarations enable you to declare that all types in a file are in a single namespace. 
    - File scoped namespace declarations are available with C# 10. 
    - File scoped namespaces can't include additional namespace declarations. You cannot declare a nested namespace or a second file-scoped namespace:
## using keyword with namespaces
- the **using** directive imports all the types from a single namespace.
- The scope of a using directive without the global modifier is the file in which it appears.
- You can apply two modifiers to a using directive:
    - The *global* modifier has the same effect as adding the same using directive to every source file in your project. This modifier was introduced in C# 10.
    - The *static* modifier imports the static members and nested types from a single type rather than importing all the types in a namespace.
## Microsoft .NET language
- Dozens of programming languages are supported by .Net provided they are compatible with the platform, [listed.](https://en.wikipedia.org/wiki/List_of_CLI_languages)
- 3 different languages which are by default supported by .Net are
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/): Features are: 
    - Object oriented, type safe language and is case sensitive
        - object oriented means, that everything is an object. These objects are further organized with classes
        - Type-safe means that once you declare a type of a variable, you can't really change it. 
    - Component-oriented 
    - Lambda Expression, LINQ (Language Integrated Query), asynchronous operations ...
- Visual Basic : Supports UI and component oriented language.
- F#: F# is a functional programming language supported by .NET
- All .Net compliant languages ahve to follow a Standard. These standard are defined by CLS (Common Language Specification).
  - CLS gives a set of rules and regulation a .Net compliant language should follow. Ex all .Net compliant languages should be OOP languages, Array index should start from 0 etc...


# [Basics of C#](https://docs.microsoft.com/en-gb/users/dotnet/collections/yz26f8y64n7k07?WT.mc_id=dotnet-35129-website) 
- C# is Case-Sensitive, Object-Oriented, Component Oriented language
    - Object-oriented means everythign is based on objects and classes and the relationships between them
- C# has coding syntax resembling other programming languages like C, C++, Java. Not that they wanted to copy them but for ease of developers to adopt this programming language.
- It is a type safe language. Type Safety is because of component of .Net known as **CTS** (Common Type System).
    - Type-safe meaning once you set a datatype you can't change the datatype (unless you use certain techniques to do it)
## Types (Classes, Enums, Structs, Interface, Delegates)
-   All types in  C# are inherited directly or indirectly **System.Object**
    - **[Value Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)** 
        - which stores the direct value, 
        - stored in memory Stack,
        - Stack is always faster to retrieve data than heap
        - Every value type has a set of memory set aside for it to occupy (Ex: int can only store 32-bits while a double can store 64-bits) and stack memory is all about structure for efficiency and how data cannot be dynamically changing in size
        - Ex Predefined (int, long, short, byte, DateTime, char)
        - Structs - like a class but gets stored in the stack for memory retrieval efficiency
        - Enums - defines a set of named integral constants
    - **[Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)** 
        - They are datatypes that are stored in the heap and reference variables that are stored in the stack
         - Think of reference variables as having the address of a house since an address only holds the info on where the house is and not the actual house itself
        - When you declare a variable of a reference type and not have it point to anything in the beginning, it will have a null value
            - Null in the coding world means lack of value or there isn't any value at all
        - Reference variables are stored in the stack while the actual object itself is stored in the heap
        - retrieval a value from heap is an expensive process.
        - Why the heap? since memory in the heap can be dynamically changing
        - Ex Predefined -> string, arrays, collections etc, Classes, interface, Delegates.  
#### [Activity](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-1/)
Write your first code using C#
## Conversion
Because C# is statically-typed at compile time, after a variable is declared, it cannot be declared again or assigned a value of another type unless that type is implicitly convertible to the variable's type. For example, the `string` cannot be implicitly converted to `int`. 
However, you might sometimes need to copy a value into a variable or method parameter of another type. For example, you might have an `integer` variable that you need to pass to a method whose parameter is typed as `double`. Or you might need to assign a class variable to a variable of an interface type. These kinds of operations are called type conversions.
### Implict Conversions
* No syntax is required to change type because  conversion succeed with no data loss. 
* Examples include conversions from smaller to larger integral types, and conversions from derived classes to base classes.
* `long` can contain int values because long is 8 byte integer and `int` is of 4 byte integer type.
```
long height;
int h = 178;
height = h;// implicit conversion
```
### Explicit Conversion
* Explicit conversion require a cast expression. Casting is required when informations might be lost in the conversiom or when the conversion might not succeed. 
* Typical examples include numeric conversion to a type that has less precision or a smaller range, and conversion of a base-class instance to a derived class.
* Ex - numeric conversion to a type that has less precision or smaller range or conversion of base type to child type.
```
short height;
int h = 178;
height = (short)h;// explicit cast
```
### [User-defined conversion](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators)
* Gives you the capabilities to convert other datatypes into a class either implicitly or explicitly
* You must use the **operator** keyword followed by either **implicit** or **explicit** keyword
* User defined conversion are performed by special methods that define to enable explicit and implicit conversions between custom types that do noy have a class-derived class relationship.

### Conversion with Helper classes:
We can use `Parse` method of Type to convert built in types.
### [Boxing and Unboxing](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
* Boxing
    * It is when a value type gets casted into an object
    * Useful if you want a value type to have reference type like functionalities
    * It is implicit conversion
* Unboxing
    * When you extract the value from an object and convert it into a value type instead
    * It is explicit conversion
```
Console.WriteLine("==== Boxing and Unboxing ====");
            
            //Value type
            //You get the value directly
            int num = 123;

            //Boxing example
            //When a value type gets casted into an object
            //What happens is that the value is wrapped to give it a reference type behavior
            //No other syntax is needed
            //It is implicit conversion
            object obj = num;
            Console.WriteLine(obj);

            //Unboxing example
            //When you extract the value type from the object and just get the value directly instead
            //A syntax is needed (dataType)Object
            //It is explicit converion
            int num2 = (int)obj;
            Console.WriteLine(num2);
```
- Boxing and unboxing are computationally expensive and in return they are poor in [performance](https://learn.microsoft.com/en-us/dotnet/framework/performance/performance-tips)
    - When a value type is boxed it has allocate a new object and constructed. Memory location also changes from stack to heap.
    - For unboxing to a lesser degree, you have to move an object to stack memory
    - It is best to avoid boxing using value types in situation where they are boxed a high number of times. This can take upto 20 times longer than a simple reference assignment.
    - ![boxing](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/media/boxing-and-unboxing/boxing-operation-i-o-variables.gif)
    - Similar way when unboxing happens it can take upto 4 times as long as an assignment.
    - ![unboxin](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/media/boxing-and-unboxing/unboxing-conversion-operation.gif)
#### [Activity](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-4/)
Choose the correct data type in your C# code
### How to handle overflow checks
* When integer arithmetic overflow occurs, the overflow-checking context defines what happens. 
* The checked and unchecked statements specify the overflow-checking context for integral-type arithmetic operations and conversions.
* In a checked context, a System.OverflowException is thrown
* In an unchecked context, the operation result is truncated by discarding any high-order bits that don't fit in the destination type.
* To access the individual Unicode code points in a string, use the `StringInfo` object.
* By default the value of integral type arithmatic operations and conversions are executed in unchecked context.
## [Strings](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
A string is an object of type String whose value is text. 
* Internally they are an array of Characters.
* There's no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0').
* The **Length** property of a string represents the number of Char objects it contains, not the number of Unicode characters.
* String class offers many String operations that can be performed on a string - Contains, ToUpper, ToLower, Clone, CopyTo, Substring, IndexOf, Reverse, Replace, EndsWith, StartsWith, Trim.
* String objects are **immutable**: they cannot be changed after they have been created. 
  - All of the String methods and C# operators that appear to modify a string actually return the results in a new string object.
  - Use [String Builder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-5.0) class top perform operations on the string with better performance.
* **Quoted string literals** start and end with a single double quote character '(")' on the same line. 
    * Quoted string literals are best suited for strings that fit on a single line and don't include any escape sequences.
* *Verbatim string literals* are more convenient for multi-line strings, strings that contain backslash characters, or embedded double quotes. 
    * Verbatim strings preserve new line characters as part of the string text. 
    * Use double quotation marks to embed a quotation mark inside a verbatim string. 

### Format strings
A format string is a string whose contents are determined dynamically at run time. 
* Format strings are created by embedding interpolated expressions or placeholders inside of braces within a string. 
* Everything inside the braces '({...})' will be resolved to a value and output as a formatted string at run time. 
* There are two methods to create format strings: [string interpolation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated) and [composite formatting](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated).
#### [Activity](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/exploration/interpolated-strings)
String Interpolation

### *var* keyword
- Implicit typed variables declared using var. 
- The compiler infer the type of a variable from its initialization expression. To do that, use the var keyword instead of a type's name.
- When you work with [anonymous types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types), you must use implicitly-typed local variables.

### Constants
- Constants are immutable values which are known at compile time and do not change for the life of the program. 
- Constants are declared with the **const** modifier. 
- Only the C# built-in types (excluding System.Object) may be declared as const. 
- User-defined types, including classes, structs, and arrays, cannot be const. 
- Use the **readonly** modifier to create a class, struct, or array that is initialized one time at run time (for example in a constructor) and thereafter cannot be changed.
    - *readonly* indicates that assignment to the field can only occur as part of the declaration or in a constructor in the same class. 
    - A readonly field can be assigned and reassigned multiple times within the field declaration and constructor.

## Programming Constructs
### [Selection Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements)
Select statements are to execute from many possible paths based on the value of an expression. Types of select statements:
* if - statement executes a statement only if a provided Boolean expression evaluates to true.
* if-else - statement allows you to choose which of the two code paths to follow based on a Boolean expression.
* switch -  statement selects a statement list to execute based on a pattern match with a match expression

### [Iteration Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements)
The iteration statements repeatedly execute a statement or a block of statements. Types of iteration statements
* do - statement conditionally executes its body one or more times.
* while - statement conditionally executes its body zero or more times.
* for - statement executes its body while a specified Boolean expression evaluates to true.
* foreach - statement enumerates the elements of a collection and executes its body for each element of the collection.

## [Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
 A method is a code block that contains a series of statements. 
 * A program causes the statements to be executed by calling the method and specifying any required method arguments. 
 * In C#, every executed instruction is performed in the context of a method.
 * The Main method is the entry point for every C# application and it's called by the common language runtime (CLR) when the program is started. 
 * In an application that uses [top-level statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements) ( .Net 6 and above versions), the Main method is generated by the compiler and contains all top-level statements.
 * A method in C# consists of :
    * **Method declaration** - Methods are declared in a class, struct, or interface by specifying the access level such as public or private, optional modifiers such as abstract or sealed, the return value, the name of the method, and any method parameters. These parts together are the signature of the method.
        * Method parameters are enclosed in parentheses and are separated by commas. Empty parentheses indicate that the method requires no parameters.
    * **Method body** - It is the the block which starts with `{` and ends with `}`
    * **Method parameters and arguments** - The method definition specifies the names and types of any parameters that are required. When calling code calls the method, it provides concrete values called arguments for each parameter. The arguments must be compatible with the parameter type.
### [Named and Optional Arguments](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments)
* **Named arguments** enable you to specify an argument for a parameter by matching the argument with its name rather than with its position in the parameter list.
* **Optional arguments** enable you to omit arguments for some parameters. 
* When you use named and optional arguments, the arguments are evaluated in the order in which they appear in the argument list, not the parameter list.

### [Method Overloading](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/member-overloading)
* Member overloading means creating two or more members on the same type that differ only in the number or type of parameters but have the same name. 
* Overloading is one of the most important techniques for improving usability, productivity, and readability of reusable libraries. 
* Overloading on the number of parameters makes it possible to provide simpler versions of constructors and methods. 
* Overloading on the parameter type makes it possible to use the same member name for members performing identical operations on a selected set of different types.
* Overloads of members can differ based on signatures:
    * different number of parameters.
    * different datatype of parameters.
    * different sequence of parameters.

### [Extension Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
* Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. 
* Extension methods are static methods, but they're called as if they were instance methods on the extended type. 
* For client code written in C#, F# and Visual Basic, there's no apparent difference between calling an extension method and the methods defined in a type.
* The parameter is preceded by the this modifier. 
* Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.

### [Arrays](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays)
- Used to store a datatype and have fixed sizes
- Zero-based index
    - 0 is the starting position of the array
- `Length` of an array consists of number of elements in an array
- *Elements* are the items inside the array.
- `Rank`is a property that returns the dimension of the arrat
- Types arrays you can make:
    - **Single Dimensional** arrays: `int[] marks = new int[5];`
    - **Multidimensional** arrays - `int[,] ex = new int[4,2];` would create [ [0, 0], [0, 0], [0, 0], [0, 0] ]. Multi rows and columns
    - **Jagged** arrays - `int[][] jagged = new int[3][];` arrays inside of an array are different sizes [ [0, 0, 0], [0, 0], [0, 0, 0], [0, 0 , 0, 0] ]

## What is Object-Oriented programming?
- It is a methodology we use to design our programs just using classes and objects
- It makes it a lot easier to develop and maintain your project as it gets bigger

### Classes
- They are templates that are used to create objects and define the object's functions and current state (essentially what information they currently store)

### Objects
- It is any entity that has a state and behavior
- They are made from classes and will copy whatever state and behavior the class has defined
- Classes are blueprints and Objects is the actual object from the blueprint
- Ex: A blueprint of a car, tells you how to make a car but it isn't the car itself (The Class) The multiple cars you make from same blueprint (The Objects of that Class)

### Pillars of OOP
- Encapsulation: Wrapping up of data and data hiding for data security. Access modifiers for data hiding and wrapping happens through, methods, classes, namespaces,properties to encapsulate data.
- Abstraction: Showing only essential features instead of unecessary details. Designing the project using interface and abstract classes is one of the examples of abstraction in C#.
- Inheritance : Parent child relationship to achieve specification from generalisation. Allows resuability by letting parent class features to be used by child class or even re-defining parent class features is Inheritance.
- Types of Inheritance
    - Single-level
    - multi-level/hierarichal
    - multiple inheritance is not permitted in C# with classes.
- Polymorphism - Poly means many, morphs means forms. Examples are method overloading and overiding.

### [Tuple types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples)
* The tuples feature provides concise syntax to group multiple data elements in a lightweight data structure. 
* To define a tuple type, you specify types of all its data members and, optionally, the field names. 
* You can't define methods in a tuple type, but you can use the methods provided by .NET.
* Tuple types support equality operators == and !=. 
    ```
    (int a, byte b) left = (5, 10);
    (long a, int b) right = (5, 10);
    Console.WriteLine(left == right);  // output: True
    Console.WriteLine(left != right);  // output: False

    var t1 = (A: 5, B: 10);
    var t2 = (B: 5, A: 10);
    Console.WriteLine(t1 == t2);  // output: True
    Console.WriteLine(t1 != t2);  // output: False
    ```
* Tuple types are value types; tuple elements are public fields that makes tuples mutable value types.
* One of the most common use cases of tuples is as a method with more than 1 return type. Then, you can work with the returned tuple instance directly or deconstruct it in separate variables.
* You can also use tuple types instead of [anonymous types](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types). 
* You explicitly specify tuple fields names in a tuple initialization expression or in the definition of a tuple type, as the following example shows:
    ```
    var t = (Sum: 4.5, Count: 3);
    Console.WriteLine($"Sum of {t.Count} elements is {t.Sum}.");

    (double Sum, int Count) d = (4.5, 3);
    Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");
    ```
* Tuple assignment and tuple equality comparisons don't take field names into account.
* *var* keyword can be used with tuples.
* **Tuple assignment and deconstruction**
    * C# supports assignment between tuple types that satisfy both of the following conditions:
        * both tuple types have the same number of elements
        * for each tuple position, the type of the right-hand tuple element is the same as or implicitly convertible to the type of the corresponding left-hand tuple element

## [Structures (struct) Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct)
It is a value type to encapsulate data and related functionality.
* *structs* are used to design small data centric types that provide little or no behavior.
* **Constructors** are used to initialize values to the stryct type.
    * A *constructor* is a special method of public which is used to initialize values to a type (class/struct). It can be *default, parameterless, parameterized*.
* Limitations with the design of a structure type
    * Structs have most of the capabilities of a class type. There are some exceptions, and some exceptions that have been removed in more recent versions:
        * A structure type can't inherit from other class or structure type and it can't be the base of a class. However, a structure type can implement interfaces.
        * You can't declare a finalizer within a structure type.
        * Prior to C# 11, a constructor of a structure type must initialize all instance fields of the type.
        * Prior to C# 10, you can't declare a parameterless constructor.
        * Prior to C# 10, you can't initialize an instance field or property at its declaration.

## Access Modifiers in C#
They provide accessibility control to the types ans type members. Through access modifiers one can achieve *data hiding* (encapsulation) in the program.
Types of access modifiers:
1. public 
2. private
3. protected
4. internal
5. protected internal
5. private protected

## [Properties](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they're public data members, but they're special methods called accessors. This feature enables data to be accessed easily and still helps promote the safety and flexibility of methods.
* Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code.
* A *get* property accessor is used to return the property value, and a *set* property accessor is used to assign a new value. 
* The value keyword is used to define the value being assigned by the set or init accessor.
Properties can be read-write (they have both a get and a set accessor), read-only (they have a get accessor but no set accessor), or write-only (they have a set accessor, but no get accessor). 
* Write-only properties are rare and are most commonly used to restrict access to sensitive data.

### [enum/Enumerations](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
It is a value type defined by a set of named constants with underlying numeral type.

### [Class Library](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0)
A class library defines types and methods that are called by an application. 
* If the library targets .NET Standard 2.0, it can be called by any .NET implementation (including .NET Framework) that supports .NET Standard 2.0. 

## [Collections](https://docs.microsoft.com/en-us/dotnet/standard/collections/)
- Similar data can often be handled more efficiently when stored and manipulated as a collection. 
- You can use arrays, non-generic or generics.
- Arrays have fixed size and every element must have a value if no value is provided it contains the default.
- Arrays cannot be grown or shrinked. This where collection solves the problem.
- C# offers 2 categories of Collections:
    - non-generics
    - generics
- **Non-generic** collections store items as Object, require casting. Performance concerns were arised due to this casting and also Garbage Collection.
- **Generic collections** are type-safe at compile time. Because of this, generic collections typically offer better performance. 
    - Generic collections accept a type parameter when they are constructed and do not require that you cast to and from.
    - The "T" you see in documentation is where you put what data type that collection will hold
- All collections provide methods for adding, removing, or finding items in the collection.
- All collections can be **enumerated** by virtue of **Enumerator**.
- An enumerator can be thought of as a movable pointer to any element in the collection.
- Types of Generic Collections:
    - Stack<T>
        - LIFO - It is a Last-in, First-out list
        - Major Operations 
            - Push - Add element into stack
            - Pop - Remove an element from TOP
            - Peek - Retrieve the TOP element 
    - Queue<T>
        - FIFO - A first-in, first-out list
        - Major Operations
            - Enqueue - Add element into Queue
            - Dequeue - Remove element from Queue
            - Peek - Retrieve the TOP element 
    - List<T> 
        - Like any array which can grow and shrink dynamically.
        - Items in the list can be accessed by index.
        - It can accept null as a valid value for reference types and it also allows duplicate elements.
        - List<T> class is not sorted by default and elements are accessed by zero-based index.
        - Properties
            - Capacity - Gets or sets the total number of elements the internal data structure can hold without resizing.
            - Count - Gets the number of elements contained in the List<T>
        - Methods:
            - Add(T) - Adds an object to the end of the List<T>
            - Clear() - Removes all elements from the List<T>
            - Insert(index, T) - Inserts an element into the List<T> at the specified index
            - Remove(T) -	Removes the first occurrence of a specific object from the List<T>
            - RemoveAt(index) - Removes the element at the specified index of the List<T>
            - Reverse() -	Reverses the order of the elements in the List<T> or a portion of it
    - HashSet<T>
        - It is an unordered collection of the unique elements. 
        - It prevent duplicates from being inserted in the collection.
    - Dictionary<Tkey,TValue> 
        - It stores key/value pairs
        - Keys must be Unique
    - SortedList<TKey,TValue>
        - It is a sorted list of key/value pairs 
    - LinkedList<T> 
        - It allows fast inserting and removing of elements. It implements a classic linked list.
        - Each element is separately allocated.
        - Properties:
            - Count -	Gets the number of nodes actually contained in the LinkedList.
            - First -	Gets the first node of the LinkedList.
            - Last - Gets the last node of the LinkedList.
        - Methods:
            - AddFirst - Adds a new node or value at the start of the LinkedList.
            - AddLast -	Adds a new node or value at the end of the LinkedList.
            - Clear() -	Removes all nodes from the LinkedList.
            - Contains(T) -	Determines whether a value is in the LinkedList.
            - Remove(LinkedListNode) - Removes the specified node from the LinkedList.
            - Remove(T) - Removes the first occurrence of the specified value from the LinkedList.
            - RemoveFirst() - Removes the node at the start of the LinkedList.
            - RemoveLast() - Removes the node at the end of the LinkedList.
### [LINQ - Language Integrated Query](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)
- Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of *query capabilities* directly into the C# language.
- Previously, you have to learn a different query language for each type of data source: SQL databases, XML documents, various Web services, and so on and these queries against data are expressed as simple strings without type checking at compile time or IntelliSense support. LINQ solved all this problem by providing simple query based expression.
- A *query* is an expression that retrieves data from a data source.
- You can use LINQ in 2 ways:
    1. *Query Syntax* - its similar to sql query fashion that can be used for filtering, ordering, grouping operations on data sources woth minimal code.
    - All LINQ query operations consist of three distinct actions:
        - Obtain the data source.
        - Create the query.
        - Execute the query.
    - The complete operation includes creating a data source, defining the query expression, and executing the query in a foreach statement.
    - Query expressions are easy to grasp because they use many familiar C# language constructs.
    - The variables in a query expression are all strongly typed, although in many cases you do not have to provide the type explicitly because the compiler can infer it.
    - A query is not executed until you iterate over the query variable like iterarting over foreach statement.
    - A *query expression* is a query expressed in query syntax.
        - A query expression consists of a set of clauses written in a declarative syntax similar to SQL. 
        - Each clause in turn contains one or more C# expressions, and these expressions may themselves be either a query expression or contain a query expression.
        - A query expression must begin with a `from` clause and must end with a `select` or `group` clause.
        - Between the first from clause and the last select or group clause, it can contain one or more of these optional clauses: where, orderby, join, let and even additional from clauses. 
    - Given the data source a query can return:
        - Retrieve a subset of the elements to produce a new sequence without modifying the individual elements. 
            ```
            IEnumerable<int> highScoresQuery =
            from score in scores
            where score > 80
            orderby score descending
            select score;
            ```
        - Retrieve a sequence of elements as in the previous example but transform them to a new type of object.
            ```
            IEnumerable<string> highScoresQuery2 =
            from score in scores
            where score > 80
            orderby score descending
            select $"The score is {score}";
            ```
        - Retrieve a singleton value about the source data, such as:        
            - The number of elements that match a certain condition.            
            - The element that has the greatest or least value.            
            - The first element that matches a condition, or the sum of particular values in a specified set of elements.
             ```
            int highScoreCount = (
            from score in scores
            where score > 80
            select score
            ).Count();
            ```
           
    2. *Method Syntax* - Some queries must be expressed as method calls. 
        - For example, you must use a method call to express a query that retrieves the number of elements that match a specified condition.
        ```
                IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

                //Method syntax:
                IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);
        ```
        - There are many other methods such as Select, SelectMany, Join, and Orderby in method based syntax. All these methods are extension methods to System.Linq library.
        - the conditional expression `(num % 2 == 0)` is passed as an in-line argument to the Where method: `Where(num => num % 2 == 0)`. This inline expression is called a **lambda expression**.
            -  *Lambda Expression* is a convenient way to write code that would otherwise have to be written in more cumbersome form as an anonymous method or a generic delegate or an expression tree. 
            - In C# `=>` is the lambda operator, which is read as `"goes to"`. 
            - The `num` on the left of the operator is the input variable which corresponds to `num` in the query expression. 
            - The body of the lambda is just the same as the expression in query syntax or in any other C# expression or statement; it can include method calls and other complex logic. 
            - The "return value" is just the expression result.
       
- [LINQ Activity](https://www.w3resource.com/csharp-exercises/linq/index.php)
- **Coding challenge ion collection and LINQ**
    - Create a class library named **StudentLib** which has an object of type Student. Student object has:
        - ID, firstName, lastName, date of birth (try using DateTime), stream (political science, arts, commerce, science), city, gender
        - Add any random 5 students in a collection of your choice.
        - Create a method to iterate over all students and call it in the Main project named **StudentUI**.
        - Take input from user to Add a new student with Id = 6, firstName = "Jammy". lastName="Bracket", Date of birth = 7/11/1998, stream = science, gender = male, city = "London".
        - Take input from user as an id = 3 and remove student with id =3 
        - write a Query for students who are from science stream
        - write a query for filtering all females from science stream
        - write a query where student is between age range 16 to 22.
## [Interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces)
* Best way to achieve abstraction in C# in the purest form.
* By definition an interface is a contract which is shared among the classes (structs well) and these implementing classes must implement the members of an interface.
* An interface contains definitions for a griup of related functionalities that a non-abstract class or struct must implement. 
* A class allows to implement multiple interfaces at a time  by which one can include behavior from multiple sources in a class.
* Interfaces can contain instance methods, properties, events, indexers, or any combination of those four member types.

* [**IComparable and IComparer**](https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/use-icomparable-icomparer)
    * **IComparable**: The role of IComparable is to provide a method of comparing two objects of a particular type. It's necessary if you want to provide any ordering capability for your object. Think of IComparable as providing a default sort order for your objects. For example, if you have an array of objects of your type, and you call the Sort method on that array, IComparable provides the comparison of objects during the sort. When you implement the IComparable interface, you must implement the `CompareTo` method.
        * `CompareTo` -Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. Returns a value that indicates the relative order of the objects being compared. The
        return value has these meanings:
            * Less than zero – This instance precedes obj in the sort order.
            * Zero – This instance occurs in the same position in the sort order as obj.
            * Greater than zero – This instance follows obj in the sort order.
    - **IComparer**: The role of IComparer is to provide more comparison mechanisms. For example, you might want to provide ordering of your class on several fields or properties, ascending and descending order on the same field, or both.Using IComparer is a two-step process. First, declare a class that implements IComparer, and then implement the `Compare` method.The second step is to declare a method that returns an instance of your `IComparer` object.
- There are some more interfaces which are commonly used in C# programming:
    - `IEnumerable/IEnumerable<T>` - enumerates through a collection using `foreach` loop.
        - `foreach` loop works for any collection which implements `System.Collections.IEnumerable` or `System.Collections.Generic.IEnumerable<T>`
        - What is an enumerator? It is simply a pointer that tells to `movenext` until the last item is encountered.
    - `ICollection` - implemented by all collections to provide `CopyTo`, `Count` operations etc....
    - `IList` - Used by array type of collections. Ex - Arrays, List, List<T>, Dictionar
    - `IDictionary` - for key/valye based collections. Ex - Hashtable, SortedList, Dictionary
    - `IDictionaryEnumerator` - allows enumeration with foreach loop for a collection that supports `IDictionary`.

- [Custom collections](https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/implement-custom-collection)
    - create a custom collection as assigend to you
    - Implement methods to add and remove from the collection
    - Show demo with addition, removal of elements and iteration (extra mile filteration using LINQ)
    - Try not to use inbuilt C# method to ease your job.
## [Generics](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-type-parameters) - Parameterized types
Generics introduces the concept of type parameters to .NET, which make it possible to design classes and methods that defer the specification of one or more types until the class or method is declared and instantiated by client code. 
* For example, by using a generic type parameter T, you can write a single class that other client code can use without incurring the cost or risk of runtime casts or boxing operations.
* Generic classes and methods combine:  
    * Reusability
    * Type safety
    * Efficiency
    * Performance
* You can also create custom generic types and methods to provide your own generalized solutions and design patterns that are type-safe and efficient.
* You can create your own generic interfaces, classes, methods, events, and delegates.
    * [Generic Classes](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes) - Generic classes encapsulate operations that are not specific to a particular data type. The most common use for generic classes is with collections like linked lists, hash tables, stacks, queues, trees, and so on.
    * [Generic Interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-interfaces) - To avoid boxing and unboxing operations on value types, it's better to use generic interfaces, such as IComparable<T>, on generic classes. The .NET class library defines several generic interfaces for use with the collection classes in the System.Collections.Generic namespace.
    * [Generic methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods) - A generic method is a method that is declared with type parameters, this makes methods reusable and applies to the all datatypes unless constrained to a particular type.
* Generic classes may be **constrained** to enable access to methods on particular data types.
    * [Constraints](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters) inform the compiler about the capabilities a type argument must have, they specify the capabilities and expectations of a type parameter.
    * Without any constraints, the type argument could be any type. 
    * Declaring those constraints means you can use the operations and method calls of the constraining type. 
    * If client code uses a type that doesn't satisfy a constraint, the compiler issues an error. 
    * Constraints are specified by using the `where` contextual keyword. 
        * Ex - `where T : struct`


## [Exceptions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/)
- An exception is an event that occurs during the execution of a program that distrupts the normal flow of instructions
    - Horrible to encounter when presenting your program (When it is expected to work perfectly fine)
    - Great when trying to find bugs in your program
- They are not Errors!
#### Errors
- A serious problem that for the most part cannot be handled by the developer
    -They are fatal to the program at runtime
    - Ex: A stack overflow error and that usually occurs when your computer has run out of memory to store information
- 3 types of errors
    - Usage error - error in your program logic and can be solve by modifying/restructuring your code
    - Program Error - run-time error that cannot be avoided even with a bug-free code (Ex: Your SDK is corrupt and can't compile or translate it to machine code properly)
    - System Failures - run-time error that cannot be handled programmatically in a meaninful way (Ex: your ram hardware is faulty)
#### [Exception Handling](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/)
- Using a `try`-`catch` block and optionally `finally` block
- If you know the block of code you will run will have a risk of throwing an exception, you should put it in the try block
- The catch block will then "catch" that exception and will run instead its block of code
    - Once an exception occurs in the try block, the flow of control jumps to the first associated exception handler that is present anywhere in the call stack. In C#, the catch keyword is used to define an exception handler.
    - If no exception handler for a given exception is present, the program stops executing with an error message.
    - Don't catch an exception unless you can handle it and leave the application in a known state. 
- Optionally, you can add a `finally` block that will run regardless if your code throws an exception or not
    - Mostly used to clean up any resources you used in the try blcok
#### Throwing Exception
- You can throw an exception yourself in your code by using the `throw` keyword
- Useful for enforcing certain rules/logic in your program
#### Exception Heirarchy
- Certain exceptions are more specific than other exceptions
- General rule is the most specific exception should be the very first catch block and the least specific exception is at the very last catch block
    - Why? Well if you made the least specific the first catch block then it will always run if any exception is thrown making your other catch blocks useless

## [Debugging in .Net](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/)
Software doesn't always behave as you would expect, but .NET Core has tools and APIs that will help you diagnose these issues quickly and effectively.
* Debuggers allow you to interact with your program. Pausing, incrementally executing, examining, and resuming gives you insight into the behavior of your code. A debugger is a good choice for diagnosing functional problems that can be easily reproduced.
* 2 configurations of .Net - `debug` and `release` are the built-in .Ner configurations. 
    * Debug - you use debug configuration for debugging 
    * Release - you use release configuration for release distribution

* A *breakpoint* temporarily interrupts the program execution before the line with the breakpoint is run.
    * *Step into* - press `F11` - to inspect  inside of the program block
    * *Step over* - press `F10` - to inspect outside the program block
    * *Step out* - press `shift + F11` to step out of the current breakpoint
* One can use other [diagnostics](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/) tools 
    * Unit testing 
    * Instrumentation using 3 pillars of observability
        * metrics - [Metrics](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/metrics) are numerical measurements recorded over time to monitor application performance and health.
            * Metrics are often used to generate alerts when potential problems are detected. 
            * Metrics have very low performance overhead and many services configure them as always-on telemetry. 
            * Exceptions are often recorded as metrics, and can be summarized to reduce the cardinality of the data.
        * logs - [Logging](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/logging-tracing) is a technique where code is instrumented to produce a log, a record of interesting events that occurred while the program was running. 
            * Eg: log every event occuring in the program using apis like `NLog`, `SeriLlog` or `Ilogger` interface implementation.
            * Performance overhead is variable depending on how much data is being logged.
        * distributed traces - [Distributed Tracing](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/distributed-tracing) is a specialized form of logging that helps you localize failures and performance issues within applications distributed across multiple machines or processes. 
            * This technique tracks requests through an application correlating together work done by different application components and separating it from other work the application may be doing for concurrent requests. 
            * It is possible to trace every request and sampling can be optionally employed to bound the performance overhead.
    * There are multiple ways that the instrumentation data can be egressed from the application, including:
        * OpenTelemetry - a cross-platform, vendor-neutral standard for collecting and exporting telemetry
        * .NET CLI tools such as dotnet-counters
        * dotnet-monitor - an agent for collecting traces and telemetry
        * Third-party libraries or app code can read the information

## [static](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)
`static` can be applied to types (class, structs, interfaces), members of types (methods, variables, properties etc...)
* A static class can only have static members.
* static class cannot be inherited, static methods cannot be overrided.
* You cannot use `this` keyword with static methods.
* static classes can have static constructors. 
    * A static constructor is a called at some point between when the program starts and class is initiated.
# [Garbage Collector and Destructor in C#](https://www.pluralsight.com/guides/destructors-uncertainty-of-destructive)
Creating objects in C# means that the CLR(Common Language Runtime) allocates memory from the heap to be used by the object. 
* This is repeated for each consecutive object creation.The limit is theoretically the available memory in the system. 
* This means there is a limit, and we need to consider other applications that may need to use these resources. 
* The memory needs to be released every once in a while, when the application does not need it anymore.
* *The garbage collector is the internal mechanism of CLR that's sole purpose is to free up those resources which are not needed anymore, but were once reserved by the applications themselves.*
* The Garbage Collector aka **GC** runs automatically but we can call it explicitly by `GC.Collect()` method or by destructors aka `finalizers`
* The **destructor** is a concept similar to constructors. 
    * While the goal of the constructor is to reserve resources for the object of a specific class.The destructors’ goal is to free those resources. 
    * The destructors are strongly coupled with the garbage collector.
    * When you use destructor keep in mind the following:
       * The structs cannot have finalizers, only classes can.
       * Only one finalizer is permitted.
       * The finalizers cannot be inherited or overloaded.
       * The finalizers cannot be called.
       * The finalizers cannot take modifiers or parameters.
       * destructor cannot be used with static classes.
    ```
    class Employee
    { 
    // members and methods.
    // Destructor or Finalizer
        ~Employee()
        {
            Console.WriteLine("No longer with us!");
        }
    } 
    ```
* There is a concept called *Generation* which reveals to us the inner workings of garbage collection. There are three generations which separate different kinds of objects into distinct categories
    * Generation (Zero) - Holds short-lived objects, temporary objects; the garbage collector is the most frequent in this realm.
    * Generation (One) - A buffer between Zero and Two. The objects which are not collected at Zero are moved to One, these are called survivors. 
    * Generation (Two) - Holds the long-lived objects like static and global variables that need to persist for a certain amount of time. Then the objects which are not collected at One arrive at Two. This is the final realm an object can reach.
* When it comes to GC it is important to know about **managed objects** and **unmanaged objects**
    * **managed** object when this object is under the scope of CLR; it's pure .NET code which is managed by runtime. 
        * Anything which comes from .NET like classes, basic data structures like strings, integers, etc... are referred to as managed code.
    * **unmanaged** objects when the object is outside of the control of the .NET libraries and not managed by the CLR. 
        * These are objects like COM objects, file and network streams, connections objects, etc...
        * unmanaged objects when the object is outside of the control of the .NET libraries and not managed by the CLR. 
        * These are objects like COM objects, file and network streams, connections objects, etc...
        * Ways to clean up unmanaged code:
            * Implementing the `IDisposable` interface and `Dispose` of method.
            * `'using'` block or statement
## Serialization and Deserialization
- Serialization is the process of converting an object into a form that can be readily transported. For example, you can serialize an object and transport it over the Internet using HTTP between a client and a server. 
- On the other end, deserialization reconstructs the object from the stream.
- The most common formats of serializations are:
    - [XML](https://docs.microsoft.com/en-us/dotnet/standard/serialization/introducing-xml-serialization): XML serialization serializes only the public fields and property values of an object into an XML stream. 
        - You can use `XMLSerializer` class to serialize your objects.
        - The following items can be serialized using the XmlSerializer class:
            - Public read/write properties and fields of public classes.
            - Classes that implement ICollection or IEnumerable.
    - [JSON](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/overview):The System.Text.Json library design emphasizes high performance and low memory allocation over an extensive feature set. Built-in UTF-8 support optimizes the process of reading and writing JSON text encoded as UTF-8, which is the most prevalent encoding for data on the web and files on disk. What can you serialize:
        - NET primitives that map to JavaScript primitives, such as numeric types, strings, and Boolean.
        - User-defined plain old CLR objects (POCOs).
        - One-dimensional and jagged arrays (T[][]).
        - Collections and dictionaries
       -  Industries use [NewtonSoft](https://www.newtonsoft.com/json) for working with large data serialization ad serialization process.
### Messaging format 
| C#                            |         xml                        |   Json                           |
|-------------------------------|------------------------------------|----------------------------------|
| class Employee                |`<Employee>`                        | Employee                         |
|   {                           |   `<name>"Joe</name>`              |  {                               |
|       string name="Joe";      |   `<id>1</id>`                     |      "name":"Joe",               |
|       int id = 1;             |   `<city>"London"</city>`          |      "id":1,                     |
|       string city = "London"  |   `<gender>'M'</gender>`           |      "city":"London",            |
|       char gender = 'M';      |   `<salary>120</salary>`           |      "gender":"M",               |
|       decimal salary = 120.0M;|`</employee>`                       |      "salary":120                |
|                               |                                    |  }                               |
|   }                           |                                    |                                  |
## [File Handling](https://www.knowledgehut.com/tutorials/csharp/csharp-file-handling)
- **Stream**: **System.IO.Stream** is an abstract class that provides standard methods to transfer bytes (read, write, etc.) to the source. 
    - It is like a wrapper class to transfer bytes. 
    - Classes that need to read/write bytes from a particular source must implement the Stream class.
    - The following classes inherit Stream class to provide the functionality to Read/Write bytes from a particular source:
        - **FileStream** reads or writes bytes from/to a physical file, whether it is a .txt, .exe, .jpg, or any other file. FileStream is derived from the Stream class.
        - **MemoryStream**: MemoryStream reads or writes bytes that are stored in memory.
        - **BufferedStream**: BufferedStream reads or writes bytes from other Streams to improve certain I/O operations' performance.
        - **NetworkStream**: NetworkStream reads or writes bytes from a network socket.
- **Stream Readers and Writers**
    - **StreamReader**: StreamReader is a helper class for reading characters from a Stream by converting bytes into characters using an encoded value. It can be used to read strings (characters) from different Streams like FileStream, MemoryStream, etc.
    - **StreamWriter**: StreamWriter is a helper class for writing a string to a Stream by converting characters into bytes. It can be used to write strings to different Streams such as FileStream, MemoryStream, etc.
    - **BinaryReader**: BinaryReader is a helper class for reading primitive datatype from bytes.
    - **BinaryWriter**: BinaryWriter writes primitive types in binary.
- **System.IO** namespace provides four classes that allow you to manipulate individual files, as well as interact with a machine directory structure.
- The **Directory** and **File** directly extends System.Object and supports the creation, copying, moving and deletion of files using various static methods.
    -  They only contain static methods and are never instantiated.
- The **FileInfo** and **DirectoryInfo** types are derived from the abstract class **FileSystemInfo** type and they are typically, employed for obtaining the full details of a file or directory because their members tend to return strongly typed objects.
    - They implement roughly the same public methods as a Directory and a File but they are stateful and the members of these classes are not static.

## [Indexers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/)
Indexers allow instances of a class or struct to be indexed just like arrays. 
- Indexers are like properties except that their accessors take parameters
# References:
- [.Net Implementations](https://learn.microsoft.com/en-in/dotnet/fundamentals/implementations)
- [.Net glossary](https://learn.microsoft.com/en-in/dotnet/standard/glossary)
- [.Net version releases](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
- [C# Operators and Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
- [C# Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/statement-keywords)
- [Interfaces](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
- [Debugging in .Net](https://learn.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0)
- [Garbage Collection Fundamentals](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)
- [Stream](https://www.tutorialsteacher.com/csharp/csharp-stream-io)
- [File](https://www.tutorialsteacher.com/csharp/csharp-file)
- [FileInfo](https://www.tutorialsteacher.com/csharp/csharp-fileinfo)

