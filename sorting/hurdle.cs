using System;
using System.Collections.Generic;

namespace sorting
{
    public class hurdle
    {
        static int beautifulDays(int i, int j, int k)
        {
            // Complete this function
            int reverse;
            int count = 0;
            for (int starting = i; starting <= j;starting++){
                reverse = findReverse(starting);
                if ((reverse - starting) % k == 0) count++;
            }
            return count;
        }

        private static int findReverse(int starting)
        {
            int Number = starting;  
            int Reverse = 0;  
            while(Number>0)  
            {  
                int remainder = Number % 10;  
                Reverse = (Reverse * 10) + remainder;  
                Number = Number / 10;  
            }
            return Reverse;
        }

        static void Main(String[] args)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            int k = Convert.ToInt32(tokens_i[2]);
            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);
        }
    }
}
