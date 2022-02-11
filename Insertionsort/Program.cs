using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bubble_sort
{
    class Program
    {
        public static void Swap(ref int a, ref int b){
            int Temp=a;
            a=b;
            b=Temp;
        }

        static void Main(string[] args)
        {
            int length = 1000;
            Console.WriteLine("insertion sort w. "+length);
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<int> A = new List<int>();
            
            int n =length, j, val, flag;
            
            for (int s = 0; s < length; s++)
            {
               Random rnd = new Random();
                A.Add(rnd.Next()); 
            }

            for (int i = 0; i < n; i++)
            {
                val=A[i];
                flag=0;
                for (j =i-1;j >= 0 && flag != 1; )
                {
                    if (val < A[j])
                    {
                        A[j+1] = A[j];
                        j--;
                        A[j+1] = val;
                    }
                    else flag =1;
                }
            }
            

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds+" ms");
        }
    }
}