using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace playground
{
    public class birthdaybar
    {

       

        static void Main(String[] args)
        {
            int n = 10;
            int[] ar = new int[10];
            ar[0] = 1;
            ar[1] = 1;
            for (int i = 2; i <= 9;i++){
                ar[i] = ar[i - 1] + ar[i - 2];
            } 
            foreach(var i in ar){
                Console.Write(i+"\t");
            }
        }
    }
}
