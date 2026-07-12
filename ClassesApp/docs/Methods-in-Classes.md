# Methods in Classes

We're going to look at `Methods`, but very simple in next video we're going to go into methods a little more  
Complex .

```cs
// Car.cs

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Represents a car with a specific model.
/// </summary>
namespace ClassesApp
{
    internal class Car
    {
        // member variable
        // private string _model = "";
        private string _brand = "";
        //private bool _isLuxury;

        // property
        // public string Model1 { get => _model; set => _model = value; }
        public string Model { get; set; }
        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else 
                {
                    return _brand; 
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing!");
                    _brand = "Default Value";
                }
                else
                {
                    _brand = value;
                }

            }
        }

        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
        public bool IsLuxury { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("A car of the model " + Model + " With brand of " + Brand + " has been created Successfully");
        }

    }
}
```
- in this Car Class we have :  
  - member variables
  - properties
  - Constructor

So nothing else at this point, What we can do is to add `Methods` to our `Car` `Class`  
🔑And a `Method` that is added to a `Class`, 🔑`Modifies` what the `Object` of that `Class` can do .

What would be something that a car can do ?
👀 ) Can drive, So let's go ahead and create a `public void drive Method` .

```cs
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Represents a car with a specific model.
/// </summary>
namespace ClassesApp
{
    internal class Car
    {
        private string _brand = "";

        public string Model { get; set; }
        public string Brand { ... }
        public bool IsLuxury { get; set; }

        public Car(string model, string brand, bool isLuxury) { ... }
        
        👇
        public void Drive()
        {
            Console.WriteLine("I'm driving");
        }
        👆

    }
}
```
- `public void Drive()` :  
  - So we're using the `public` **Keyword** to make sure that we can use this `Method` out side of this  
  `Class` → 🔑 So that we can use this `Method` inside of the `Program` `Class` for exmaple .  
  - Then `void` wich means that we're not going to return anything .
  - `Drive()` :  
    Name of the `Method` which 🔑 can have `parameters`, But for now we're keeping it so simple

Now in the Program Class :  

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("A3","Audi",false);
            myAudi.Drive(); 👈

            Console.ReadKey();
        }
    }
}

```

```console
A car of the model A3 With brand of Audi has been created Successfully
I'm driving 👈
```

- As we can see we can use a `Method` on top a `Class`, Which is what we'ev using all the time → `Console.ReadKey()` or `Console.WriteLine()` eventhough they are `static` ↓  
  ```cs
  public static void WriteLine() 
  {
  Out.WriteLine();
  }
  ```
  We'll cover `static` **Keyword** a bit later, which does is we can call `Method`s of `Class` without having  
  To Create an `Instance` ( `Object` ) of it first .

- 🔑 We see an `Object` can have :  
  - `Properties` 
  - `Methods`

- So `Properties` are `Attirbutes` of that `Object` 

- And the `Method`s are the `Capabilities` ( skills ), things that it can do .

We can give this `Method` Drive some more information ↓  

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("A3","Audi",false);
            myAudi.Drive();

            Console.ReadKey();
        }
    }
}

```

```cs
// Car.cs

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Represents a car with a specific model.
/// </summary>
namespace ClassesApp
{
    internal class Car
    {
        private string _brand = "";

        public string Model { get; set; }
        public string Brand { ... }
        public bool IsLuxury { get; set; }

        public Car(string model, string brand, bool isLuxury) { ... }
        
        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} driving, And I'm driving"); 👈
        }

    }
}
```

```console
A car of the model A3 With brand of Audi has been created Successfully
I'm a A3👈 driving, And I'm driving
```

- This means that this Object → `Car myAudi = new Car("A3","Audi",false)`;  
  Is self-aware now !

Let's create another Car :  

```cs
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("A3","Audi",false);
            Car myBMW = new Car("i7", "BMW ", true);
            myAudi.Drive();
            myBMW.Drive();

            Console.ReadKey();
        }
    }
}
```

```console
A car of the model A3 With brand of Audi has been created Successfully
A car of the model i7 With brand of BMW  - Luxury Edition has been created Successfully
I'm a A3 driving, And I'm driving
I'm a i7 driving, And I'm driving
```

- So eventhough we;re still using this `.Drive()` `Method` but it behaves differently !  
 🔑 Because what this `.Drive()` `Method` does is ti allow us to use the `functionality` of our `blueprint`  
 Where we defined what the Car is capable of, and which attribute it has .