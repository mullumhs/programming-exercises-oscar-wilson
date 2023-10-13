using System;

/*
===============================================================================
PROJECT 02: VARIABLES
===============================================================================
Objective:
- Understand and practice declaring variables and manipulating string data.

Main Tasks:
1. Create a string variable and assign it a value.
2. Output a message that contains this variable.
3. Make the program wait for input.

Questions:
1. What is a variable?
A variable holds information that can vary!!!!!!
2. What is a string?
A string is text

Extension Tasks:
1. Try creating two string variables and using them in the same message.
2. Use Google to work out how to change a variable to uppercase or lowercase before outputting it.

Additional Resources:
- Variables: https://www.tutorialspoint.com/csharp/csharp_variables.htm
- Data Types: https://www.tutorialspoint.com/csharp/csharp_data_types.htm
- String Manipulation: https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_02_Variables
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            string name = "Kittenwhiskers";
            string title = "Sir ";
            Console.WriteLine("Greetings " + title.ToUpper() + name.ToLower() + "! ;3");
            Console.Beep(440, 400);
            Console.Beep(440, 200);
            Console.Beep(660, 800);
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
