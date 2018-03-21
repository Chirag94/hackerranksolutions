using System;
using System.Collections.Generic;

namespace sorting
{
    public class fradulentalert
    {
        static int activityNotifications(int[] expenditure, int d)
        {
            // Complete this function
            List<int> alertlist = new List<int>();
            for (int i = expenditure.Length-1; i >= d;i--){
                alertlist.Add(expenditure[i]);
            }
            alertlist.Sort();
            int median = findmedianhere(alertlist);
            int count = 0;
            foreach(var i in alertlist){
                if (i > median) count++;
            }
            return count;
        }

        private static int findmedianhere(List<int> alertlist)
        {
            List<int> elements = new List<int>();
            foreach (var i in alertlist)
            {
                elements.Add(i);
            }
            elements.Sort();
            return elements[alertlist.Count / 2];
        }

        static void Mains(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] expenditure_temp = Console.ReadLine().Split(' ');
            int[] expenditure = Array.ConvertAll(expenditure_temp, Int32.Parse);
            int result = activityNotifications(expenditure, d);
            Console.WriteLine(result);
        }
    }
}
