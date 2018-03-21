using System;
using System.Collections.Generic;

namespace sorting
{
    public class findmedian
    {
        static int findMedian(int[] arr)
        {
            // Complete this function
            List<int> elements = new List<int>();
            foreach(var i in arr){
                elements.Add(i);
            }
            elements.Sort();
            return elements[arr.Length / 2];
        }

        static void Mains(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = findMedian(arr);
            Console.WriteLine(result);
        }
    }
}
