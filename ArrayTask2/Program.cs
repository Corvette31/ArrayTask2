using System;

namespace ArrayTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arrayColumns = 10;
            int arryaRows = 10;
            int itemMinValue = 1;
            int itemMaxValue = 10;
            int[,] array = new int[arryaRows, arrayColumns];
            int maxNumber = int.MinValue;
            int maxNumberValue = 0;

            Console.WriteLine("Исходная матрица\n");

            for (int i = 0; i < arryaRows; i++)
            {
                for (int j = 0; j < arrayColumns; j++)
                {
                    array[i, j] = random.Next(itemMinValue, itemMaxValue);
                    Console.Write($"{array[i, j]} ");

                    if (array[i, j] > maxNumber)
                    {
                        maxNumber = array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nИзмененная матрица\n");

            for (int i = 0; i < arryaRows; i++)
            {
                for (int j = 0; j < arrayColumns; j++)
                {
                    if (array[i, j] == maxNumber)
                    {
                        array[i, j] = maxNumberValue;
                    }

                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
