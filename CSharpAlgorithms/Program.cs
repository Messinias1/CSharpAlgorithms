﻿using System.CodeDom.Compiler;
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
    //class Person
    //{
    //    public int age;
    //    public Person(int initialAge)
    //    {
    //        // Add some more code to run some checks on initialAge
    //        if (initialAge < 0)
    //        {
    //            age = 0;
    //            Console.WriteLine("Age is not valid, setting age to 0.");
    //        }
    //        age = initialAge;
    //    }
    //    public void amIOld()
    //    {
    //        // Do some computations in here and print out the correct statement to the console 
    //        if (age < 13)
    //            Console.WriteLine("You are young.");

    //        else if (age >= 13 && age < 18)
    //            Console.WriteLine("You are a teenager.");

    //        else
    //            Console.WriteLine("You are old.");
    //    }

    //    public void yearPasses()
    //    {
    //        // Increment the age of the person in here
    //        age++;
    //    }
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
        // Complete the factorial function below.
        //static int factorial(int n)
        //{
        //    if (n <= 1)
        //        return 1;
        //    else
        //        return n * factorial(n - 1);

        //    Console.WriteLine(n);
        //}
        static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> PhoneBook = new Dictionary<string, int>();

            for (var i = 0; i < input; i++)
            {
                var split = Console.ReadLine().Split(' ');
                var names = split[0];
                var numbers = Convert.ToInt32(split[1]);

                PhoneBook.Add(names, numbers);
            }
            for (var j = 0; j < input; j++)
            {
                var contents = Console.ReadLine();

                if (PhoneBook.ContainsKey(contents))
                {
                    Console.WriteLine("{0}={1}", contents, PhoneBook[contents]);
                }
                else
                    Console.WriteLine("Not found");
            }
        }

        //int n = Convert.ToInt32(Console.ReadLine());

        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //;
        //Array.Reverse(arr);
        //foreach (var el in arr)
        //{
        //    Console.Write(el + " ");
        //}

        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //var input = Convert.ToInt32(Console.ReadLine());

        //for (var i = 0; i < input; i++)
        //{
        //    var S = Console.ReadLine();

        //    for (var j = 0; j < S.Length; j++)
        //    {
        //        if (j % 2 == 0)
        //        {
        //            Console.Write(S[j]);
        //        }
        //    }
        //    Console.Write(" ");
        //    for (var j = 0; j < S.Length; j++)
        //    {
        //        if (j % 2 != 0)
        //        {
        //            Console.Write(S[j]);
        //        }
        //    }
        //    Console.WriteLine(" ");
        //}

        //int n = Convert.ToInt32(Console.ReadLine());

        //for (var i = 1; i < 11; i++)
        //{
        //    Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
        //}

        //int T = int.Parse(Console.In.ReadLine());
        //for (int i = 0; i < T; i++)
        //{
        //    int age = int.Parse(Console.In.ReadLine());
        //    Person p = new Person(age);
        //    p.amIOld();
        //    for (int j = 0; j < 3; j++)
        //    {
        //        p.yearPasses();
        //    }
        //    p.amIOld();
        //    Console.WriteLine();
        //}

        //int N = Convert.ToInt32(Console.ReadLine());
        //if (N % 2 != 0)
        //{
        //    Console.WriteLine("Weird");
        //}
        //else if (N % 2 == 0 && N >= 2 && N <= 5)
        //{
        //    Console.WriteLine("Not Weird");
        //}
        //else if (N % 2 == 0 && N >= 6 && N <= 20)
        //{
        //    Console.WriteLine("Weird");
        //}
        //else if (N % 2 == 0 && N > 20)
        //{
        //    Console.WriteLine("Not Weird");
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
