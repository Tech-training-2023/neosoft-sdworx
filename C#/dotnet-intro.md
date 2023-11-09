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
# References:
- [.Net Implementations](https://learn.microsoft.com/en-in/dotnet/fundamentals/implementations)
- [.Net glossary](https://learn.microsoft.com/en-in/dotnet/standard/glossary)
- [.Net version releases](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
- [ C# Operators and Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
- [C# Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/statement-keywords)
- [Methods]()
