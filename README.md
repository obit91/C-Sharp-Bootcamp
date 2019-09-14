# C# .NET-Core Bootcamp
## Introduction
As an experienced Java/Python developer, undertaking the challenge of learning C#, I've decided to create this project in order to achieve two goals:

1. Exercise C# specific capabilities such as: string interpolation, ref & out, null coalscing, structs and more.
2. Document the process of my training, in order to save time in the future when-ever I need a reference.

## Notes
Most of the comparisons will be with Java, so if not mentioned otherwise, Java it is.

### Strings
The following examples will result in: "varA: <a's value>, varB: <b's-value>" assuming 'a' & 'b' are variables.
* Strings can be interpolated like so: $"varA: {a}, varB: {b}"
* Strings can be generated via String.Format("varA: {0}, varB: {1}", a, b)

String.Format can also be used to format the output string:
* Assume that 'date' is a DateTime variable.
* String.Format("The time is: {0:t} and the date is: {0:D}", date)

### Structures
Main differences between structures and classes:
* Classes are reference type whilst structs are value type.
* Structures do not support inheritance.
* Structures have an auto-generated default constructor.
* Structures can be assigned without the New operator,  however they will not be accessible until all fields have been set.

### Inheritance
* Parent constructor initialization from derived class: super() <-> base()
* Destructors cann be defined similar to constructors, along with a prefix ~ before the method name.
* There can only be one parent class, however multiple interfaces can be used as parents.
* Initialization lists are supported: public ChildClass(double l, double w) : base(l, w) { ... }

### Static Polymorphism
A term used to describe overloading functions.

### Dynamic Polymorphism
A term used to describe polymorphism within classes.
* Methods can be overriden only if the parent class's method is either: abstract, virtual or overriden.
* Abstract methods must be implemented, similar to Java.
* Parent virtual methods withhold an implementation, which <b>can</b> be overriden.
* The override modifier must be used whenever overriding.

## Useful Resources
Tutorial sites:
* [Tutorialsponts](https://www.tutorialspoint.com/csharp/)
* [Microsoft](https://docs.microsoft.com/en-us/dotnet/csharp/)
