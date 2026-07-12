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

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("Im' doing some customer stuff");
        }
    }
}
