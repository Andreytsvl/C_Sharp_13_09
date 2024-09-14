// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Рекурсия.

// void OpenMatr(int size)
// {
//     Console.WriteLine($"Открывается матрёшка размера {size}");
//     // Базовый случай: самая маленькая матрёшка
//     if (size == 2)
//     {
//         Console.WriteLine($"Получена самая маленькая матрёшка!");
//         return;
//     }
//     OpenMatr(size-1);
// }
// OpenMatr(5);

// Обратный случай: функция "зависает", пока не выполнен базовый случай,
// потом срабатывает (раскручивание рекурсии)

// void OpenMatr(int size)
// {

//     // Базовый случай: самая маленькая матрёшка
//     if (size == 1)
//     {
//         Console.WriteLine($"Получена самая маленькая матрёшка!");
//         return;
//     }
//     OpenMatr(size-1);
//     Console.WriteLine($"Открывается матрёшка размера {size}");
// }
// OpenMatr(5);

// int Fact(int n)
// {
//     if ((n == 1)||(n==0))
//     {
//         Console.WriteLine("stop"); // отладочный вывод
//         return 1;
//     }
//     Console.WriteLine(n); // отладочный вывод
//     return n * Fact(n - 1);
// }
// Console.WriteLine(Fact(5));

// task 46 Задайте двумерный массив размерами м*н,
// заполненный случайными числами

using System;
using static System.Console;

// Clear();
// Write("Введите размер массива через пробел ");
// string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]),-10,10);
// PrintArray(array);

// int[,] GetArray(int rows, int columns, int min, int max)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < result.GetLength(0); i++) // метод возвращает значение ровс (на нулевой позиции)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {

//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");

//         }
//         WriteLine();
//     }

// }

// task 48 Задайте двумерный массив размера м на н
// каждый элемент в массиве находится по формуле Амн = м+н

// Clear();
// Write("Введите размер массива через пробел ");
// string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]));
// PrintArray(array);

// int[,] GetArray(int rows, int columns)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < result.GetLength(0); i++) // метод возвращает значение ровс (на нулевой позиции)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {

//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");

//         }
//         WriteLine();
//     }

// }

// task 49
// Задайте двумерный массив. Найдите эл-ты, у которых оба индекса
// чётные , и замените эти эл-ты на их квадраты
// Clear();
// Write("Введите размер массива через пробел ");
// string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);
// PrintArray(array);
// int[,] array1 = SqArray(array); // мой способ
// PrintArray(array1); // мой способ
// ChangeArrey(array);
// PrintArray(array);

// int[,] GetArray(int rows, int columns, int min, int max)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < result.GetLength(0); i++) // метод возвращает значение ровс (на нулевой позиции)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// int[,] SqArray(int[,] inArray) // мой способ
// {
//     int[,] result1 = new int[inArray.GetLength(0), inArray.GetLength(1)];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if ((i % 2 == 0) && (j % 2 == 0) && (i > 0) && (j > 0))
//             {
//                 result1[i, j] = array[i, j] * array[i, j];
//             }
//             else
//             {
//                 result1[i, j] = array[i, j];
//             }
//         }
//     }
//     return result1;
// }

// void ChangeArrey(int[,] inArray) //второй способ
// {
//     for (int i = 2; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 2; j < inArray.GetLength(1); j++)
//         {
//             if ((i % 2 == 0) && (j % 2 == 0))
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }

//         }
//     }
// }


// void PrintArray(int[,] inArray)
// {

//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");

//         }
//         WriteLine();
//     }
//     WriteLine();

// }

// task 51 Задайте Двумерный массив
// Найдите сумму элементов на главной диагонали
// (с индексами (0;0);(1;1) и т.д.)
// Clear();
// Write("Введите размер массива через пробел ");
// string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);
// PrintArray(array);
// Write($"Сумма главной диагонали {SumDiagArrey(array)}");

// int[,] GetArray(int rows, int columns, int min, int max)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < result.GetLength(0); i++) // метод возвращает значение ровс (на нулевой позиции)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// int SumDiagArrey(int[,] inArray)
// {
//     int sum = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum = sum + inArray[i, j];
//             }

//         }
//     }
//     return sum;
// }

// task 47 DZ Задайте двумерный массив
// размером м на н , заполненый случайными
// вещественными числами
// Clear();
// Write("Введите размер массива через пробел ");
// string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// double[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);
// PrintArray(array);

// double[,] GetArray(int rows, int columns, int min, int max)
// {
//     double[,] result = new double[rows, columns];
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = ((double)(new Random().Next(min*10, (max + 1)*10)))/10;
//             // преобразует к вещественному с 1 знаком после запятой 
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// task 50 DZ 
// Напишите программу, которая на вход принимает значение
// элемента в массиве, и возвращает инф. о его наличии в массиве
// Clear();
// Write("Введите размер массива через пробел ");
// string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);

// PrintArray(array);
// Write("Введите значение элемента ");
// int n = int.Parse(ReadLine());
// ElementInArrey(array, n);


// int[,] GetArray(int rows, int columns, int min, int max)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// void ElementInArrey(int[,] inArray, int n)
// {
//     int stop = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         if (stop == 1)
//         {
//             break;
//         }
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (inArray[i, j] == n)
//             {
//                 Write("элемент найден ");
//                 stop = 1;
//                 break;
//             }


//         }

//     }
//     if (stop == 0)
//     {
//         Write("элемент не найден");
//     }

// }

// task 52 DZ 
// Задайте двумерный массив из целых чисел Найдите 
// среднее арифметическое в каждом столбце
Clear();
Write("Введите размер массива через пробел ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]), 0, 10);
PrintArray(array);
WriteLine($" Среднее арифметическое каждого столбца = {String.Join(";",GetSumColumn(array))}");


int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

double[] GetSumColumn(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double a = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            a += inArray[j,i];

           
        }
        result[i] = Math.Round(a/inArray.GetLength(0),2); // Округляет до второго знака
    }
    return result;
}


