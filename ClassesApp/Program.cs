namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);

            Console.WriteLine("Number of car produced " + Car.NumberOfCars);

            Console.ReadKey();
        }

    }
}
