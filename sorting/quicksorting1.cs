﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace sorting
{
    public class quicksorting1
    {
        static int[] quickSort(int[] arr)
        {
            // Complete this function
            List<int> leftlist = new List<int>();
            List<int> rightlist = new List<int>();
            List<int> pivotlist = new List<int>();

            int pivot = arr[0];
            foreach (var i in arr)
            {
                if (i > pivot) rightlist.Add(i);
                else if (i < pivot) leftlist.Add(i);
                else if (i == pivot) pivotlist.Add(i);

            }
            var v1 = from s in arr where s < pivot select s;
            var v2 = arr.Where(s => s < pivot);
            var v3 = from k in arr orderby k select k;
            leftlist.AddRange(pivotlist);
            leftlist.AddRange(rightlist);
            return leftlist.ToArray();

        }

        static void Mainh(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = quickSort(arr);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}
