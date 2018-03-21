using System;
using System.Collections.Generic;

namespace sorting
{
    class MainClass
    {
        static int introTutorial(int V, int[] arr)
        {
            // Complete this function
            List<int> lisr = new List<int>();
            foreach(var i in arr){
                lisr.Add(i);
            }
            lisr.Sort();
            return lisr.IndexOf(V);
        }

        static void Maina(String[] args)
        {
            int V = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = introTutorial(V, arr);
            Console.WriteLine(result);
        }
    }
}
