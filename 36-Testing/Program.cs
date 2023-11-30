using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _36_Testing
{
    internal class Program
    {
        // USE THIS FILE FOR TESTING AND EXPERIMENTATION

        static void Main(string[] args)
        {
            // Write your code here
            int x = 1;
            int y = 0;
            for (int i = 0; i < 1000000000; i=x+y)
            {
                Console.WriteLine(i);
                y = x;
                x = i;
            }



            // Wait for input before ending
            Console.ReadLine();
        }
    }
}
