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

Clear();
Write("Введите размер массива через пробел ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetArray(int.Parse(nums[0]), int.Parse(nums[1]));
PrintArray(array);

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++) // метод возвращает значение ровс (на нулевой позиции)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = i + j;
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
