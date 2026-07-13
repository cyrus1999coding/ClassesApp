# Read Only Properties  

We're going to see 🔑`Auto implemented properties` **Keyword**

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        // static field to hold the next ID avaiable 
        private static int nextId = 0;

        private readonly int _id; 👈

        public int MyProperty { get; set; } 👈
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name, string address = "NA", string contactNumber = "NA"){...}


        public Customer(){...}

        public void SetDetails(string name, string address, string contactNumber = "NA"){...}

        public void GetDetails(){...}

        public static void DoSomeCustomerStuff(){...}
        
    }
}
```
- `public int MyProperty { get; set; }` :  
  This here is an `Auto Impelemented Property` ( 🧠 use the `prop` **Emmet** to create that)

But we wnt to see 🔑`readonly properties`,  
So now how we can make a a `property` that will take care of the `_id` that we exposed to the outside ❔ a 🔑 `readonly` `property` ❔  
💡 :  
```cs
public int MyProperty { get; }
```
- 🔑 By saying there is no `set`, this suddenly become `readonly` property .

```cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        // static field to hold the next ID avaiable 
        private static int nextId = 0;

        private readonly int _id;

        public int Id { get; } 👈
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name, string address = "NA", string contactNumber = "NA"){...}


        public Customer(){...}

        public void SetDetails(string name, string address, string contactNumber = "NA"){...}

        public void GetDetails(){...}

        public static void DoSomeCustomerStuff(){...}
        
    }
}
```
- `public int Id { get; }` :  
  We can now only `read` it, we need to modify it so we can get this `_id` ↓  
  ```cs
    public int Id
    {
        get
        {
            return _id;
        }
    }
  ```
  🔑 This is important because in case of `ID`s, We need to have a way to identify an Object by something  
  And in this case by `_Id` because that that's the Unqiue Identifier that we're using 

When we we use this `readonly property` ❔  
💡 :  
We would use it if we want to make sure that we cannot oberwrite something like an `ID`, but we can get it 

Now we can Acess something by its Id inside of our Program : 

```cs
namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer();

            customer1.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();

            Console.WriteLine("Customer 3 id is " + customer3.Id); 👈

            Console.ReadKey();
        }

    }
}
```

```
Details about the customer:
Name is: Default Name
ID is 0
Details about the customer:
Name is: John Doe
ID is 1
Details about the customer:
Name is: Default Name
ID is 2
Customer 3 id is 2 👈
```

- So now we do have access to the `_id` from the outside ( 🔑 we can't modify it its `readonly` `property` ), Because we expose it using our `public` **Keyword**