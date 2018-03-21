using System;
using System.Collections.Generic;

namespace sorting
{
    public class countingsort2
    {
        static int[] countingSort(int[] arr)
        {
            // Complete this function
            List<int> l = new List<int>();
            foreach(var i in arr){
                l.Add(i);
            }
            l.Sort();
            return l.ToArray();
        }

        static void Mains(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = countingSort(arr);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}
