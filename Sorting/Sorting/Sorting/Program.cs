using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting!");
            int size;
            Console.WriteLine("Enter the Size of an Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] InputArray = new int[size];
            int[] OutputArray = new int[size];
            Console.WriteLine("Enter the Elemement of an Array");
            for (int i=0;i< size;i++)
            {
                InputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Sort");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(InputArray[i]);
            }
            Console.WriteLine("After Sorting");
            OutputArray = Sorting(size, InputArray);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(OutputArray[i]);
            }
            Console.ReadLine();
        }
        public static int[] Sorting( int size, int[] InputArray)
        {
            int temp=0;
            for (int i=0;i<= size-1;i++)
            {
                for (int j=i+1;j<size;j++)
                {
                    if (InputArray[i]> InputArray[j])
                    {
                        temp = InputArray[i];
                        InputArray[i] = InputArray[j];
                        InputArray[j] = temp;
                    }
                }
            }
            return InputArray;
        }
    }
}
