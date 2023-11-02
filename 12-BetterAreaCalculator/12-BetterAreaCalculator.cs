using System;

/*
===============================================================================
PROJECT 12: BETTER AREA CALCULATOR
===============================================================================
Objective:
- Learn how to refactor code into more manageable chunks using methods, improving readability and reusability of the code.

Main Tasks:
1. Copy and paste your program from the previous lesson into this one.
2. Write methods for each of the main functions of the program. E.g. ShowMenu, CalculateRectangle, CalculateTriangle, etc.
3. Move the corresponding code into each method.
4. Call the methods from the Main method.

Questions:
1. What is the purpose of splitting the code into smaller chunks (methods)?
2. Why is it important to give a warning message to the user in the else statement?

Extension Tasks:
1. Add a trapezium option to the program. It should also be a separate method.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Methods: https://www.w3schools.com/cs/cs_methods.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_12_BetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            // Your code goes below here
            ShowMenu();
            string Choice = Console.ReadLine();
            if (Choice == "1")
            {
               CalculateAreaCircle();
            }
            else if (Choice == "2")
            {
                CalculateAreaRectangle();
            }
            else if (Choice == "3")
            {
                CalculateAreaTriangle();
            }
            else
            {
                Console.WriteLine("...");
            }
            Exit();
        }

        static void ShowMenu()
        {
            Console.WriteLine("Choose an opiton:\n1cirl\n2retcale\n3tringle");
        }

        static void CalculateAreaCircle()
        {
            Console.Write("Enter Radius: ");
            double R = Convert.ToDouble(Console.Read());

            Console.WriteLine($"The Area of Circle is {Math.PI * Math.Pow(R, 2)}");
        }

        static void CalculateAreaRectangle()
        {
            Console.Write("Enter Width: ");
            double W = Convert.ToDouble(Console.Read());
            Console.Write("Enter Heigt: ");
            double H = Convert.ToDouble(Console.Read());
            Console.WriteLine($"The Area of Circle is {W * H}");
        }

        static void CalculateAreaTriangle()
        {
            Console.Write("Enter Width: ");
            double W = Convert.ToDouble(Console.Read());
            Console.Write("Enter Heigt: ");
            double H = Convert.ToDouble(Console.Read());
            Console.WriteLine($"The Area of Circle is {0.5 * W * H}");
        }

        static void Exit()
        {
            Console.ReadKey();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/