using System;

namespace SortArrayWaveForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort Array Wave Form");
            int size;
            Console.WriteLine("Enter the Size of an Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] InputArray = new int[size];
            int[] Output = new int[size];

            Console.WriteLine("Enter the Element of an Array");
            for (int i=0;i<size;i++)
            {

                InputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Bofore");
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine(InputArray[i]);
            }
            Console.WriteLine("After");
            Output = SortWaveForm(size,InputArray);
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine(Output[i]);
            }
            Console.ReadLine();
        }
        public static int[] SortWaveForm(int size,int[] InputArray)
        {
            
            for (int i=0;i<size-1;i++)
            {
                if (i % 2 == 0)
                {
                    if(!(InputArray[i]< InputArray[i + 1])){ 
                    int temp = InputArray[i];
                    InputArray[i] = InputArray[i + 1];
                    InputArray[i + 1] = temp;
                    }
                }
                else
                {
                    if (!(InputArray[i] > InputArray[i + 1]))
                    {
                        int temp = InputArray[i];
                        InputArray[i] = InputArray[i + 1];
                        InputArray[i + 1] = temp;
                    }

                }
            }
            return InputArray;
        }
    }
}
