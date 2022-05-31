using System;
using System.Collections.Generic;

namespace Alternate_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alternate Sorting");
            int size;
            Console.WriteLine("Enter the Size of an Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] InputArray = new int[size];
            List<int> list = new List<int>();
            Console.WriteLine("Enter the Element of an Array");
            for(int i=0;i<size;i++)
            {
                InputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Alternate Sorting");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(InputArray[i]);
            }
            Console.WriteLine("After Alternate Sorting");
            list = Alternate_Sorting(size, InputArray);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }

        public static List<int> Alternate_Sorting(int size,int[] InputArray)
        {
            int temp = 0;
            List<int> output = new List<int>();
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

           
            int p = 0, q = size - 1;
            while (p<q)
            {
                
                output.Add(InputArray[q--]);
                output.Add(InputArray[p++]);

            }
            if (size%2 != 0)
            {
                output.Add(InputArray[p]);
            }
            return output;
        }
    }
}
