 using System;
using System.Collections.Generic;

namespace balanced_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balanced Array");
            int size;
            Console.WriteLine("Enter the size of an Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] InputArray = new int[size];
            int OutputList;
            Console.WriteLine("Enter the Array Element");
            for (int i =0;i< size;i++)
            {
                InputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Shuffled");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(InputArray[i]);
            }
            Console.WriteLine("After Shuffled");
            OutputList = Balanced_array(size, InputArray);
            Console.WriteLine(OutputList);
            Console.ReadLine();
           
        }
        public static int Balanced_array(int size,int[] InpuArray)
        {
            int output;
            int[] LeftSumArray = new int[size];
            int[] RightSumArray = new int[size];
            LeftSumArray[0] = InpuArray[0];
            
            for (int i=1;i< InpuArray.Length;i++)
            {

                LeftSumArray[i] = InpuArray[i] + LeftSumArray[i - 1] ;  
            }
            RightSumArray[size - 1] = InpuArray[size - 1];

            for (int i = size-2;i>=0;i--)
            {
                RightSumArray[i] = InpuArray[i] + RightSumArray[i + 1];
            }
            for (int i=1;i< size-1;i++)
            {
                if (LeftSumArray[i]== RightSumArray[i])
                {
                    output = InpuArray[i];
                    return output;
                }
            }

            return -1;

        }
    }
}
