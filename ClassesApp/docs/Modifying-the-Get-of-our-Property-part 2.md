# Modifying the Get of our Property part 2

In the next video, We're going to use `properties` that dont have `backing fields`  
We want to understand what that means, When to use or not to use it .

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
        // member variable
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        // property
        public string Model1 { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if (_isLuxury)
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

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand, bool isLuxury)
        {
            Model1 = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
        }

    }
}

```
- What we have here in our Car class we have `properties` :
  - Model
  - Brand
  - IsLuxuries

- And we also created `private member variable` :
  -  _model
  -  _brand
  -  _isluxuries
  - We can also name this `private member variable` also 🔑`Backing Fields`

So the `_model` is the 🔑`Backing Field` for the `Model property`,  
Sometimes we can get away without having a `Backing Field` where we can just use the `property`  
And don't have to define a `Backing Field` whatsoever .  

🔑 We would do that if :  
We don't want to Modify what should happen when we're are `getting` or `setting` that `property`,  
What does that mean ❔  
💡 :  
For our `Model` `property`, We're using the `default property`, And we're not overWritting what  
Should happen when we `get` the `property` or not what should happen when we are `setting` the `property` .  
But for `Brand` `property`, We having some instruction for what should happen, for that we need to have a `Backing Field` which is our `_brand` `member variable` .  
So we could have gotten away without using this `Model` `property` here .

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
        // member variable
        // private string _model = ""; 👈 We don't need this 
        private string _brand = ""; 
        private bool _isLuxury;

        // property
        // public string Model1 { get => _model; set => _model = value; } // 👈 Don't need this too
        public int Model { get; set; } 👈✅
        public string Brand
        {
            get
            {
                if (_isLuxury)
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

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand, bool isLuxury)
        {
            Model1 = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
        }

    }
}

```
- `public int Model { get; set; }` :  
  This is the 🔑`default getter and setter`, We're not overwriting what should happen .  
  - ⛔ Not setting the `_model` and any of that we don't need to do that .
  - 🔑 This `Model` `property` is also a variable, right ? It can hold Data

- So this `variable Model` now has the `default get` and `default set`,  
  🔑 Which means that it's just gonna behave like a normal variable .

With `Brand` `property` however we did Modified how we want to treat the Brand whenever we're `getting` it and `setting` it .  

So that's how we can use the `Model` `property` without the `backing field` `_model` .  

🚀 What are the advantages of using it ❔
1. Gives us simpilicity 
2. Reduces the amount of code
3. Making the class simpler and more readable

🔑🔑 Now that we know that we can do the same thing with the `IsLuxury` `property`, because ↓  
```cs
public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
```
- It also just `get` and `set` the `value` by default .

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
        // member variable
        // private string _model = "";
        private string _brand = "";
        //private bool _isLuxury;

        // property
        // public string Model1 { get => _model; set => _model = value; }
        public int Model { get; set; }
        public string Brand
        {
            get
            {
                if (_isLuxury) ❌
                if (IsLuxury) 👈 ✅
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
        public bool IsLuxury { get; set; } 👈

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand, bool isLuxury)
        {
            Model1 = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
        }

    }
}

```
- `if (IsLuxury) :`  
  We need to make sure that we check the `property` here because `member variable` ( `field` ) is no longer exists .

📝 :  
The whole point is we don't need to have a `backing field`,  
If we are not Maually overwriting what should happen when we `get` or set `the` variable  

```cs
using System;

/// <summary>
/// Represents a car with a specific model.
/// </summary>
namespace ClassesApp
{
    internal class Car
    {
        // Backing field because Brand has custom logic.
        private string _brand = "";

        // Auto-properties are enough because they don't contain custom logic.
        public string Model { get; set; }

        public bool IsLuxury { get; set; }

        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return $"{_brand} - Luxury Edition";
                }

                return _brand;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("You entered nothing!");
                    _brand = "Default Value";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        /// <param name="brand">The brand of the car.</param>
        /// <param name="isLuxury">Whether the car is a luxury model.</param>
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;

            Console.WriteLine(
                $"A car of model {Model} with brand {Brand} has been created successfully.");
        }
    }
}
```