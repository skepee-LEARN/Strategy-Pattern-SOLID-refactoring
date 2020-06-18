# C# Design Pattern migration example

## Description
This is a simple example of how to use C# Strategy Pattern step by step. 
The repository contains three different solutions and all the solutions work perfectly with the same expected result. Scope of this repository is to show how to refactor code by using Strategy Pattern [info](https://www.dofactory.com/net/strategy-design-pattern).

Let us see in detail:
* Mandate Basic: basic code
* Mandate Class: use of classes in accordance to SOLID principles
* Mandate Strategy: implementation of statergy pattern
* Shared: C# class to use across the above projects. 


## Use Case
Let us consider in a banking environment the mandate creation process.
Each portfolio has a mandate type value (Corporation, Private Joint, ...) and the process of mandate creation depends on this.

The process can be simplified in this form, putting in a textbox the desired output:


![output_example_a](https://github.com/skepee/CSharp-Design-Pattern-migration-example/blob/master/output_example_a.png)

![output_example_b](https://github.com/skepee/CSharp-Design-Pattern-migration-example/blob/master/output_example_b.png)


### Basic
The basic elaboration in the mandate creation is expected something like this:

```csharp
var portfolio=.... //gets a portfolio

switch (portfolio.mandateType)
{
  case "A":
  CreateMandate_for_A(); 
  break;
  
  case "B":
  CreateMandate_for_B(); 
  break;
  
  case "C":
  CreateMandate_for_C(); 
  break;
}

public void CreateMandate_for_A();
{
  // Code to create mandate for mandate type A
}


public void CreateMandate_for_B();
{
  // Code to create mandate for mandate type A
}

```

### Class - SOLID principles
The first step of refactoring is to give more responsabilities to classes by following the first SOLID principle: Single Responsibility Principle (SRP).
In order to do this a class is created for a particular purpose, to generate a mandate for a particular mandate type. In this way each class will have its own method to generate the mandate output.

```csharp

public class Class_A()
{
  public void CreateMandate_for_A();
  {
    // Code to create mandate for mandate type A
  }
}


public class Class_B()
{
  public void CreateMandate_for_B();
  {
    // Code to create mandate for mandate type B
  }
}

```

### Strategy Pattern
The third step is to use the above classes following the strategy pattern [info](https://www.dofactory.com/net/strategy-design-pattern).
This is class diagram for the strategy pattern and this is what we want to realize:

![strategy pattern UML](https://github.com/skepee/CSharp-Design-Pattern-migration-example/blob/master/StrategyUML.png)

Following the diagram, the concrete strategies are already implemented and the classes still keep methods for mandate creation. 


#### Use of IMandate interface
The next step is to create an interface used by classes with just one method signature:

```csharp

string RunKYCMandate(Portfolio portfolio);
   
```

#### Context class
The last step is to create a Context class passing the interface in the ctor.


```csharp

  public class Context
    {
        IMandate _mandate;

        public Context(IMandate mandate)
        {
            this._mandate = mandate;
        }

        public string ContextInterface(Portfolio portfolio)
        {
            return _mandate.RunKYCMandate(portfolio);
        }
    }

```


in this way we can invoke the right mandate creation function simply:

```chsarp

context.ContextInterface(portfolio p)

```

where p can be an object to Class_A or Class_B.





