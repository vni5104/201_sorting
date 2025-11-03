using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize arr1 and arr2
            int[] arr1 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] arr2 = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            //print and sort arr1
            Console.WriteLine("Contents of arr1 before sorting:");
            Console.WriteLine("{ " + string.Join(", ", arr1) + " }");
            
            StudentBubbleSort(arr1);
            Console.WriteLine("Contents of arr1 after sorting:");
            Console.WriteLine("{ " + string.Join(", ", arr1) + " }");

            //print and sort arr2
            Console.WriteLine("\nContents of arr2 before sorting:");
        }

        static void StudentBubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    }
                }
            }
        }
    }
}
