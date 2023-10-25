using System;

/*
===============================================================================
PROJECT 05: INPUT
===============================================================================
Objective:
- Understand and practice obtaining user input and using it in a program.

Main Tasks:
1. Ask for the user's name.
2. Assign the result to a variable.
3. Output a message containing the user's name, e.g., "Hello John!".
4. Wait for input before closing the program.

Questions:
1. What does assignment mean? What is the assignment operator?
2. Explain what Console.ReadLine() does.

Extension Tasks:
1. Ask for multiple inputs.
2. Research how to input a type other than string.

Example:
- Below is an example of creating a string variable and assigning to it with user input:
    
    string example = Console.ReadLine();

Additional Resources:
- Input: https://www.w3schools.com/cs/cs_user_input.php
- Assignment: https://www.w3schools.com/cs/cs_operators_assignment.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_05_Input
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            char quotes = '"';
            

            Console.WriteLine($"\n{name.ToUpper()}: {quotes}Hello World!{quotes}");
            Console.Beep(440, 500);

            Console.WriteLine($"COMPUTER: {quotes}There is no World, only TextVoid...{quotes}");
            Console.Beep(220, 700);

            Console.WriteLine($"{name.ToUpper()}: {quotes}What's TextVoid?{quotes}");
            Console.Beep(440, 500);

            Console.WriteLine($"COMPUTER: {quotes}...{quotes}");
            Console.Beep(220, 1500);

            Console.WriteLine($"COMPUTER: {quotes}...{quotes}");
            Console.Beep(220, 1500);

            Console.WriteLine("\nYou should probably run.");
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
