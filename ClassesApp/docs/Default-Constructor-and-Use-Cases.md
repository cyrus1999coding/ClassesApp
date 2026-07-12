# Default Constructor and Use Cases

We're going to look at 🔑`Default Constructors` . 

🔑`Default Constructors` :  
A `Constructors` without any `parameters` that is just here for default cases where we set  
🔑`Values` as default `Values`

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

        public Customer(string name)
        {
            Name=name;
        }

        👇
        // Default COnstructor
        public Customer()
        {
            
        }
        👆
    }
}
```
- Here we can say whenver we creae a Customer where we don't pass any Arguments to the Constructor with  
  The `new` **Keyword** soething like :  
  ```cs
  Customer koorosh = new Customer();
  ```
  Where we didn't pass any details in there then we want to use `defualt values` .

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

        // Default COnstructor
        public Customer()
        {
            Name = "Default Name"; 👈
            Address = "No Address"; 👈
            ContactNumber = "No ContactNumber"; 👈
        } 
    }
}

```
- So this is something we can define in a 🔑`Default Constructor` .

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
           

            Customer myCustomer = new Customer(); 👈
            Console.WriteLine($"Details about customer:\n{myCustomer.Name}" +
                $"\n{myCustomer.Address}\n{myCustomer.ContactNumber}");

            Console.ReadKey();
        }
    }
}

```

```console
Details about customer:
Default Name
No Address
No ContactNumber
```

Basically that's how we can create a `Default Constructor`, And how we can create an `Object` using the Dfault Constructor .

When would that be useful ❔  
💡 :  
This would be useful for example for an `Admin` `back-end` where is a Customer is created then the  
Details about the Customer are added Manually after the fact .  
So now we can say :  
```cs
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("frankTheTank", "Mainstreet 1", "5554235467");
           

            Customer myCustomer = new Customer();

            Console.Write("Please enter the Customer's name: ");
            myCustomer.Name = Console.ReadLine();

            Console.Write("Please enter the Customer's address: ");
            myCustomer.Address = Console.ReadLine();

            Console.Write("Please enter the Customer's number: ");
            myCustomer.ContactNumber = Console.ReadLine();

            Console.WriteLine($"Details about customer:\n{myCustomer.Name}" +
                $"\n{myCustomer.Address}\n{myCustomer.ContactNumber}");

            Console.ReadKey();
        }
    }
}
```

```console
Please enter the Customer's name: korosh
Please enter the Customer's address: sa
Please enter the Customer's number: 123123
Details about customer:
korosh
sa
123123
```

- So we created a new Customer `with default values` and then we `overwrote` it's values in the Back-End . 

Now that we've seen `Default Constructor` and `Multiple Custom Constructors` we basicallt know  
How to :  
- `Create Instances` of `Classes` with `differnet Initial States` .
- Providig more `flexibility` for the User when working with our softwere
- This `Default Constructor` may also be useful when the User creates an Account and there is `Optional fields`  
  That the User doesn't have to enter .