using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int res = 0;
        int count = 1;
        Console.WriteLine(max);

        while(count <= max)
        {
            res+=count;
            count++;
        }
        return res*res;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int res = 0;
        int count = 1;

        while(count <= max)
        {
            res += count*count;
            count++;
        }
        return res;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return DifferenceOfSquares.CalculateSquareOfSum(max) - DifferenceOfSquares.CalculateSumOfSquares(max);
    }
}
