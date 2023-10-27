using System;

/*
===============================================================================
PROJECT 09: PICK A DOOR
===============================================================================
Objective:
- Practice using selection statements with multiple conditions to control program flow based on user input.

Main Tasks:
1. Prompt the user to pick a door by entering a number (1, 2, or 3), and store the result in a string variable.
2. Use a selection statement (if...else if...else) to determine and output what is behind each door.
3. Print a warning message if the user picks something other than 1, 2, or 3.
4. Wait for input before ending the program.

Questions:
1. What is the purpose of the final ELSE statement in this program?
2. What is the difference between the = operator and the == operator?

Extension Tasks:
1. Use more else if statements to create more doors.
2. Customise the program to output a personalised message to the user (e.g., including their name).
3. Research online to learn how to generate a random number, and use this number to pick a door for the user.

Example:
- Below is an example of the program's output:

    Pick a Door: 1, 2 or 3
    2
    You win a Car!

Additional Resources:
- Selection Statements: https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
- if-else Statement: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else
- Random Numbers: https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_09_PickADoor
    {
        static void Main(string[] args)
        {
            // Ask the user to pick a door
            char quote = '"';
            Console.WriteLine($"GAME SHOW HOST: {quote}Pick a Door: A, B or C{quote}");
            Console.Beep(200, 500);

            // Your code goes below here
            string door = Console.ReadLine().ToUpper();
            if (door == "A" || door == "B" || door == "C")
            {
                Console.WriteLine("hint: pick another door");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"GAME SHOW HOST: {quote}...{quote}");
                Console.Beep(200, 1000);
                Console.WriteLine("The game show host collapses onto the floor-- he was not designed to handle any input besides A, B or C. \nHe starts to shake violently as an exit door materialises out of thin air.");
                Console.Beep(600, 500);
                Console.WriteLine("Go to the door? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("\nYou run to the door, but hesitate to open it.");
                    Console.Beep(600, 500);
                    Console.WriteLine("Open it? y/n");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "y")
                    {
                        Console.WriteLine("\nPress enter to escape");
                        Console.Beep(600, 500); Console.Beep(700, 300); Console.Beep(800, 800);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\nThe game show host exploded. You died.");
                        Console.ReadLine();
                    }
                }
                else if (answer == "n")
                {
                    Console.WriteLine("\nThe game show host exploded. You happily died painfully.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nThe game show host exploded. Your hesitation allowed for it to kill you.");
                    Console.ReadLine();
                }
            }
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/
