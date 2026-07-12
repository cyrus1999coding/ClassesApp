namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNum(15, 25));

            // Using the named parameter 
            Console.WriteLine(AddNum(firstNum: 23,secondNum: 25)); 

            Console.ReadKey();
        }

        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
