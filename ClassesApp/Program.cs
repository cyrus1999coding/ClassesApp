namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("frankTheTank", "Mainstreet 1", "5554235467");
            Console.WriteLine($"Name of Customer is: {earl.Name}");  

            Console.ReadKey();
        }
    }
}
