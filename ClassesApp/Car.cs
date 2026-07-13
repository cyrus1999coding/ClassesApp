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
        public static int NumberOfCars = 0;

        // member variable
        // private string _model = "";
        private string _brand = "";
        //private bool _isLuxury;

        // property
        // public string Model1 { get => _model; set => _model = value; }
        public string Model { get; set; }
        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else 
                {
                    return _brand; 
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered Nothing!");
                    _brand = "Default Value";
                }
                else
                {
                    _brand = value;
                }

            }
        }

        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
        public bool IsLuxury { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="model">The model name of the car.</param>
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;

            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("A car of the model " + Model + " With brand of " + Brand + " has been created Successfully");
        }

        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} driving, And I'm driving");
        }

    }
}
