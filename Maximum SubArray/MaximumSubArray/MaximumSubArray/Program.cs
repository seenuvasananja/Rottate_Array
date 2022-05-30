using System;

namespace MaximumSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Sub Array!");
            int size;
            Console.WriteLine("Enter the Size of an Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[size];
            Console.WriteLine("Enter the Array Element");
            for (int i=0;i<size;i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Maximum Sum of the Sub Array is");
           Console.WriteLine(sumMaximum(size, inputArray));
            Console.ReadLine();
        }
        public static int sumMaximum(int size,int[] InputArray)
        {
            int sum = 0;
            int max = Int32.MinValue;
            for(int i = 0; i < size; i++) { 
                max = Math.Max(max, InputArray[i]);
            }
            for (int i=0;i<size;i++)
                {
                if(sum + InputArray[i] < 0)
                {
                    sum = 0;
                    continue;
                }
                else
                {
                    sum += InputArray[i];
                    max = Math.Max(sum, max);
                }

                }
            return max;



        }
    }
}
