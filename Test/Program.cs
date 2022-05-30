using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int numberOfRotate;
            
            Console.WriteLine("Enter the Size Of an Array");
             size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Of Rotate");
            numberOfRotate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Array Element");
            int[] input = new int[size];
            int[] AfterRotate = new int[size];
            for (int i=0;i<size;i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Rotate");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.WriteLine("After Rotate");
            AfterRotate= Rotate(size, numberOfRotate, input);
            for (int i=0;i< size;i++)
            {
                Console.WriteLine(AfterRotate[i]);
            }
            Console.ReadLine();
        }

        public static int[] Rotate(int size, int numberOfRotate,int[] inputArray)
        {
            int temp = 0 ;
            int k = 1;
            int[] output = new int[size];
            if (size==0)
            {
                return output;
            }
            else
            {
                while(k<=numberOfRotate) { 
                for (int i=0; i<size-1;i++)
                {
                    if (i == 0)
                    temp = inputArray[0];

                    inputArray[i] = inputArray[i + 1];
                    
                }
                    inputArray[size - 1] = temp;
                    k++;
                }
            }
            return inputArray;
        }
    }
}
