using System;
namespace Arrays
{
    public class MainClass
    {
        public static void Main()
        {
            int[] Iarr = new int[5];
            string[] Sarr = new string[5];
            Console.WriteLine("Enter the elements of Int array (only five)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the element {0} : ",i+1);
                Iarr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Enter the elements of String array (only five)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the element {0} : ",i+1);
                Sarr[i] = Console.ReadLine();

            }

            Console.WriteLine();
            Console.WriteLine("Copying elements of int array to another.....");
            int[] Iarr2 = new int[5];
            Iarr.CopyTo(Iarr2, 0);
            Console.WriteLine();
            Console.WriteLine("Int Array:");
            foreach(int i in Iarr2)
            {
                Console.WriteLine("int array2[{0}]: {1}",i,i);
            }
            string[] Sarr2 = new string[5];
            Sarr.CopyTo(Sarr2, 0);
            Console.WriteLine();
            Console.WriteLine("Sring Array:");
            foreach (string i in Sarr2)
            {
                Console.WriteLine("string array2[{0}]: {1}", i, i);
            }

            Console.WriteLine();
            Console.WriteLine("Reversing the array.....");
            Array.Reverse(Iarr);
            Console.WriteLine();
            Console.WriteLine("Int Array:");
            for (int i=0; i<Iarr.Length; i++)
            {
                Console.WriteLine("int array[{0}]: {1}", i, Iarr[i]);
            }
            Array.Reverse(Sarr);
            Console.WriteLine();
            Console.WriteLine("String Array:");
            for (int i= 0; i < Sarr.Length; i++)
            {
                Console.WriteLine("string array[{0}]: {1}", i, Sarr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Sorting the array.....");
            Array.Sort(Iarr);
            Console.WriteLine();
            Console.WriteLine("Int Array:");
            for (int i = 0; i < Iarr.Length; i++)
            {
                Console.WriteLine("int array[{0}]: {1}", i, Iarr[i]);
            }
            Array.Sort (Sarr);
            Console.WriteLine();
            Console.WriteLine("String Array:");
            for (int i = 0; i < Sarr.Length; i++)
            {
                Console.WriteLine("string array[{0}]: {1}", i, Sarr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Performing Clear in the array.....");
            Array.Clear(Iarr);
            Console.WriteLine();
            Console.WriteLine("Int Array: ");
            foreach (int i in Iarr)
            {
                Console.WriteLine("int array[{0}]: {1}", i, i);
            }
            Array.Clear (Sarr);
            Console.WriteLine();
            Console.WriteLine("String Array:");
            foreach (string i in Sarr)
            {
                Console.WriteLine("string array[{0}]: {1}", i, i);
            }

        }
    }
}