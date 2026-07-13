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

            customer3.Password = "<user password>";

            customer3.GetDetails();

            Console.ReadKey();
        }

    }
}
