# Defining how a property is set  

We're going to see why this whole thing matters, Why it's so important to use `properties` and  
An important aspect of `Encapsulation` .  

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
        private string _model = "";
        private string _brand = "";

        // property
        public string Model1 { get => _model; set => _model = value; }
        public string Brand { get => _brand; set => _brand = value; } 👈

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand)
        {
            Model1 = model;
            Brand = brand;
            Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
        }

    }
}

```
- We're going to simplify this part → `=> _brand = value;`


```cs
        public string Brand
        {
            get => _brand;
            set { _brand = value; }
        }
```
- This is the Entire `property` .

- First part is → `get => _brand;` :  
  If you want to `get` it we're going to give you the `private string _brand = "";`

- `set { _brand = value; }` :  
  If your're going to set it then you have to go through the logic that i'm going to define inside of  
  This `{}`

So let's define some logic :  

```cs
        public string Brand
        {
            get => _brand;
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
```
- If somebody does that we ⛔ cannot store the brand of the car,  
  And if that's the case then we;re going to set the `_brand` with a default value .

- So whenever we assign a value to `_brand` we're going to say arre you empty ?  
  if you are `empty` or if it's `null` ( 🔑 `Empty string` `is not null` ) then we  
  set the value of `_brand` to `"Default Value"` and we're going our of the set block .  
  But if you entered an actual text we're going to store that in this member variable → `private string _brand = "";`

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

            Console.Write("Please enter the Brand name: ");

            // Setting _brand
            audi.Brand = Console.ReadLine(); 👈

            // Gettig _brand
            Console.WriteLine("You entered " + audi.Brand); 👈

            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}
```

- `audi.Brand = Console.ReadLine();` :  
  In this part, We're going through this part ↓  
  ```cs
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
  ```

- `Console.WriteLine("You entered " + audi.Brand);` :  
  We're going through this part ↓  
  ```cs
  get => _brand;
  ```

```console
A car of the model A3 With brand of german has been created Successfully
A car of the model I7 With brand of austulia has been created Successfully
Please enter the Brand name:
You entered Nothing! 👈
You entered Default Value 👈
```

```console
A car of the model A3 With brand of german has been created Successfully
A car of the model I7 With brand of austulia has been created Successfully
Please enter the Brand name: koorosh
You entered koorosh
```

This is part of the Encapsulation where we define specificaly what the condition  
should be when somebody tries to Access your `variables`, in this case to access our `property` .  
🔑🔑 Because we're saying if you want to `set` the `property` you should follow my rules so don't enter empty string .

🔑 We can do same thing with the `getter` ↓  

```cs
        public string Brand
        {
            get => _brand; 👈
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
```
- We can say whenever you're trying to get the variable, we are going to set specific rules as well . ( We do that in the next video )

Let's understand 🔑`value` **Keyword** as well .

🔑`value` :  
Is whatever we enter in here ↓  

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

            Console.Write("Please enter the Brand name: ");

            // Setting _brand
            audi.Brand = Console.ReadLine(); 👈
            audi.Brand = "Car" 👈

            // Gettig _brand
            Console.WriteLine("You entered " + audi.Brand);

            Console.ReadKey();
        }
    }
}

```
- `audi.Brand = "Car"`:  
  Then `"Car"` is the 🔑`value`, that we're passing to our `Brand` `property` ( We `Setting` in our `Brand` ) .  

- `Car audi = new Car("A3","german");` :  
  Note that here the `"german"` is passed to the `Car Constructor` ↓  
  ```cs
    public Car(string model, string brand)
    {
        Model1 = model;
        Brand = brand; 👈
        Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
    }
  ```
  Which them uses the `property Brand` and it rules ↓  
  ```cs
   public string Brand
    {
        get => _brand;
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
  ```
  And if everything is ok the `value` is going to be stored in the `_brand member variable` .