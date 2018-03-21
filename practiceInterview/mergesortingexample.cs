using System;
namespace practiceInterview
{
    public class mergesortingexample
    {
        public static void Main2(String [] args)
        {
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            functionMain(numbers, 0, max - 1);
        }

        private static void functionMain(int[] numbers, int startingPosition, int endingPosition)
        {
            int mid;
            if(endingPosition>startingPosition)
            {
                mid =( startingPosition + endingPosition )/ 2;
                functionMain(numbers, startingPosition ,mid);
                functionMain(numbers, mid + 1, endingPosition);
                masterMerge(numbers, startingPosition, mid+1, endingPosition);
            }
        }

        private static void masterMerge(int[] numbers, int startingPosition, int mid, int endingPosition)
        {
            int[] temp = new int[numbers.Length];
            int k = 0;
            int tempposition = mid;
            while(startingPosition<tempposition&&mid<endingPosition){
                if(numbers[startingPosition]<numbers[mid]){
                    temp[k] = numbers[startingPosition];
                    startingPosition++;
                }
                else if(numbers[mid]<numbers[startingPosition]){
                    temp[k] = numbers[mid];
                    mid++;
                }
                k++;
            }
            if(startingPosition>=mid){
                while(mid!=endingPosition){
                    temp[k] = numbers[mid++];
                    mid++;
                    k++;
                }
            }
            else{
                while (mid != startingPosition)
                {
                    temp[k] = numbers[startingPosition++];
                    startingPosition++;
                    k++;
                }
            }

            for (int i = 0; i < endingPosition; i++)
                Console.WriteLine(temp[i]);
        }
    }
}
