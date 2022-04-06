using System;
public class Program
{
    public static void Swaping(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
    public static void Main()
    {
        Console.WriteLine("Enter the first number(a): ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number(b): ");
        int b = int.Parse(Console.ReadLine());

        Swaping(ref a, ref b);

        Console.WriteLine("After swaping the values a = {0} and b = {1}", a, b);
    }
}