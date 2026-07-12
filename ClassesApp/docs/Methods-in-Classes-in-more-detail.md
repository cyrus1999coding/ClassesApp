# Methods in Classes in more detail

There are 🔑`member Methods` or 🔑`member Functions`,  
So `functions` are like `methods` they do the same thing the only diffrence is `functions` are now part of a `class` .  
If `function` inside a `class` it's called `method` ( In context of OOP ) .

```cs
// Customer.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            Name=name;
        }

        // Default Constructor
        public Customer()
        {
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }
    }
}

```
We know that we can have a `default constructor`, Where we just set `default values` but what if we want  
To `set values` after the fact ❔ So after the Object already has been created .  
🔑 Because the `constructor` is only called once and that is when the Object is created ( So whenever we use the `new` **Keyword** (👀 `Customer myCustomer = new Customer()`), but we can't  
Use `constructor` after that for that same Customer `Object` .

So :

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        👇
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
        👆

        public Customer(string name)
        {
            Name=name;
        }

        // Default COnstructor
        public Customer()
        {
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }
        👇
        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
        👆
    }
}
```
- What we want to do is the smae as we did with our `custom Constructor`,  
  Where we gotten `Parameters` and storing them inside of `Properties` .

- This `SetDetails` `Method` are belong to the `Customer` `Class` and whenever we use that `Method`,  
  It will Modify the the `Customer` `Object` on which we're calling that `Method` .  
  What does it mean ❔  
  💡 :
  - We creaee this `Method` (`SetDetails`), and we made it `public` so that we can Access it from another `Class` .  
    So this is the `Access Modifier` which allows us to use it from the `Program.cs` file .  
    Otherwise if it were `private` for example we couldn't do that ( We couldn't use `SetDetails` from another `Class` we will look at that later on ) .
  - Then the `return type` is `void`, which means that this `Method` will not need any `return type` .
  - The giving it a name → `SetDetails` ( Pascal Case ) .
  - Method Body ↓  
    ```cs
    Name = name;
    Address = address;
    ContactNumber = contactNumber;
    ```

So ↓

🧠 :
```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("frankTheTank","Mainstreet 1","123123");

            Customer myCustomer = new Customer();
            Console.Write("Please enter the customers Name ");
            myCustomer.Name = Console.ReadLine();

            Console.WriteLine("Details abot customer: "+ myCustomer.Name);

            Console.ReadKey();
        }
    }
}

```

Now :

```
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("frankTheTank","Mainstreet 1","123123");

            Customer myCustomer = new Customer();

            myCustomer.SetDetails("Frank", "MainStreet 2", "123123"); 👈

            Console.WriteLine("Details about customer: "+ myCustomer.Name);

            Console.ReadKey();
        }
    }
}
```

```console
Details about customer: Frank
```

- `myCustomer.SetDetails("Frank", "MainStreet 2", "123123");` :  
  This is how we called the `SetDetails` `Method`, and overwriting the values for the `myCustomer` `Object` .
- 🔑⛔ It's not going to `Modify` neighter `Customer earl` nor `Customer frankTheTank` .
- 🔑 ( Myself ➕ Chatgpt ) :  
  When an `object` is created, every `field`/`property` gets its `default value` before the constructor runs.  
  For reference types like string:  
  ```cs
  default(string) == null
  ```
  For value types:
  ```cs
  default(int)    == 0
  default(bool)   == false
  default(double) == 0.0
  ```
  ## If you don't want them to be `null` :  
  You can initialize them inside the constructor: 
  ```cs
    public Customer(string name)
    {
        Name = name;
        Address = "No Address";
        ContactNumber = "No Contact Number";
    }
  ```
  Or you can 🔑`chain to another constructor` (a common C# technique):  
  ```cs
    public Customer(string name)
        : this(name, "No Address", "No Contact Number")
    {
    }
  ```
  This reuses your existing constructor instead of duplicating code.
  ## One more thing (important)
  If you have 🔑`nullable reference types` enabled (`the default in modern C# projects`), Visual Studio will likely warn that these properties may be null because you've declared them as non-nullable:  
  ```cs
  public string Name { get; set; }
  public string Address { get; set; }
  public string ContactNumber { get; set; }
  ```
  A cleaner approach is to ensure every constructor initializes all three properties, 🔑🔑`or explicitly declare them nullable`if `null` is an acceptable value: 
  ```cs
  public string? Address { get; set; }
  public string? ContactNumber { get; set; }
  ```
  Since you're learning OOP, the best practice is usually to initialize all required properties in every constructor so your objects are always in a valid state.