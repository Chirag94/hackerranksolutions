using System;
using System.Collections.Generic;

namespace sorting
{
    public class closestNumber
    {
        static int[] closestNumbers(int[] arr)
        {
            // Complete this function
            List<int> elements = new List<int>();
            List<int> differences = new List<int>();
            List<int> pairs = new List<int>();
            List<int> results = new List<int>();
            foreach(int i in arr){
                elements.Add(i);
            }
            elements.Sort();
            for (int i = 1; i < elements.Count;i++){
                differences.Add(elements[i] - elements[i - 1]);
            }
            int diff = findMinimum(differences);
            for (int i = 0; i < differences.Count;i++){
                if(differences[i]==diff){
                    pairs.Add(i);
                }
            }

            foreach(int i in pairs){
                results.Add(elements[i]);
                results.Add(elements[i+1]);

            }
            return results.ToArray();

        }

        private static int findMinimum(List<int> differences)
        {
            int min = differences[0];
            for (int i = 1; i < differences.Count;i++){
                if (differences[i] < min) min = differences[i];
            }
            return min; 
        }

        static void Mains(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = closestNumbers(arr);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}

