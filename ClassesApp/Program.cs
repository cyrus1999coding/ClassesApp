namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("frankTheTank","Mainstreet 1","123123");

            Customer myCustomer = new Customer();

            myCustomer.SetDetails("Frank", "MainStreet 2", "123123");

            Console.WriteLine("Details abot customer: "+ myCustomer.Name);

            Console.ReadKey();
        }
    }
}
