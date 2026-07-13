namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");

            customer1.GetDetails();
            customer2.GetDetails();

            Console.ReadKey();
        }

    }
}
