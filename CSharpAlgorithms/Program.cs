using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace CSharpAlgorithms
{
    class Program
    {
        // Complete the solve function below.
        //static void solve(double meal_cost, int tip_percent, int tax_percent)
        //{
        //    double tip = meal_cost * tip_percent / 100;
        //    double tax = meal_cost * tax_percent / 100;

        //    double totalCost = meal_cost + tip + tax;

        //    Console.WriteLine(Math.Round(totalCost));

        //}
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        

        //double meal_cost = Convert.ToDouble(Console.ReadLine());

        //int tip_percent = Convert.ToInt32(Console.ReadLine());

        //int tax_percent = Convert.ToInt32(Console.ReadLine());

        //solve(meal_cost, tip_percent, tax_percent);

        //int i = 4;
        //double d = 4.0;
        //string s = "HackerRank ";

        //// Declare second integer, double, and String variables.
        //int i2;
        //double d2;
        //string s2;
        //// Read and save an integer, double, and String to your variables.
        //i2 = Convert.ToInt32(Console.ReadLine());
        //d2 = Convert.ToDouble(Console.ReadLine());
        //s2 = Console.ReadLine();

        //// Print the sum of both integer variables on a new line.
        //Console.WriteLine(i + i2);
        //// Print the sum of the double variables on a new line.
        //var added = d + d2;
        //Console.WriteLine(added.ToString("0.0"));
        //// Concatenate and print the String variables on a new line
        //// The 's' variable above should be printed first.
        //Console.WriteLine(s + s2);
    }
    }
}
