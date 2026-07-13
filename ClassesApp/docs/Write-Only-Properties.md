 # Write Only Properties

 We've seen how `readonly properties` work, but how about `writeonly properties` ❔  
 👀 ) Good example of `writeonly properties` owuld be the `Password`, we want to make sure that the 
 `Password` can `not be exposed` by anything, by any `Methods` or whatever . that's where we would use the 🔑 `writeonly properties` .

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

        private string _password; 👈

        public int Id
        {
            get
            {
                return _id;
            }
        }
        👇
        public string Password
        {
            set
            {
                _password = value;
            }
        }
        👆
        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }

        

        public Customer(string name, string address = "NA", string contactNumber = "NA"){ ... }

        public Customer(){ ... }

        public void SetDetails(string name, string address, string contactNumber = "NA"){ ... }

        public void GetDetails(){ ... }
        public static void DoSomeCustomerStuff(){ ... }
    }
}

```
- `private string _password;` :  
   Is the `backing filed` for our `writeonly property`

- We shouldn't have a `getter` :  
  ```cs
    public string Password
    {
        set
        {
            _password = value;
        }
    }
  ```
  So this Password is now a 🔑 `writeonly property`, Becasue the Password can only be `set` it cannot be `read` .

So now we can :  

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
            Customer customer3 = new Customer();

            customer1.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();

            customer3.Password = "<user password>";

            Console.ReadKey();
        }

    }
}
```
- `customer3.Password = "<user password>";` :  
  So now it will be our Password

What we tried to read that value ❔
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

            customer3.Password = "<user password>";

            Console.WriteLine(customer3.Password); ❌

            Console.ReadKey();
        }

    }
}
```
- ❌ : The property or indexer 'Customer.Password' cannot be used in this context because it lacks the 🔑`get accessor`  
  📄 🔑`get accessor` :  this is the `get` that we've seen ↓  
  ```cs
    public int Id
    {
        get 👈
        {
            return _id;
        }
    }
  ```
  But the Password only had the `set`, so we cannot access the Password .  

- See how we only set the `Password` for the `customer3`, we can set for other Customrs at other points of our program .

- 🔑⛔💀 Now we also see why its so important that we don't set the `_password` `backing field` because  
  That's exposable .  
  So we can actually get its value → `_password` `backing field` .  
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

            private string _password;

            public int Id
            {
                get
                {
                    return _id;
                }
            }

            public string Password
            {
                set
                {
                    _password = value;
                }
            }

            public string Name { get; set; }
            public string Address { get; set; }

            public string ContactNumber { get; set; }


            public Customer(string name, string address = "NA", string contactNumber = "NA")
            {
                _id = nextId++;
                Name = name;
                Address = address;
                ContactNumber = contactNumber;

                //SetDetails(name, address);
            }

            // Default COnstructor
            public Customer()
            {
                _id = nextId++;
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

            public void GetDetails()
            {
                Console.WriteLine($"Details about the customer:\nName is: {Name}\nID is {_id} " +
                    $"and the password is {_password} 👈💀🔑");
            }

            public static void DoSomeCustomerStuff()
            {
                Console.WriteLine("Im' doing some customer stuff");
            }
        }
    }
  ```
  - So suddenly we do have Access to this `_password`,  
    This is so example why `properties` are so important .
    ```cs
    // Progrma.cs
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

                customer3.Password = "<user password>";

                customer3.GetDetails(); 👈

                Console.ReadKey();
            }

        }
    }
    ```

    ```console
    Details about the customer:
    Name is: Default Name
    ID is 0 and the password is
    Details about the customer:
    Name is: John Doe
    ID is 1 and the password is
    Details about the customer:
    Name is: Default Name
    ID is 2 and the password is
    Details about the customer:
    Name is: Default Name
    ID is 2 and the password is <user password>👈💀
    ```

    - 🔑🔑 This is wht it's so important not to use the `backing fields` outside of defining the  
      `property` itself .  
      
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

        private string _password;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Password
        {
            set
            {
                _password = value;
            }
        }

        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }


        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;

            //SetDetails(name, address);
        }

        // Default COnstructor
        public Customer()
        {
            _id = nextId++;
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

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer:\nName is: {Name}\nID is {_id} " +
                $"and the password is {Password} 👈❌");
        }

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("Im' doing some customer stuff");
        }
    }
}

```
- 🚀❌ This also wouldn't work because it has not the `get Accessor `.

🔑 There is also more Advanced Techniques that will also not allowing us to access the password  
like use hashes and all that suff ( for later )

What is a hash ❔   
💡 :  
A hash function takes some input (like a password) and converts it into a fixed-looking random string.

Example:

```text
Password:
MySecret123

        ↓ hash function

Hash:
9f86d081884c7d659a2feaa0c55ad015...
```