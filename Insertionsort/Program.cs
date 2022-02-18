﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10000;
            Console.WriteLine("insertion sort w. "+length);
            
            List<int> List = new List<int>();
            
            int n =length, j, temp, flag;
            
            for (int s = 0; s < length; s++)
            {
               Random rnd = new Random();
                List.Add(rnd.Next(10000)); 
            }
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < n; i++)
            {
                temp=List[i];
                flag=0;
                for (j =i-1;j >= 0 && flag != 1; )
                {
                    if (temp < List[j])
                    {
                        List[j+1] = List[j];
                        j--;
                        List[j+1] = temp;
                    }
                    else flag =1;
                }
            }
            

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds+" ms");
        }
    }
}