# The history of C# and .NET

...is about new features in .NET and C#

## Overview

| C# Version | .NET Version                         | Visual Studio           | Release Date   |
| ---------- | ------------------------------------ | ----------------------- | -------------- |
| 1.0        | .NET Framework 1.0                   | Visual Studio .NET 2002 | January 2002   |
| 1.2        | .NET Framework 1.1                   | Visual Studio .NET 2003 | April 2003     |
| 2.0        | .NET Framework 2.0                   | Visual Studio 2005      | November 2005  |
| 3.0        | .NET Framework 3.5                   | Visual Studio 2008      | November 2007  |
| 4.0        | .NET Framework 4.0                   | Visual Studio 2010      | April 2010     |
| 5.0        | .NET Framework 4.5.x                 | Visual Studio 2012      | August 2012    |
| 6.0        | .NET Framework 4.6.x                 | Visual Studio 2015      | July 2015      |
| 7.0        | .NET Framework 4.7.x                 | Visual Studio 2017      | March 2017     |
| 7.1        | .NET Core 2.0                        | Visual Studio 2017      | August 2017    |
| 7.2        |                                      | Visual Studio 2017      | November 2017  |
| 7.3        | .NET Core 2.x und .NET Framework 4.8 | Visual Studio 2017      | May 2018       |
| 8.0        | .NET Core 3.x                        | Visual Studio 2019      | September 2019 |
| 9          | .NET 5.x                             | Visual Studio 2019      | November 2020  |
| 10         | .NET 6.x                             | Visual Studio 2022      | November 2021  |
| 11         | .NET 7.x                             | Visual Studio 2022      | November 2022  |
| 12         | .NET 8.x                             | Visual Studio 2022      | November 2023  |
| 13         | .NET 9.x                             | Visual Studio 2022      | November 2024  |
| 14         | .NET 10.x                            | Visual Studio 2022      | November 2025  |

## Most important features and their versions

## C# version 14

Features:

To come

## [C# version 13](./Ver9/README.md)

Features:

- params collections: the params modifier isn't limited to array types. You can now use params with any recognized collection type, including Span&lt;T&gt;, and interface types.
- New lock type and semantics: If the target of a lock statement is a System.Threading.Lock, compiler generates code to use the Lock.EnterScope() method to enter an exclusive scope. The ref struct returned from that supports the Dispose() pattern to exit the exclusive scope.
- New escape sequence - \e: You can use \e as a character literal escape sequence for the ESCAPE character, Unicode U+001B.
- Small optimizations to overload resolution involving method groups.
- Implicit indexer access in object initializers: The implicit "from the end" index operator, ^, is now allowed in an object initializer expression.
- You can use ref locals and unsafe contexts in iterators and async methods.
- You can use ref struct types to implement interfaces.
- You can allow ref struct types as arguments for type parameters in generics.
- Partial properties and indexers are now allowed in partial types.
- Overload resolution priority allows library authors to designate one overload as better than others.

## C# version 12

Features:

- Primary constructors - You can create primary constructors in any class or struct type.
- Collection expressions - A new syntax to specify collection expressions, including the spread element, (..e), to expand any collection.
- Inline arrays - Inline arrays enable you to create an array of fixed size in a struct type.
- Optional parameters in lambda expressions - You can define default values for parameters on lambda expressions.
- ref readonly parameters - ref readonly parameters enables more clarity for APIs that might be using ref parameters or in parameters.
- Alias any type - You can use the using alias directive to alias any type, not just named types.
- Experimental attribute - Indicate an experimental feature.

"Interceptors" was released as a Preview feature.

## C# version 11

Features:

- Raw string literals
- Generic math support
- Generic attributes
- UTF-8 string literals
- Newlines in string interpolation expressions
- List patterns
- File-local types
- Required members
- Auto-default structs
- Pattern match Span&lt;char&gt; on a constant string
- Extended nameof scope
- Numeric IntPtr
- ref fields and scoped ref
- Improved method group conversion to delegate
- Warning wave 7

## C# version 10

Features:

- Record structs
- Improvements of structure types
- Interpolated string handlers
- global using directives
- File-scoped namespace declaration
- Extended property patterns
- Lambda expressions can have a natural type, where the compiler can infer a delegate type from the lambda expression or method group.
- Lambda expressions can declare a return type when the compiler can't infer it.
- Attributes can be applied to lambda expressions.
- In C# 10, const strings can be initialized using string interpolation if all the placeholders are themselves constant strings.
- In C# 10, you can add the sealed modifier when you override ToString in a record type.
- Warnings for definite assignment and null-state analysis are more accurate.
- Allow both assignment and declaration in the same deconstruction.
- Allow AsyncMethodBuilder attribute on methods
- CallerArgumentExpression attribute
- C# 10 supports a new format for the #line pragma.

## [C# version 9](./Ver5/README.md)

Features:

- Records
- Init only setters
- Top-level statements
- Pattern matching enhancements:  
  relational patterns and logical patterns
