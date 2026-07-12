# Static Methods

We're going to look at the 🔑`static` **Keyword** .  
🧠 Remember : We've seen the `Member Methods`/`Class Methods` .  
🔑 `static` `Methods` doesn't need an `Object` on which it can be called .

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); 
            customer.SetDetails("Denis", "MainStreet"); 👈

            Console.ReadKey();
        }

    }
}
```
- `customer.SetDetails("Denis", "MainStreet");` :  
  this `.SetDetails()` `Method` outside of it's own `Class` can only be called on an  `Object` of its  
  `Class` .  
  So `.SetDetails()` `Method` can only be called on `Object` of `type` `Customer` .

- `.SetDetails()` `Method` :  
  Also can be called on the class itself .  
  👀 )  
  ```cs
    Customer.cs

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

            public Customer(string name, string address = "NA", string contactNumber = "NA")
            {
                Name=name;
                Address=address;
                ContactNumber=contactNumber;

                SetDetails(name, address); 👈✅
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
  - ✅ That would work because the `Method` is inside the same `Class` .

  What if we want to have a `Method`, That we can call even if we don't create an `Object` of our `Customer Class` ❔  
  💡 :  
  We can use the 🔑`static` **Keyword** for that .

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
            👇
            public static void DoSomeCustomerStuff()
            {
                Console.WriteLine("Im' doing some customer stuff");
            }
            👆
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
                Customer customer = new Customer();
                customer.SetDetails("Denis", "MainStreet");

                Customer.DoSomeCustomerStuff(); 👈

                Console.ReadKey();
            }

        }
    }
  ```

- So the `static` **Keyword** indicates that :  
  💚 we don't need to call it on an `Object`, We can call it witout creating an `Object` .  

🔑 `static` **Keyword** can also be used in `Classes`, `Constructors`, `Properties` and `Fields` and as we've seen with `Methods` .