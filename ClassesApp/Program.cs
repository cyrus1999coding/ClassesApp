namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("Blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();

            Console.ReadKey();
        }

    }
}
