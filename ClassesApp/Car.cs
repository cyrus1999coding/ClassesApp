using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Represents a car with a specific model.
/// </summary>
namespace ClassesApp
{
    internal class Car
    {
        // member variable
        private string _model = "";
        private string _brand = "";

        // property
        public string Model1 { get => _model; set => _model = value; }
        public string Brand { get => _brand; set => _brand = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand)
        {
            Model1 = model;
            Brand = brand;
            Console.WriteLine("A car of the model " + Model1 + " With brand of " + Brand + " has been created Successfully");
        }

    }
}
