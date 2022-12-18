using System;

namespace mynamespase
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            for(int i = 0; i < array.GetUpperBound(1) + 1; i++)     //Столбцы
            {
                for(int k = 0; k < array.GetUpperBound(0) + 1; k++)     //Строки
                {
                    Console.Write(array[k,i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}