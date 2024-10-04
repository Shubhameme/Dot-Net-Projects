using System;

namespace ConsoleApp1
{
    class Shubham
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 9, 5, 2, 1, 3, 4, 6, 8 };
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            }

           foreach(int item  in arr)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
