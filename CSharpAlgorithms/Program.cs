using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public static bool isPrime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            // Console.WriteLine("i: " + i);
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var T = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < T; i++)
        {
            var n = Convert.ToInt32(Console.ReadLine());


            if (n >= 2 && isPrime(n)) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.IO;
//class Solution
//{
//    static void Main(String[] args)
//    {
//        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
//        var T = Convert.ToInt32(Console.ReadLine());
//        for (var t = 0; t < T; t++)
//        {
//            int n, i, flag = 0;

//            n = int.Parse(Console.ReadLine());
//            if (n == 1)
//            {
//                Console.WriteLine("Not prime");
//            }

//            for (i = 2; i <= Math.Sqrt(n); i++)
//            {
//                if (n % i == 0)
//                {
//                    Console.WriteLine("Not prime");
//                    flag = 1;
//                    break;
//                }
//            }
//            if (n >= 2 && flag == 0)
//                Console.WriteLine("Prime");
//        }

//    }
//}



