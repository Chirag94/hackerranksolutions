using System;
using System.Collections.Generic;

namespace practiceInterview
{
    public class bigsorting
    {
        public bigsorting()
        {
        }
        static string[] bigSorting(string[] arr)
        {
            //4 ,2 ,5, 1
            List<String> biglistsorted = new List<string>();
            HashSet<String> hashlist = new HashSet<string>();
            String temp = "";
            for (int i = 0; i < arr.Length;i++){
                for (int j = i + 1; j < arr.Length;j++){
                    
                    if(isgreater(arr[i],arr[j])){
                        //swap them
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }



           return arr;
       
        }

        private static bool isgreater(string k, string i)
        {
            if (k.Length > i.Length) return true;
            if (k.Length < i.Length) return false;
            for (int temp = 0; temp < k.Length;temp++){
                if (k[temp] == i[temp]) continue;
                if (k[temp] > i[temp]) return true;
                if (k[temp] < i[temp]) return false;

            }
            return false;
        }

        static void Mains(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
            {
                arr[arr_i] = Console.ReadLine();
            }
            string[] result = bigSorting(arr);
            Console.WriteLine(String.Join("\n", result));


        }
    }
}
