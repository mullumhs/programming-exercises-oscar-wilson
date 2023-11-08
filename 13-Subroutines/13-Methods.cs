using System;

/*
===============================================================================
PROJECT 13: METHODS
===============================================================================
Objective:
- Understand and practice creating and calling methods in C#.

Main Tasks:
1. Create a method called "SayHello" to print the message "Hello World".
2. Create a method called "Exit" to print the message "Press any key to exit..." and wait for user input.

Questions:
1. What is a method?
A set of instructions that are performed when the method is called. It's like an abbreviation sort of idk i cant describe it
2. What does the 'void' keyword mean?
It's used to return a method that does not return a value
3. What does it mean to 'call' a method?
When you call a method, you jump to perform the code that the method contains 

Extension Tasks:
1. Try creating extra methods that do whatever you like.
2. Try calling the methods multiple times.
3. Try calling methods from within another method.

Additional Resources:
- Methods: https://www.tutorialspoint.com/csharp/csharp_methods.htm
- Methods: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_13_Methods
    {
        static void Main(string[] args)
        {
            // Call the methods here
            SayHello();
            SayGoodbye();
            SayGoodbye();
            SayHello();
            Exit();
        }

        private static void SayGoodbye()
        {
            Console.WriteLine("Goodbye World");
        }

        static void SayHello() 
        {
            Console.WriteLine("Hello World");
            SayGoodbye();
        }
        static void Exit()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        // Write your methods here

    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/