using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] arr)
    {
        this.elements = arr;
    }

    public int computeDifference()
    {
        int minEle = this.elements[0];
        int maxEle = this.elements[0];
        for (int i = 1; i < this.elements.Length; i++)
        {
            minEle = Math.Min(minEle, this.elements[i]);
            maxEle = Math.Max(maxEle, this.elements[i]);
        }

        maximumDifference = maxEle - minEle;
        return maximumDifference;
    }


} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}