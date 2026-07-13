namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer();

            customer1.GetDetails();
            customer2.GetDetails();
            customer3.GetDetails();

            Console.WriteLine("Customer 3 id is " + customer3.Id);

            Console.ReadKey();
        }

    }
}
