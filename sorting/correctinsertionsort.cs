using System;
using System.Linq;

namespace sorting
{
    public class correctinsertionsort
    {
        public static void insertionSort(int[] A)
        {
            //7 4 5 3 6 2
            var j = 0;int count = 0;

            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 &&  A[j]>value)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                    count++;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(count);
        }

        static void Maian(string[] args)
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar);
        }
    }
}
