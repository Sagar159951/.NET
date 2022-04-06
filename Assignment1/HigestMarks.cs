using System;

public class HigestMarks
{
    public static void Main()
    {
        int max = 0;
        int[] marks = new int[5];
        for (int i = 0; i < 5; i++)
        {   
            Console.WriteLine("Enter the marks of Student "+(i+1)+": ");
            marks[i] = int.Parse(Console.ReadLine());
            max = Math.Max(max, marks[i]);
        }

        Console.WriteLine("Maximum marks among these students is : {0}", max);
    }
}
