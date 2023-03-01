using System.Runtime.CompilerServices;

namespace Заполнение_двумерного_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] NewArray = new int[3, 4];
            Random RandomNamberArray = new Random();

            for (int i = 0; i < NewArray.GetLength(0); i++)// создание рандомных чисел в массиве
            {
                for (int j = 0; j < NewArray.GetLength(1); j++)
                {
                    NewArray[i, j] = RandomNamberArray.Next(11, 19);
                }
            }    

            for (int y = 0; y < NewArray.GetLength(0); y++)//вывод в виде таблицы
            {
                    for (int x = 0; x < NewArray.GetLength(1); x++)
                    {
                        Console.Write(NewArray[y,x] + "\t");
                    }
                    Console.WriteLine();
            }
            
        }
    }
}