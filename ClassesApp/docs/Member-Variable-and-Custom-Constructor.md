# Member Variable and Custom Constructor

We're going to look at `Member Variable`s, And we're going to look at the `constructor` a little more .

🔑 `Member Variable` :  
It's a 🔑`field` Inside of a `class` ( So it's a variable that is inside of `class` but outside of `methods` ) .  

```cs
namespace ClassesApp
{
    internal class Car
    {
        // member variable
        string model = ""; 👈

        // Constructor
        public Car() {
            Console.WriteLine("An Object of car has been created !");
        }

    }
}
```
- `string model = "";` :  
  If we hover over it we'll see → `(field) string Car.model` .

- 🔑 So if we're using a `field` `inside of a class` that we're creating then it is a `member variable` of that `class` .  

- So `model` now is a `memeber variable` of the **Car class** and it is `defining something about that class` .  
  In this case its defining the model of that Car class .

- 🔑`Naming Convention` :  
 A very common name is to use `_` before the variable name and add `private` **Keyword**

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        // member variable
        private string _model = ""; 👈

        // Constructor
        public Car() {
            Console.WriteLine("An Object of car has been created !");
        }

    }
}

```
- `private string _model = "";` :
  This `private` **Keyword** hide the variable from other classes ( we're oging to look at that in the next video ) .  
  For now we just wanted to have something that allows us to modify any given Object of our class Car,  
  So that we can then ditinguish them from each other because right now there is no difference between an audi or bmw Objects ↓  
  ```cs
    namespace ClassesApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Car audi = new Car();
                Car bmw = new Car();

                Console.WriteLine("Hello, World!");

                Console.ReadKey();
            }
        }
    }
  ```
  And that's what this variable → `_model` Should hold .

So how can we now use this `member variable` or `field` (`_model`) here ❔  
💡 :  
We can use it inside our `constructor` .  
🧠 Remember : `constructor` is called whenver we're creating an Object of our given Class in this case of our Car Class .

So :  

```cs
namespace ClassesApp
{
    internal class Car
    {
        // member variable
        private string _model = "";

        // Constructor
        public Car(string model) {
            _model = model;
            Console.WriteLine("An Object of car has been created !");
        }

    }
}

```

- We can pass Data to the `constructor` when we're creating a new `Object`  
  ```cs
  public Car(string model) {
            _model = model;
            Console.WriteLine("An Object of car has been created !");
  }
  ```
  - `public Car(string model)` :  
    This `string model` will be whatever the user enters .  
    So this is the Parameter that we're using for our Car Constructor .  
    Which means whenever we creating a Car Object we need to pass Data to it ↓  
    ```cs
    // Progrma.cs
    namespace ClassesApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Car audi = new Car("A3"); 👈
                Car bmw = new Car("I7"); 👈

                Console.WriteLine("Hello, World!");

                Console.ReadKey();
            }
        }
    }
    ```
  - `_model = model;` :  
    We're storing that in this `private memeber variable` 

So now we can use this informations to say something in the console  

```cs
// Car.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        // member variable
        private string _model = "";

        // Constructor
        public Car(string model) {
            _model = model;
            Console.WriteLine("A car of the model" + _model + "has been created ");
        }

    }
}
```

```console
A car of the modelA3has been created
A car of the modelI7has been created
Hello, World!
```

- So what we here saying is when you creating a Car Object you need to give me information about the model of a car .  
  And when you give the model of the care which comes from an external cause, we're storing that in  
  Our `private member variable` that 🔑`holds information about that Object` and in our case we're printing that  
  In the console .

👀 We can also get the brand of the car :  

```
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
        private string _model = "";
        private string _brand = ""; 👈


        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand 👈)
        {
            _model = model;
            _brand = brand; 👈
            Console.WriteLine("A car of the model " + _model + " With brand of " + _brand + " has been created Successfully");
        }

    }
}
```

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3","german" 👈);
            Car bmw = new Car("I7","austulia" 👈);

            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}
```

```console
A car of the model A3 With brand of german has been created Successfully
A car of the model I7 With brand of austulia has been created Successfully
Hello, World!
```