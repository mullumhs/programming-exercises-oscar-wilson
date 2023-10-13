using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?
input is what the user puts into the computer
output is what the computer puts out

Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("Uwu~! Here's this cute lil' E7 chord turned AMaj7 chord progression for you~!");
            // E7
            Console.Beep(495, 100);
            Console.Beep(587, 100);
            Console.Beep(660, 100);
            Console.Beep(825, 100);
            Console.Beep(990, 100);
            Console.Beep(1174, 100);
            Console.Beep(1320, 100);
            Console.Beep(1650, 100);
            // AMaj7
            Console.Beep(440, 100);
            Console.Beep(550, 100);
            Console.Beep(660, 100);
            Console.Beep(825, 100);
            Console.Beep(880, 100);
            Console.Beep(1100, 100);
            Console.Beep(1320, 100);
            Console.Beep(1650, 100);
            // meow
            Console.WriteLine("Press enter to free yourself from the shackles of my reality~! ;3");
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
no thabks, hes wrong!!


===============================================================================
*/