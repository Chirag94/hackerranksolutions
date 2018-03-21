using System;
namespace practiceInterview
{
    public class datastructure
    {
        static int head = -1;
        static int tail = -1;
        static int[] ar = new int[10];
        public static void Mains(String [] args)
        {
          
            //delete should remove element from front
            //element should be added in the last
            addElement(10);
            iterate();
            addElement(4);
            iterate();
            int temp= deleteElement();
            Console.WriteLine("Deleted element is "+temp);
            iterate();
            temp= deleteElement();
            iterate();
            Console.WriteLine("Deleted element is "+temp);
       }

        private static void iterate()
        {
            for (int i = head; i <= tail;i++){
                Console.Write(ar[i] +"\t");
            }
            Console.WriteLine("");
        }

        private static int deleteElement()
        {
            if (head == -1) return -1;
            else{
                int deletedElement = ar[head];
                head++;
                return deletedElement;
            }
        }

        private static void addElement(int v)
        {
            if(head==-1){
                head++;
            }
            tail++;
            ar[tail] = v;
        }

    }
}
