using System;

public class Program
{
    public static void Sum(params int[] arr)
    {
        int Total = 0;
        foreach (int i in arr)
        {
            Total = Total + i;
        }
        Console.WriteLine("Sum of all passed parameters is: {0}",Total);
    }
    public static void Main()
    {
        int a = 2;
        int b = 3;
        int c = 4;

        Sum(a, b, c);
    }
}