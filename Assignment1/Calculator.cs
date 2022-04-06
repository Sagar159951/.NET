using System;

public class Calc
{
    public static void Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine("Addition of {0} and {1} is: {2}.",a,b,c);
    }
    public static void Substract(int a, int b)
    {
        int c = a - b;
        Console.WriteLine("Substraction of {0} and {1} is: {2}.", a, b, c);
    }
    public static void Multiply(int a, int b)
    {
        int c = a * b;
        Console.WriteLine("Multiplicatoin of {0} and {1} is: {2}.", a, b, c);
    }
    public static void Divide(int a, int b)
    {
        float c = (float)a / b;
        Console.WriteLine("Division of {0} and {1} is: {2}.", a, b, c);
    }
    public static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        Add(a, b);
        Substract(a, b);
        Multiply(a, b);
        Divide(a, b);

    }
}