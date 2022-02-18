using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Quicksort
{
    public class Program
    {
        public static int Divide(int[] List, int left, int right)
        {
            int middle= List[left];
            while (true)
            {
                while(List[left] < middle)
                {
                    left++;
                }
                while(List[right] > middle)
                {
                    right--;
                }
                if(left < right)
                {
                    if(List[left] == List[right])
                    {
                        return right;
                    }
                    int temp = List[left];
                    List[left] = List[right];
                    List[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public static void Quicksort(int[] List, int left, int right)
        {
            if(left < right)
            {
                int middle = Divide(List, left, right);
                if (middle > 1)
                {
                    Quicksort(List, left, middle-1);
                }
                if ((middle + 1)< right)
                {
                    Quicksort(List, middle+1, right);
                }
            }
        }

        public static void Main(string[] args)
        {
            int length = 8000;
            Console.WriteLine("Quicksort w. " + length);
            int[] List = new int[length];
            Random rnd = new Random();
            for (int s = 0; s < length; s++)
            {
                List[s] = rnd.Next(100000);
            }
            Stopwatch stopwatch = Stopwatch.StartNew();

            Quicksort(List, 0, length-1);
            stopwatch.Stop();
            
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(List[i]);
            }
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}