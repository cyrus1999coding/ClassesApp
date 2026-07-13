# ID Key and readonly  

We're going to look at 🔑`Keys` as well as 🔑`readonly` **Keyword**

## 🔑`Keys` :  
`Unique Indentifier` inside of a `Database`, we're not working with Database yet  
But since we're dealig with Customers, it's good idea to see how 🔑`ID`s work .

🧠 Remember : We learned how we use `static` **Keyword** that allows us to Increment itself each time  
That a new Customer is created which then we can use for exmaple for such a 🔑`Key` .

🔑 The idea behind the `Key` is that its allowing every single Entry so in our case  
Every single Customer to have something that is Unique about them .  
Because we may have 10 `koorosh` in our Database in that case the `Keys` help where it's a Unique identifer .

🔑`Microsoft's naming convention is`:

| Member        | Convention                                        | Example                       |
| ------------- | ------------------------------------------------- | ----------------------------- |
| Class         | PascalCase                                        | `Car`                         |
| Method        | PascalCase                                        | `Drive()`                     |
| Property      | PascalCase                                        | `Name`                        |
| Public field  | PascalCase                                        | `NumberOfCars`                |
| Private field | `_camelCase` (modern) or `camelCase` (older code) | `_brand`, `_nextId`, `nextId` |


So : 

```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        👇
        // static field to hold the next ID avaiable 
        private static int nextId = 0;
        👆

        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            Name=name;
            Address=address;
            ContactNumber=contactNumber;

            //SetDetails(name, address);
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

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("Im' doing some customer stuff");
        }
    }
}

```
- `private static int nextId = 0;` :  
  ⛔ It's not oging to be part of each `Customer` `Object` .  
  ✅ Somehow it's outside of each `Customer` `Object` .
  🔑🔑 See the naming convention ❓ 💡: Because it's `private`

So how do we now Assign an ID for each Customer ❔  
💡 :  
We can make a `private` `readonly` ↓ 

```cs
// Customer.cs 

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

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name, string address = "NA", string contactNumber = "NA"){ ... }
        public Customer() { ... }

        public void SetDetails(string name, string address, string contactNumber = "NA") { ... }
        public static void DoSomeCustomerStuff() { ... }
       
    }
}
```
- `private readonly int _id;` :  
  This is going to be the Unique identifer where it's different for every single Cusotmer that we create .

- 🧠 Idea : Even if we create 5 Customer and we delete the 3'ed one, 🔑🔑 The reason that we have  
  `nextId`

So let's do that :

```cs
// Customer.cs 

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        // static field to hold the next ID avaiable 
        private static int nextId = 0; 👈

        private readonly int _id; 👈

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name, string address = "NA", string contactNumber = "NA"){ ... }
        {
            _id =nextId++; 👈
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }
        public Customer()
        {
            _id =nextId++; 👈 
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA") { ... }
        public static void DoSomeCustomerStuff() { ... }
       
    }
}
```
- `_id =nextId++;` :
  🔑🔑 (`Post-Increment`) So we are Assiging `0` then then Increment it . ( ++ after the nextId does this )
- We' should do this in all of our `Constructors` .  
- 🔑🧠 : The idea is we're setting the `_id` and we cannot overwrite the `_id` for any given  
  `Customer` after the effect because it's `readonly` ↓  
  ```cs
  private readonly int _id;
  ```
  - So this `readonly` `Instance Field`/`Member Variable`/(Not `backing field` here because it's not used in a `property`) can be 🔑`initialized only Once`

- So by doing this every single Customer will get a Unique `_id`, this `_id` is `private`  
  And the only way we can see it is inside of this `Customer Class` .

We can detail about the Customer so : 

```cs
// Customer.cs 

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        // static field to hold the next ID avaiable 
        private static int nextId = 0; 👈

        private readonly int _id; 👈

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer(string name, string address = "NA", string contactNumber = "NA"){ ... }
        {
            _id =nextId++; 👈
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }
        public Customer()
        {
            _id =nextId++; 👈 
            Name = "Default Name";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA") { ... }

        👇
        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer:\nName is: {Name}\nID is {_id}");
        }
        👆

        public static void DoSomeCustomerStuff() { ... }
       
```
- So this `GetDetails()` `Method` can `get` the `_id` .

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");

            customer1.GetDetails();
            customer2.GetDetails();

            Console.ReadKey();
        }

    }
}
```

```console
Details about the customer:
Name is: Default Name
ID is 0 👈
Details about the customer:
Name is: John Doe
ID is 1 👈
```
- So we are shield the `_id` and it can only be `Accessed` with the `Class` .  
- 🔑🔑 We can create `Methods` that will expose it to outside :
  - ⛔ but not he `variable` itself .
  - ✅ but only the `variable value` .

Next we're going to see how we can make the `readonly` `properties` .