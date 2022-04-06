using System;
public class Circle
{
    private static float PI = 3.14F;

    public float r { get; set; }

    public void Area()
    {
        Console.WriteLine("Area of the circle with radius {0} is {1}", r, (PI * r * r));
    }
    public void Circumference()
    {
        Console.WriteLine("Circumference of the circle with radius {0} is {1}", r, (PI * r * 2));
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the radius of the circle:");
        float r = float.Parse(Console.ReadLine());
        Circle c = new Circle();
        c.r = r;
        c.Area();
        c.Circumference();
    }
}