using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int n)
    {
        int result = 0;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {

            if (n % i == 0)
            {
                if (i == (n / i))
                    result += i;
                else
                    result += (i + n / i);
            }
        }
        if (n == 1)
            return n;

        return (result + 1 + n);
    }
}

class Solution
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}