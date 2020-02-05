using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int i2;
            double d2;
            string s2;
            // Read and save an integer, double, and String to your variables.
            i2 = Convert.ToInt32(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());
            s2 = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);
            // Print the sum of the double variables on a new line.
            var added = d + d2;
            Console.WriteLine(added.ToString("0.0"));
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);
        }
    }
}
