using System;
namespace sorting
{
    public class insertionsort
    {
        static void insertionSort1(int n, int[] arr)
        {
            //2 4 6 8 3
                int unsortedelement = arr[n - 1];
            bool sorted = false;

            for (int i = n - 2; i >= 0; i--)
            {
                if (!sorted)
                {
                    if (arr[i] > unsortedelement)
                    {
                        //swap the element to one position right
                        arr[i + 1] = arr[i];
                    }
                    else
                    {
                        arr[i + 1] = unsortedelement;
                        sorted = true;
                    }
                    foreach (int k in arr)
                    {
                        Console.Write(k + " ");
                    }
                    Console.WriteLine("");
                }
            }
            if(!sorted){
                arr[0] = unsortedelement;
                foreach (int k in arr)
                    {
                        Console.Write(k + " ");
                    }

            }
        }
        public static void Main1(String []args){
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            insertionSort1(n, arr);

        }
    }
}
