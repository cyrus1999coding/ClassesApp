# Optional Parameters

If we want to make sure that a `Parameter`, When using an `Argument` or entering an `Argument` is **optional**,  
So we don't have to add it .  

We do so :

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
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA" 👈 )
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}

```
- So when we are using the `SetDetails` `Method` now we can don't enter the `contactNumber` .

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.SetDetails("Denis", "MainSStreet 1"); 👈
        }
    }
}
```
- `customer.SetDetails("Denis", "MainSStreet 1");` :  
  🔑 void Customer.SetDetails( string name, string address, `[string contactNumber = "NA"]` .  
  🔑🔑 We see it's inside the `[]` which just means it does have a `Default Value` Assigned to it the `Method` Definition .  
  So the `contactNumber` is the `Default Parameter` of the `SetDetails` `Method` .  

🔑 We can use the `default parameters` in `Constructors` as well ↓  

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
        👇
        public Customer(string name)
        {
            Name=name;
        }
        👆

        // Default COnstructor
        public Customer()
        {
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
```
- Non-nullable property 'Address' must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring the property as nullable.

- Non-nullable property 'ContactNumber' must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring the property as nullable.

We can by default going to assume that the what is it `address` abd the `contactNumber` ↓  

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

        public Customer(string name, string address, string contactNumber) 👈
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name, string address = "NA", string contactNumber = "NA") ❌
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Default COnstructor
        public Customer()
        {
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
```
- ❌ : Type 'Customer' already defines a member called 'Customer' with the same parameter types .  
  📝 This is because we already a `Constructor` with those `parameters` .  
  📝✅ : We need to be careful, we should just remove this entire `custom Constructor` .  
  ```cs
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            Name=name;
            Address=address;
            ContactNumber=contactNumber;
        }
  ```
  Basically choosing the better one, where we're using the `name`, and other `parameters` have `default values` .

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.SetDetails("Denis", "MainSStreet 1");

            Customer customer1 = new Customer("Frank");

            Console.WriteLine("Contactnumber of Frank is: " + customer1.ContactNumber);

            Console.ReadKey();
        }
    }
}
  
```

```console
Contactnumber of Frank is: NA
```

- `Customer customer1 = new Customer("Frank");` :  
  Customer( string name, `[`string address = "NA"`]`, `[`string contactNumber = "NA"`]`)

- So what we saw was the `Default`/`Optional` `Parameter`s .

Now let's look ar how we can use 🔑`Named Parameters` .