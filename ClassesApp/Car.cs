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


        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand)
        {
            _model = model;
            _brand = brand;
            Console.WriteLine("A car of the model " + _model + " With brand of " + _brand + " has been created Successfully");
        }

    }
}
