using System;

namespace selectionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Selection sort");
            int [] array={2,4,1,3};
            for(int i=0;i<array.Length-1;i++)
            {
             int index,temp;
             index=i;
               for(int j=i+1;j<array.Length;j++)
               {
                  if(array[j]<array[index])
                  {
                    index=j;

                  }

               }
                temp=array[i];
                array[i]=array[index];
                array[index]=temp;
            }

             Console.WriteLine();
            Console.Write("selection Sort ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        
        }
    }
}
