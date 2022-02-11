using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mergesort
{
    class Program
    {
        static public void Merge(List A, int b, int c, int d)
        {
            int y, z;
            int l1 = c-b+1;
            int r1 = d-b;
            List[] L = new List[l1];
            List[] R = new List[r1];
            for (int i=0; y<r1; y++)
            {
                L[i] = A[b+i];
            }
            for (y = 0; y < r1; y++)
            {
                R[y] = A[c+1+y];
            }
        }
        static public void Merge_sort(List A, int b, int c)
        {
            if (b<c)
            {
                int d= (b+c)/2;
                Merge_sort(A, b, d);
                Merge_sort(A, d+1, c);
                Merge(A, b, d, c);
            }
        }
        
        static void Main(string[] args)
        {
            int length = 1000;
            Console.WriteLine("Merge sort w. "+length);
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<int> A = new List<int>();
            int n =length;
            
            for (int s = 0; s < length; s++)
            {
               Random rnd = new Random();
                A.Add(rnd.Next()); 
            }



            foreach (int b in A)
            {
                Console.WriteLine(b);   
            }
           
        }
    }
}
