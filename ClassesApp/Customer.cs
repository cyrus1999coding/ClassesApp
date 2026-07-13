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

        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextId++;
            Name =name;
            Address=address;
            ContactNumber=contactNumber;

            //SetDetails(name, address);
        }

        // Default COnstructor
        public Customer()
        {
            _id =nextId++;
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
            Console.WriteLine($"Details about the customer:\nName is: {Name}\nID is {_id}");
        }

        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("Im' doing some customer stuff");
        }
    }
}
