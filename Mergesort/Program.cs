using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mergesort
{
    public class Program
    {
        static public void Merge(int[] List, int left, int middle, int right) {
         int i, j;
         int nleft = middle - left + 1;
         int nright = right - middle;
         int[] L = new int[nleft];
         int[] R = new int[nright];
         for (i = 0; i < nleft; i++) {
            L[i] = List[left + i];
         }       
         for (j = 0; j < nright; j++) {
            R[j] = List[middle + 1 + j];
         }
         i = 0;
         j = 0;
         int k = left;
         while (i < nleft && j < nright) {
            if (L[i] <= R[j]) {
               List[k] = L[i];
               i++;
            } else {
               List[k] = R[j];
               j++;
            }
            k++;
         } 
         while (i < nleft){
            List[k] = L[i];
            i++;
            k++;
         }
         while (j < nright){
            List[k] = R[j];
            j++;
            k++;
         }
      }
      static public void MergeSort(int[] List, int left, int right) {
         if (left < right) {
            int middle = (left + right) / 2;
            MergeSort(List, left, middle);
            MergeSort(List, middle + 1, right);
            Merge(List, left, middle, right);
         }
      }

        public static void Main(string[] args)
        {
            int length = 8000;
            Console.WriteLine("Mergesort w. " + length);
            int[] List = new int[length];
            Random rnd = new Random();
            for (int s = 0; s < length; s++)
            {
                List[s] = rnd.Next(100000);
            }
            Stopwatch stopwatch = Stopwatch.StartNew();
            MergeSort(List, 0, length-1);
            stopwatch.Stop();
            
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(List[i]);
            }
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}