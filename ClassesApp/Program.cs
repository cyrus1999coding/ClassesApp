namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("A3","Audi",false);
            Car myBMW = new Car("i7", "BMW ", true);
            myAudi.Drive();
            myBMW.Drive();

            Console.ReadKey();
        }
    }
}
