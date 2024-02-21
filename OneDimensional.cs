using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fpgiuh
{
    public sealed class OneDimensional : IOneDimensionalArray
    {
        private int[] array;

        public OneDimensional(int length, bool choice) 
        {
            array = new int[length];
            if (choice)
            {
                fill_RandomArray();
            }
            else
            {
                fillArray_by_User();
            }
        }

        void fill_RandomArray()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-150, 150);
            }
        }

        void fillArray_by_User()
        {
            for (int i = 0; i < array.Length; i++)
            {
               array[i] = int.Parse(Console.ReadLine());
                
            }

        }

        decimal IBaseArray.Average_Value()
        {
            Console.WriteLine("\nЗадание 1");
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                counter += array[i];
            }
            return counter / array.Length;
        }


        public void over_one_hundred()
        {
            Console.WriteLine("\nЗадание 2");
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 100)
                {
                    counter += 1;
                }
            }
            int[] new_Array = new int[counter];
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 100)
                {
                    new_Array[x] = array[i];
                    x++;
                }
            }
            foreach (var item in new_Array)
            {
                Console.WriteLine(item);
            }
        }
        
        public void Create(bool choice1)
        {
            if (choice1)
            {
                fill_RandomArray();
            }
            else
            {
                fillArray_by_User();
            }
        }

        void IOneDimensionalArray.without_repeats()
        {
            Console.WriteLine("\nЗадание 3");
            int newArrayLength = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        newArrayLength--;
                        break;
                    }
                }
            }
            int[] newArray = new int[newArrayLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.MinValue;
            }
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!Exists(array[i], newArray))
                {
                    newArray[counter] = array[i];
                    counter++;
                }
            }
        }

        private static bool Exists(int value, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        void IPrinter.Print()
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}

