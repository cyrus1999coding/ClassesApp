# Having Multiple Constructors  

We're going see how `constructor`s work in more depth,  
🧠 We're worked with our `custom constructor` .  

Now we're going to see we can have multiple constructors as well as something called a 🔑`default constructor` .  
Therefore we're going to have a spearate example that we'll make it even clearer than doing it with this  
`Car` exmaple .  

So we'll create a new class :

```cs
// Customer.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
    }
}
```

This class should have a few properties ↓ 

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
    }
}
```

- Let's say we have a customer insde of our `Database`, And we have few coulmns  
  Now for each of those `coulmns` we can now use as a `property` inside of our `class` .
  Because this `Customer class` is going to be then be usable to connect directly to a Database and `talk to the Database accordingly`, `get the Data out accordingly` .  
  All of those are fundamentals that we're going to need later on .

So now how would having Multiple Different Constructors matter here ❔  
💡 :  
Let's take 1 custom Constructor, And this is the one is going to take in everything so  
All 3 of those `properties` ↓  
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

        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
```
- So that what our `constructor` going to do, Each time that we create a new `Customer` `Object`,  
  🔑 So we can say a new `Customer Entry` `inside of our Database`, We're going to get all 3 of these Details .

What if we only get the `name` ❔  
because for some reason we don't have any other information  
We don't know the `contactNumber` and neither do we know the `address` of the user but we do know the name .  
So would we not add that person to our Database ❔  
💡 :  
We should still add the person to the Database, So let's have another `custom Constructor` ↓  

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
    }
}

```

Let's go ahead we create a few Customers ↓  

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Console.WriteLine($"Name of Customer is: {earl.Name}");  

            Console.ReadKey();
        }
    }
}
```

```console
Name of Customer is: Earl
```

- So we created a new Object, and we can store that in a Database for example or do whatever with it  
  Display it on a Website or use it in our User Inetrface or whatever .

Maybe we have another Customer too : 

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("frankTheTank", "Mainstreet 1", "5554235467");
            Console.WriteLine($"Name of Customer is: {earl.Name}");  

            Console.ReadKey();
        }
    }
}

```

🔑 ( Myself ) when hovering over `new Customer` i see :  
- `Customer(string name, string address, string contactNumber) (+1 overload)`
- `Customer(string name, string address, string contactNumber)`
- `Customer(string name)`
- Seems it `Automatically` pick the `overloads`
- 💡🔑🔑 This are `overloads` that i encountered before !, Now i create 2 of those haha .

Now we have 2 Constructors which of of them take 3 parameters and the other one takes 1  
But what if we don't have any information about a Customer ❔ But we still want to create a Customer Object ❔  
💡 : Then we're going to look at 🔑`default constructor`