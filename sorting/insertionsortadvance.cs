using System;
namespace sorting
{
    public class insertionsortadvance
    {
        static int insertionSort(int[] A)
        {
            var j = 0; int count = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && A[j] > value)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                    count++;
                }
                A[j + 1] = value;
            }
            return(count);
        }

        static void Mains(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                int result = insertionSort(arr);
                Console.WriteLine(result);
            }
        }
    }
}


