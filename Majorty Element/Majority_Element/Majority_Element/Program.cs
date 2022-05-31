using System;

namespace Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Majority Element!");
            int size;
            Console.WriteLine("Enter The Size of an Array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] InputArray = new int[size];
            string result = "";
            Console.WriteLine("Enter the Element of an Array");
            for (int i=0;i<size;i++)
            {
                InputArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Output");
            result = Majority_Element_Array(size, InputArray);
            Console.WriteLine(result);
            Console.ReadLine();

        }
       public static string Majority_Element_Array(int size,int[] InputArray)
        {
            string result = "";
            int[] OutputArray = new int[size];
            int maxResult = 0 ;
           
            for (int i = 0; i < size;i++)
            {
                int Count = 0;
                for (int j=0;j< size;j++)
                {
                    if(InputArray[i]== InputArray[j])
                    {
                        Count++;
                    }

                }
                OutputArray[i] = Count;
            }
            for (int i=0;i< OutputArray.Length;i++)
            {
                if(OutputArray[i]> OutputArray.Length/2 && OutputArray[i]>maxResult)
                {
                    maxResult = InputArray[i];
                      
                }
                

            }
            if (maxResult==0)
            {
                result = "Ther is no Majority Element";
            }
            else
            {
                result = "Majority Element is " + maxResult;
            }
            return result;
        }
    }
}
