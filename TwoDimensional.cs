using System;
namespace fpgiuh
{
    public sealed class TwoDimensional : BaseArray, IPrinter
    {
        private int rows, columns;
        private int[,] array;

        public TwoDimensional(int rows, int columns, bool choice = false)
        {
            array = new int[rows, columns];
            Create(choice);
        }

        protected override void fillArray_by_User()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }

        protected override void fill_RandomArray()
        {
            Random random = new Random();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(-150, 150);
                }
            }
        }

        private int[,] GetTwoDimensionalArray(int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-150, 150);
                }
                Console.WriteLine();
            }
            return array;
        }

        public override decimal Average_Value()
        {
            Console.WriteLine("\nЗадание 1");
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    counter += array[i, j];
                }
            }
            return counter / array.Length;
        }

        public override void Print()
        {
            Console.WriteLine("\nЗадание 2.1");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

        void IPrinter.Print() {

            Console.WriteLine("\nЗадание 2.2");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    var element = i % 2 == 0
                        ? array[i, array.GetLength(1) - 1 - j]
                        : array[i, j];
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

