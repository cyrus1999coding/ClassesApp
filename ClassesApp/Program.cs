namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.SetDetails("Denis", "MainStreet");

            Customer.DoSomeCustomerStuff();

            Console.ReadKey();
        }

    }
}
