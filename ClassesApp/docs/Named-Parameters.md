# Named Parameters  

`Named Parameters` are when we enter the `name` of the `parameter` when we're passing an `argument` .

```cs
// Program.cs

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNum(15, 25));

            // Using the named parameter 
            Console.WriteLine(AddNum(firstNum: 23,secondNum: 25)); 👈
            Console.WriteLine(AddNum(firstNum: 23, 14)); 👈
            Console.WriteLine(AddNum(10, secondNum: 25)); 👈

            Console.ReadKey();
        }

        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
```
💚 : When we have many parameters, it's make it simpler to passing those arguments .