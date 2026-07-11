namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3","german");
            Car bmw = new Car("I7","austulia");

            Console.Write("Please enter the Brand name: ");

            // Setting _brand
            audi.Brand = Console.ReadLine();

            // Gettig _brand
            Console.WriteLine("You entered " + audi.Brand);

            Console.ReadKey();
        }
    }
}
