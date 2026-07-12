namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("frankTheTank", "Mainstreet 1", "5554235467");
           

            Customer myCustomer = new Customer();

            Console.Write("Please enter the Customer's name: ");
            myCustomer.Name = Console.ReadLine();

            Console.Write("Please enter the Customer's address: ");
            myCustomer.Address = Console.ReadLine();

            Console.Write("Please enter the Customer's number: ");
            myCustomer.ContactNumber = Console.ReadLine();

            Console.WriteLine($"Details about customer:\n{myCustomer.Name}" +
                $"\n{myCustomer.Address}\n{myCustomer.ContactNumber}");

            Console.ReadKey();
        }
    }
}
