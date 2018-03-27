using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace playground
{
    class MainClass
    {
        static int[] breakingRecords(int[] score)
        {
            int min = score[0];
            int max = score[0];
            int minSwap = 0;
            int maxSwap = 0;
            int[] result = new int[2];
            for (int i = 1; i < score.Length;i++){
                if(score[i]>max){
                    max = score[i];
                    maxSwap++;
                }
                if (score[i]<min)
                {
                    min = score[i];
                    minSwap++;
                }
            }
            result[0] = maxSwap;
            result[1] = minSwap;
            return result;
        }

        static void Maisn(string[] args)
        {
       //     TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp));
            int[] result = breakingRecords(score);

            Console.WriteLine(string.Join(" ", result));


        }
    }
}
