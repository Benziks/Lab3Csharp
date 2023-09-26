using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lessons
{

    class Program
    {

        static void Main(string[] args)
        {

            //912 Имеется Двумерный массив целых чисел.
            //Найти номер строки, для которой среднеарифметическое значение ее элементов максимально.
            // Пример матрицы
            //1 2 3 4 5

            //2 3 4 5 1

            //3 4 5 1 2

            //4 5 1 2 3

            //5 1 2 3 4

            Task912();
            Console.WriteLine("task912 Закончил свою работу!\n");

            //919 В Двумерном массиве целых чисел поменять местами строки, симметричные относительно середины массива (горизонтальной линии).

            Task919();
            Console.WriteLine("task919 Закончил свою работу!\n");

            //938 Известен номер строки, на которой расположен элемент главной диагонали массива.
            //Вывести на экран значение этого элемента.

            Task938();
            Console.WriteLine("task938 Закончил свою работу!\n");

            //975 Даны вещественные числа a1, a2, …, an.
            //Получить квадратную матрицу порядка n:

            Task975();
            Console.WriteLine("task975 Закончил свою работу!");


            Console.ReadLine();
        }

        static void Task912()
        {

            Random random = new Random();
            int n = random.Next(2, 8);
            int[,] ArrayOfIntegers = new int[n, n];

            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    ArrayOfIntegers[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    Console.Write(ArrayOfIntegers[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int maxRow = 0;
            double maxAverage = 0;

            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    sum += ArrayOfIntegers[i, j];

                }
                int average = sum / ArrayOfIntegers.GetLength(1);

                if (average > maxAverage)
                {
                    maxAverage = average;
                    maxRow = i;
                }

            }
            Console.WriteLine("Максимальное среднеарифметическое значение на строке: " + maxRow);
            Console.WriteLine("Среднее арифметическое чисел в строке:" + maxAverage);

        }
        static void Task919()
        {
            Random random = new Random();
            int[,] ArrayOfIntegers = new int[random.Next(2, 7), random.Next(2, 5)];

            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    ArrayOfIntegers[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    Console.Write(ArrayOfIntegers[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < ArrayOfIntegers.GetLength(0) / 2; i++)
            {
                int symmetricRowIndex = ArrayOfIntegers.GetLength(0) - 1 - i;
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    int lineNumber = ArrayOfIntegers[i, j];
                    ArrayOfIntegers[i, j] = ArrayOfIntegers[symmetricRowIndex, j];
                    ArrayOfIntegers[symmetricRowIndex, j] = lineNumber;

                }
                Console.WriteLine();
            }

            Console.WriteLine("Ваш изменненый массив: ");
            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    Console.Write(ArrayOfIntegers[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

        static void Task938()
        {
            Random random = new Random();
            int[,] ArrayOfIntegers = new int[5, 5];
            int rowNumber = random.Next(0, 5);

            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    ArrayOfIntegers[i, j] = random.Next(100);
                }
            }

            int diagonalElement = ArrayOfIntegers[rowNumber, rowNumber];

            for (int i = 0; i < ArrayOfIntegers.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayOfIntegers.GetLength(1); j++)
                {
                    Console.Write(ArrayOfIntegers[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Значение элемента на главной диагонали: " + diagonalElement);

        }

        static void Task975()
        {
            Random random = new Random();

            double[] numbers = new double[random.Next(4, 10)];
            double[,] arrayOfRealNumbers = new double[numbers.Length - 1, numbers.Length - 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = -50 + random.NextDouble() * (50 + 50);
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    arrayOfRealNumbers[i, j] = numbers[(i + j) % (numbers.Length - 1)];
                    arrayOfRealNumbers[i, j] = Math.Round(arrayOfRealNumbers[i, j], 2);

                }
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    Console.Write(arrayOfRealNumbers[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

    }
}










