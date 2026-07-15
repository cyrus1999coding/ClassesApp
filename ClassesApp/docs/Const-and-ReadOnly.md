# Const and ReadOnly

We're goign to learn how `const` **Keyword** works, how `readonly` **Keyword** work and then  
We compare them to each other .

⚖ :  
- Both of them allow us to create a variable that is 🔑`readonly` and that is 🔑`Immutable` .  
- So both of them define `non-modifiable fields` .

🚩 :  
- When they are initialized .
- Their usage contexts .
- `const` is the sme for any `Object` of the `Class`, While read only could be difference from `Object` to `Object` .


```
// Rectangle.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Rectangle
    {
        // In C#, const and readonly are two keywords used to define non-modifiable fields,
        // but they differ in terms of when they are initialized and their usage contexts.
        // Understanding the differences between these two can help in deciding which one
        // to use based on specific requirements.

        // declaration of field. 
        public const int NumberOfCorners = 4; 👈
        // declaration of field
        // public readonly string Color = "Blue"; 👈 ✅
        public readonly string Color;

        // Readonly field: A unique identifier for each rectangle instance.
        private readonly string _id;

        public Rectangle(string color)
        {
            Color = color;
        }

        // Method to display the details of the rectangle
        public void DisplayDetails()
        {

            Console.WriteLine($"Color: {Color}, Width: {Width}, " +
                $"Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners}");
        }


        public double Width { get; set; }
        public double Height { get; set; }

        // Computed property

        // Read Only Prop
        public double Area
        {
            get { return Width * Height; }
        }

    }
}
```
- `public const int NumberOfCorners = 4;` :  
  The rectangle has 4 corners and that is constant, that will always be the same no matter which  
  rectangle we make it's going to 4 corners .
  - 🔑`const` has to be 🔑`initialized during the compile time`, So it needs to get a value  
    During **compile time** which means directly in the code in the line where it's created .
  - ⛔ So we can't use `Method` here that would Assign a value to it .

- `public readonly string Color = "Blue";` :  
  The color of the rectangle in our Class has to be eighter :
  - `initialized during declaration` .
  - in the `Constructor` .
  - ✅ It's fine if it is only `Assigned during the runtime`, So when it's initialized only  
    during `runtime` which means it will get a value Assigned to it during runtime .

- `Constructor` :  
  ```cs
    public Rectangle(string color)
    {
        Color = color;
    }
  ```
  - for setting the → `public readonly string Color;` .

- 🔑 Every single `Rectangle` `Object` will have → `public const int NumberOfCorners = 4;`

```cs
// Program.cs

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
```
```console
Color: Red👈, Width: 0, Height: 0, Area: 0, Number of Corners: 4👈
Color: Blue👈, Width: 0, Height: 0, Area: 0, Number of Corners: 4👈
```

| Member               | Convention                   | Example                                                      |
| -------------------- | ---------------------------- | ------------------------------------------------------------ |
| Private field        | `_camelCase`                 | `_id`, `_password`, `_width`                                 |
| Private static field | `camelCase` or `s_camelCase` | `nextId` (older style), `s_nextId` (Microsoft's newer style) |
| Public field         | `PascalCase`                 | `NumberOfCorners`                                            |
| Property             | `PascalCase`                 | `Width`, `Height`, `Area`                                    |
| Method               | `PascalCase`                 | `DisplayDetails()`, `SetDetails()`                           |
| Class                | `PascalCase`                 | `Rectangle`, `Customer`                                      |
| Constant (`const`)   | `PascalCase`                 | `NumberOfCorners`, `MaxSpeed`                                |
| Local variable       | `camelCase`                  | `count`, `totalPrice`                                        |

- This is one of the major difference between `const` and `readonly` **Keywords** .

```cs
// Rectangle.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Rectangle
    {
        // In C#, const and readonly are two keywords used to define non-modifiable fields,
        // but they differ in terms of when they are initialized and their usage contexts.
        // Understanding the differences between these two can help in deciding which one
        // to use based on specific requirements.

        // declaration of field. 
        public const int NumberOfCorners = 4;
        // declaration of field
        public readonly string Color = "Blue";
        //public readonly string Color;

        // Readonly field: A unique identifier for each rectangle instance.
        private readonly string _id;

        public Rectangle(string color)
        {
            Color = color;
        }

        // Method to display the details of the rectangle
        public void DisplayDetails()
        {
            Color = "Gray"; 👈❌

            Console.WriteLine($"Color: {Color}, Width: {Width}, " +
                $"Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners}");
        }


        public double Width { get; set; }
        public double Height { get; set; }

        // Computed property

        // Read Only Prop
        public double Area
        {
            get { return Width * Height; }
        }

    }
}

```
- ❌ : A readonly field cannot be assigned to (except in a constructor or 🔑`init-only setter` of `the type in which the field is defined` or a 🔑`variable initializer`) .  
- ✅ : As we mentioend earlier just in the `constructor` or where we `define` this readonly filed .
- 🔑🔑 : 
  ```cs
  public const int NumberOfCorners = 4;
  public👈 readonly string Color = "Blue";
  ```
  `const` and `readonly` variables are used with `PascalCase` naming .
- 🔑🔑 if we have a `readonly filed` that is `private👈 field` for that particular variable :  
  ```cs
  private👈 readonly string _id
  ```
  Then this will be `_id` .  
  This naming convation overwrites this `naming convention` → `public👈 readonly string _id` .  
  But only for the case that is `private` .