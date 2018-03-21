using System;
using System.Collections.Generic;

namespace practiceInterview
{
    public class duplicate
    {
        public duplicate()
        {
        }
        static int[] countingSort(int[] ar)
        {
            // Complete this function
            List<int> flist = new List<int>();
            List<int> list = new List<int>();
            foreach (var i in ar)
            {
                list.Add(i);
            }
            Dictionary<int, int> dic = new Dictionary<int, int>();
            Dictionary<int, List<int>> places = new Dictionary<int, List<int>>();
            int count;
            List<int> placesList = new List<int>();
            for (int i = 0; i <= 99; i++)
            {


                count = 0;
                foreach (var t in list)
                {
                    if (t == i)
                    {

                        count++;
                    }
                }
                if (!dic.ContainsKey(i))
                {
                    dic.Add(i, count);
                    //  places.Add(k, list.FindAll(temp=> { list[temp] == k return temp}));
                }
            }
            foreach (var i in dic)
            {
               // Console.WriteLine(i.Key + " occurred " + i.Value + " times");
                flist.Add(i.Value);

            }
            return flist.ToArray();
        }
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] result = countingSort(arr);
            Console.WriteLine(String.Join(" ", result));


        }

    }
}

