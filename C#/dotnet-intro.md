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
Namespaces - logical grouping of related types to avoid namespace conflict, helps in project/app packaging and versioning 
    - Types - class, struct, interface, delegates, enums, records
        - Type members - variables, fields, methods, events, properties etc....

## Microsoft .NET language
Microsoft offers 3 languages on the .NET platform – C#, F# and Visual Basic. But .Net has support of more .Net compliant languages.
# References:
- https://learn.microsoft.com/en-in/dotnet/fundamentals/implementations
- https://learn.microsoft.com/en-in/dotnet/standard/glossary
- [.Net version releases](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
