namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3","german");
            Car bmw = new Car("I7","austulia");

            audi.Model1 = "";

            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}
