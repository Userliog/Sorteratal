﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int length = 1000;
            Console.WriteLine("Bubblesort w."+length);
            for (int i = 0; i < length; i++)
            {
               Random rnd = new Random();
                list.Add(rnd.Next(10000)); 
            }
            Stopwatch stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < (length-1); i++)
            {
                for (int j = 0; j < (length-1-i); j++)
                {
                    if (list[j]<list[(j+1)])
                    {
                        int a = list[j];
                        int b = list[j+1];
                        list[j]=b;
                        list[j+1]=a;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds+" ms");
        }
    }
}