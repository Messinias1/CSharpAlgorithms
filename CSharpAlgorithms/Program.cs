using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var dayReturned = Console.ReadLine().Split(' ');

        var expectedReturn = Console.ReadLine().Split(' ');

        int[] numbers = Array.ConvertAll(dayReturned, int.Parse);
        int[] numbers1 = Array.ConvertAll(expectedReturn, int.Parse);

        var fine = 0;

        for (var i = 0; i < numbers.Length; i++)
        {
            if (numbers[0] > numbers1[0])
            {
                fine = (15 * (numbers[0] - numbers1[0]));
            }
            if (numbers[1] > numbers1[1])
            {
                fine = (500 * (numbers[1] - numbers1[1]));
            }
            if (numbers[2] > numbers1[2])
            {
                fine = 10000;
            }
            if (numbers[2] < numbers1[2])
            {
                fine = 0;
            }
        }
        Console.WriteLine(fine);
    }
}

