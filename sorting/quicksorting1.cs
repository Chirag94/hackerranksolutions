using System;
using System.Collections.Generic;

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
            foreach(var i in arr){
                if (i > pivot) rightlist.Add(i);
                else if (i < pivot) leftlist.Add(i);
                else if (i == pivot) pivotlist.Add(i);

            }
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
