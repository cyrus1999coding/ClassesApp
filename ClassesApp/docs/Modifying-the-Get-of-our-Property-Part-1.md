# Modifying the Get of our Property Part 1

```
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
        private bool _isLuxury; 👈

        // property
        public string Model1 { get => _model; set => _model = value; }
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
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand, bool isLuxury 👈)
        {
            Model1 = model;
            Brand = brand;
            _isLuxury = isLuxury; 👈
            Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
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
            Car audi = new Car("A3","Audi", false); 👈
            Car bmw = new Car("I7","BMW",true); 👈

            Console.Write("Please enter the Brand name: ");

            // Setting _brand
            audi.Brand = Console.ReadLine();

            // Gettig _brand
            Console.WriteLine("You entered " + audi.Brand);

            Console.ReadKey();
        }
    }
}

```

- So for now our `member variable` ( _isLuxury ) is going to be whatever thr User entered whther as it is  
  Luxury car or not .
- 🔴⛔ : as we see we're directly accessing the `private member variable`, which we shouldnot .  
  ✅🛠 So we need a `property`, That surronds it .

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
        private bool _isLuxury; 👈

        // property
        public string Model1 { get => _model; set => _model = value; }
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

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand, bool isLuxury 👈)
        {
            Model1 = model;
            Brand = brand;
            IsLuxury = isLuxury; 👈
            Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
        }

    }
}

```
- So now we just added a bit more detail about our car, and we can store more infromation .

Now we want to Modify what should happen when we want to `get` the `_brand` ↓  

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
            👇
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
            👆
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

- So what we say here is that whenever you access the `_brand` fiest of all check something else  
  And then we'll gibe you `Modified` result, not just giving the `_brand` all the time .

Let's access the `_brand` :  

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "Audi", false);
            Car bmw = new Car("I7", "BMW", true);

            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);

            Console.ReadKey();
        }
    }
}
```

```console
A car of the model A3 With brand of Audi has been created Successfully
A car of the model I7 With brand of BMW - Luxury Edition has been created Successfully
Brand is Audi
Brand is BMW - Luxury Edition
```

- Basically what we did there is we `Modified` what we **get** when we use the `get` `method` ( getter method ) this is `internally`  
  Like a `Get method`, it's not written like such but it's pretty much like we were trying to get the brand .

- Now we saw how we can use `Encapsulation` to basicallt use our `member variable`, Hide it from outside classes  
  But also make sure in order to access it is to go through this gatekeeper called `property` that `encapsulate` it .

- 🔑 We should never use `public` `member varialbes` .

- Quck review of `lambda expressions` :  
  ```cs
  public string Model1 { get => _model; set => _model = value; }

  public string Model1 
  { 
    get
    {
        return _model;
    } 
    set
    {
        _model = value;
    }
  }
  ```
  This are basically the same 