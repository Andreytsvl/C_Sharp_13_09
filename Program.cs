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


