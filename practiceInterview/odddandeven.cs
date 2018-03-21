using System;
using System.Collections.Generic;

namespace practiceInterview
{
    public class odddandeven
    {
        public odddandeven()
        {
        }
        public static void Mains(String [] args){
            int[] arr = { 1,3,5,4 };
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            if(evenList.Capacity==0||oddList.Capacity==0){
                Console.WriteLine("Insuff items");
                return;
            }
            for (int i = 0; i < 9;i++){
                if (arr[i] % 2 == 0) evenList.Add(arr[i]);
                else oddList.Add(arr[i]);
            }
            int []newArray= new int[9];
            int evenindex = 0;
            int oddindex = 0;
            for (int i = 0; i < 9;i++)
            {
                if (i % 2 == 0) {
                    newArray[i] = oddList[oddindex];
                    oddindex++;   
                }else {
                    newArray[i] = evenList[evenindex];
                    evenindex++;        
                }
            }
            foreach(var i in newArray){
                Console.Write(i+"\t");
            }

        }
    }
}
