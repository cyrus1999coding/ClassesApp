# Public and Private Keywords

We want to talk about 2 🔑 `Access Modifers` that we've used :  

1. `public`
2. `private`

The thing is there are more `Access Modifiers` which `public` & `private` are like  
🔑`internal` is also is an `Access Modifier` .

## `public` :  
Is something if we want to make it availabe outside of the `Class` 

## `Private` :
If we don't want to make it available outside of the `Class`


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
        public static int NumberOfCars = 0; 👈

        // member variable
        // private string _model = "";
        private string _brand = ""; 👈
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
            NumberOfCars++;

            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("A car of the model " + Model + " With brand of " + Brand + " has been created Successfully");
        }

        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} driving, And I'm driving");
        }

    }
}

```
- `public static int NumberOfCars = 0;` :  
  We can Access it outside of the Class .

- `private string _brand = "";` :  
  We can't Access it outside of the Class

And we can use the `public static int NumberOfCars` in the `Program.cs` :  

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);

            Console.WriteLine("Number of car produced " + Car.NumberOfCars 👈);

            Console.ReadKey();
        }

    }
}
```

But what if it was `private static int NumberOfCars = 0;` ❔  

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);

            Console.WriteLine("Number of car produced " + Car.NumberOfCars 👈); ❌

            Console.ReadKey();
        }

    }
}
```
- ❌ : 'Car.NumberOfCars' is inaccessible due to its protection level .  
- 🔑 There are more 🔑`protection levels` such as :  
  - 🔑`protected` 
  - 🔑`internal` 
  - 🔑`protected internal`
  - But we're not going to need those untill we looked at 🔑`inheritance` which is a topic what we're going to cover later.
- 🔑For now just be aware that we need to make sure that we make  
  Our `properties` `public` ↓  
  ```
  // 👀 

  public string Model { get; set; }
  ```
  So that we can Access them from the outside uless we don't want too  
  But usually we always make our `properties` `public`
- And `Member Variale`/`Backing Fields`, `private` .  
  ```cs
  // 👀
  private string _brand = "";
  ```
- With `Methods`, When we want the `Methods` to only available inside of a given `Class`  
  We would make it `private` .  
  And if we want it to be avaiable from all `Classes` we would make it `public` .  
  ```cs
  // 👀 

    public void Drive()
    {
        Console.WriteLine($"I'm a {Model} driving, And I'm driving");
    }
  ```
  🔑 Usually what we do, we would make it `public` .
   👀 )  
   If we would make that `Drive` `Method` `private` ↓  
   ```cs
   // 👀
    namespace ClassesApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Car car = new Car();
                Car car2 = new Car();
                Car car3 = new Car("A3", "Audi", false);
                car3.Drive(); ❌

                Console.WriteLine("Number of car produced " + Car.NumberOfCars);

                Console.ReadKey();
            }

        }
    }
   ```
   - ❌: 'Car.Drive()' is inaccessible due to its protection level  
     📄 Then we couldn't to this anymore .  
     In thise case we could only use that `private` `Method` in `Constructors`, or any other `Methods`  
     That are inside of our `Car Class` .

### Access Modifers :  
Are crusial for managing how `classes` and `class members` are **accessed** in softwere projects.  
By controlling **access** :  
- you can `safegautd` the `internal state` of `Objects` .  
- Reduce `dependencies` between components .  
- Enhance `maintainibility` ( How easy it is to work in the Project in the newture and add new features to the project).