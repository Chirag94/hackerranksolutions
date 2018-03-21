using System;
namespace sorting
{
    public class insertionsort2
    {
        static void insertionSort2(int n, int[] arr)
        {
            // Complete this function
            //1 4 5 3 6 2
            int j;
            int key;
            for (int i = 1; i < n;i++){
                j = i - 1;
                key = arr[i];
                //check if arr[i] is correctply placed or not
                //check for n=0 to i, if arr[i] is greater or not
                //if not insert arr[i] to that position and shift right till then
                while(j>=0&&arr[j]> key){
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                foreach (var temp in arr)
                {
                    Console.Write(temp + " ");
                }
                Console.WriteLine("");
                }
                
            }


        static void Maind(String[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            insertionSort2(n, arr);
        }
    }
}
