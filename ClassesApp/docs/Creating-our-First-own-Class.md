# Creating our First own Class

```cs
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

```
- Here we already see that we have `class` **Keyword** → `internal class Program`  
  That's becuase c# is an Object Oriented Programming language which has this class Program  
  Which is the Starting point of our application with its `Main method` that's where is code is executed .  

How do we create a new class ❔  
💡 :  
We can open `view` →  `solution explorer` → right lcick on the `Project` → Add → select `class`  
And we can give that class a name → `Car.cs`

Now the ClassesApp Project which inside Soulution folder will be :  

```text
> Soulution 'ClassesApp' (1of 1 project)
    > ClassesApp
      > Dependencies
      > docs
        Create.....md
      > Car.cs 👈
      > Program.cs
    

```

`Car.cs` :  

```cs
using System;
using System.Collections.Generic;
using System.Text;
> (Teacher also had) System.Linq;
> (Teacher also had) System.Threading.Tasks;

namespace ClassesApp
{
    internal class Car
    {
    }
}
```
- There is already bunch of boilerplate code that just is there and is unchangable ( `using` 🔑`Directives` ).  
  We can delete them but we can leave them be 

- `namespace ClassesApp` :  
  We have the same namespace which is the same namespace we had for our other class Program ↓  
  🧠 :  
  ```cs
   namespace ClassesApp 👈
   {
       internal class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Hello, World!");
           }
       }
   }
  ```
  Which was automatically generated for us .

- `internal class Car` :  
  Then we hace our own class called Car .  
  This class is 🔑`Internal` Which just means that it can only be accessed from withing the same 🔑`assembly` .
  🔑`assembly` : simiply means withing the same Program .  
  And other Programs can not access this class .  
  That's what this `internal` does for us .

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        // Constructor
        public Car() { }

    }
}
```
- `public Car() { }` :  
  Is 🔑`Constructor`, is very similar to a `method` but it;s different in that it has  
  the same name, Exact same name as the `class` itself and  
  It's not have a `return type` .  
  This constructor `called`/`executed` whenever a new Object of car is created .

Let's see practical example :  

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        // Constructor
        public Car() {
            Console.WriteLine("An Object of car has been created !");
        }

    }
}

```
- Basically this code → `Console.WriteLine("An Object of car has been created !");`  
  Will be executed whenever we create a new item or `Object` of 🔑`type Car` .

```cs
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car(); 👈

            Console.WriteLine("Hello, World!");
        }
    }
}
```
- with this `new` **Keyword** that we've seen it before .  
  Basicallt what it does is locates space inside of the memory for our car `Object` .  
  Technically what we're saying is create an Object that follows the `blueprint` of our class Car .
  
🔑 `Blueprint` : basically the instruction and the rules that we define how this class is supposed to  
be behave and that's what we defined in `Car.cs` `class` .  
So there we can set it up as blueprint and each time that we creae Object of it it will follow the rules that we have defined in this bluepring .  
In our case the only rule that we have defined so far is that whenever we create an `Object` of Car  
we want this statement → `Console.WriteLine("An Object of car has been created !");` to be executed .

So this `constructor` ↓ 

```cs
        // Constructor
        public Car() {
            Console.WriteLine("An Object of car has been created !"); 
        }
```

Will be called once this line is executed ↓  

```cs 
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creatung an Object of the Class Car
            // Creatung an Instance of the Class Car
            Car audi = new Car(); 👈

            Console.WriteLine("Hello, World!");
        }
    }
}
```

```console
An Object of car has been created !
Hello, World!
```

- `Car audi = new Car();` :  
  Using debugger and step into → `audi` contains `{ClassesAoo.Car}` .

```cs
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car(); 👈
            Car bmw = new Car(); 👈

            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}
````
- Both of this Objects → `audi` & `audi`  
  Currently not modifed at all, which me can Modify the information that a car has about itself .  
  So that audi knows that its auti  
  And the bmw knows that its bmw  
  Which we do next .

- So we created our 🔑`custom Constructor`, how is this custom Constructor is different to  
  Any other given Constructors ❔  
  💡 :  
  We'll going to look at later on .

one more thing about private member variable → `private string _model = "";`  
We can't access that in the `Program.cs` ↓  

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3","german");
            Car bmw = new Car("I7","austulia");
            bmw._model; ❌ We can't access it 

            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}

```
- `bmw._model;` :  
  We'll see how we can access it .