- Performance and interop
  - Native sized integers
  - Function pointers
  - Suppress emitting localsinit flag
  - Module initializers
  - New features for partial methods
- Fit and finish features
  - Target-typed new expressions
  - static anonymous functions
  - Target-typed conditional expressions
  - Covariant return types
  - Extension GetEnumerator support for foreach loops
  - Lambda discard parameters
  - Attributes on local functions

## C# version 8.0

Features:

- Readonly members
- Default interface methods
- Pattern matching enhancements:
  - Switch expressions
  - Property patterns
  - Tuple patterns
  - Positional patterns
- Using declarations
- Static local functions
- Disposable ref structs
- Nullable reference types
- Asynchronous streams
- Indices and ranges
- Null-coalescing assignment
- Unmanaged constructed types
- Stackalloc in nested expressions
- Enhancement of interpolated verbatim strings

## C# version 7.3

Features:

- better performance for safe code
  - You can access fixed fields without pinning.
  - You can reassign ref local variables.
  - You can use initializers on stackalloc arrays.
  - You can use fixed statements with any type that supports a pattern.
  - You can use more generic constraints.
- improvements to existing features
  - You can test == and != with tuple types.
  - You can use expression variables in more locations.
  - You can attach attributes to the backing field of automatically implemented properties.
  - Method resolution when arguments differ by in was improved.
  - Overload resolution now has fewer ambiguous cases.

## C# version 7.2

Features:

- Initializers on stackalloc arrays.
- Use fixed statements with any type that supports a pattern.
- Access fixed fields without pinning.
- Reassign ref local variables.
- Declare readonly struct types, to indicate that a struct is immutable and should be passed as an in parameter to its member methods.
- Add the in modifier on parameters, to specify that an argument is passed by reference but not modified by the called method.
- Use the ref readonly modifier on method returns, to indicate that a method returns its value by reference but doesn't allow writes to that object.
- Declare ref struct types, to indicate that a struct type accesses managed memory directly and must always be stack allocated.
- Use more generic constraints.
- Non-trailing named arguments:  
  Positional arguments can follow named arguments.
- Leading underscores in numeric literals:  
  Numeric literals can now have leading underscores before any printed digits.
- private protected access modifier:  
  The private protected access modifier enables access for derived classes in the same assembly.
- Conditional ref expressions:  
  The result of a conditional expression (?:) can now be a reference.

## C# version 7.1

Features:

- [language version selection](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version)
- async Main method
- default literal expressions  
   You can use default literal expressions in default value expressions when the target type can be inferred.
  Inferred tuple element names
  The names of tuple elements can be inferred from tuple initialization in many cases.
- Pattern matching on generic type parameters  
  You can use pattern match expressions on variables whose type is a generic type parameter.

## C# version 7.0

Features:

- Out variables
- Tuples and deconstruction
- Pattern matching
- Local functions
- Expanded expression bodied members
- Ref locals
- Ref returns
- Discards
- Binary Literals and Digit Separators
- Throw expressions

## C# version 6.0

Features:

- Static imports
- Exception filters
- Auto-property initializers
- Expression bodied members
- Null propagator
- String interpolation
- nameof operator

## C# version 5.0

Features:

- Asynchronous members
- Caller info attributes

## C# version 4.0

Features:

- Dynamic binding
- Named/optional arguments
- Generic covariant and contravariant
- Embedded interop types

## C# version 3.0

Features:

- Auto-implemented properties
- Anonymous types
- Query expressions
- Lambda expressions
- Expression trees
- Extension methods
- Implicitly typed local variables
- Partial methods
- Object and collection initializers

## C# version 2.0

Features:

- Generics
- Partial types
- Anonymous methods
- Nullable value types
- Iterators
- Covariance and contravariance

## C# version 1.2

Features:

- Call of `Dispose()` in an `foreach`-loop if IEnumerator implements IDisposable

## C# version 1.0

Released: January 2002

Features:

- Classes
- Structs
- Interfaces
- Events
- Properties
- Delegates
- Operators and expressions
- Statements
- Attributes

### By Feature

## Resources from Microsoft

- [What's new in .NET](https://learn.microsoft.com/en-us/dotnet/whats-new/)
- [What's new in C#](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/)
- [C# Language Design](https://github.com/dotnet/csharplang)

[Version history](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history)

- [C# Version 13](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-13)
- [C# Version 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-12)
- [C# Version 11](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-11)
- [C# Version 10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-10)
- [C# Version 9](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-9)
- [C# Version 8.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-8)
- [C# Version 7.3](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-73)
- [C# Version 7.2](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-72)
- [C# Version 7.1](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-71)
- [C# Version 7.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-70)
- [C# Version 6.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-60)
- [C# Version 5.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-50)
- [C# Version 4.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-40)
- [C# Version 3.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-30)
- [C# Version 2.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-20)
- [C# Version 1,2](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-12-1)
- [C# Version 1.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-10-1)

## Externa Ressources

[Wikipedia](<https://en.wikipedia.org/wiki/C_Sharp_(programming_language)>)
