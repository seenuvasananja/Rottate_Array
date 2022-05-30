using System;

namespace Count_Smaller_number_of_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers are smaller than the current number");
            int size;

            Console.WriteLine("Enter the size of an Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] InputArray = new int[size];
            int[] OutputArray = new int[size];
            Console.WriteLine("Enter the Element of an Array");
            for (int i=0;i< size;i++)
            {
                InputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Output");
            OutputArray = FindSmaller(size, InputArray);
            for (int i=0;i<size;i++)
            {
                Console.WriteLine(OutputArray[i]);
            }
            Console.ReadLine();

        }
        public static int[] FindSmaller(int size,int[] input)
        {
            int temp;
            int[] output = new int[size];
            for (int i=0;i<size;i++)
            {
                temp = 0;
                for (int j=0;j<size;j++)
                {
                    if(input[j]< input[i] && j != i)
                    {
                        temp++;
                    }
                }
                output[i] = temp;
            }
            return output;
        }
    }
}
